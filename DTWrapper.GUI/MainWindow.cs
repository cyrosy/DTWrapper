/*
 * This file is part of DTWrapper.
 * 
 * DTWrapper is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * DTWrapper is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with DTWrapper. If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using DTWrapper.Helpers;
using DTWrapper.BLL;
using DTWrapper.POCO;

namespace DTWrapper.GUI
{
    public partial class MainWindow : Form
    {
        private ResourceManager Locale = new ResourceManager("DTWrapper.GUI.MainWindow", typeof(MainWindow).Assembly);
        private VirtualDrive virtualDrive = new VirtualDrive(Properties.Settings.Default.DriveType, Properties.Settings.Default.DriveNum);

        public MainWindow()
        {
            InitializeComponent();
            this.Load += new EventHandler(find_DT);
            refreshWindow();

            switch (Properties.Settings.Default.GamesView)
            {
                case View.LargeIcon:
                    largeIconsListViewMode_Click(null, null);
                    break;
                case View.List:
                    listListViewMode_Click(null, null);
                    break;
                case View.SmallIcon:
                    smallIconsListViewMode_Click(null, null);
                    break;
                default:
                    detailsListViewMode_Click(null, null);
                    break;
            }
        }

        #region Actions

        void find_DT(object sender, EventArgs e)
        {
            if (!RegistryHelper.KeyFound())
            {
                LogHelper.RaiseError(this, Locale.GetString("DT.NotFound"));
                this.DTVersion.Text = Locale.GetString("DT.NotFound");
            }
            else
            {
                this.DTVersion.Text = "DT " + RegistryHelper.Type() + " " + RegistryHelper.Version();
                LogHelper.WriteLine(this.DTVersion.Text, LogHelper.MessageType.INFO);

                if (Properties.Settings.Default.DriveType == DriveType.NONE)
                {
                    editOptions();
                }

                selectedDrive.Text = virtualDrive.ToString();
            }
        }

        private void refreshWindow()
        {
            refreshJeux();
            refreshButtonsState();
        }

        private void addGame()
        {
            EditGameWindow editGame = new EditGameWindow();
            editGame.ShowDialog(this);
            refreshWindow();
        }

        private void startSelectedGame()
        {
            refreshButtonsState();
            if(this.startGameButton.Enabled && virtualDrive.IsValid)
            {
                GamesManager manager = new GamesManager();
                Game game = manager.GetGame(Int64.Parse(gamesListView.SelectedItems[0].Name));
                this.Hide();
                this.trayIcon.Text = String.Format(Locale.GetString("trayIcon.Text"), game.Name);
                this.trayIcon.Visible = true;
                game.play(virtualDrive);
                this.trayIcon.Visible = false;
                refreshWindow();
                this.Show();
            }
        }

        private void editSelectedGame()
        {
            if (this.gamesListView.SelectedItems.Count == 1)
            {
                GamesManager manager = new GamesManager();
                Game game = manager.GetGame(Int64.Parse(gamesListView.SelectedItems[0].Name));
                EditGameWindow editGame = new EditGameWindow(game);
                editGame.ShowDialog(this);
            }
            refreshWindow();
        }

        private void deleteSelectedGame()
        {
            if (this.gamesListView.SelectedItems.Count == 1)
            {
                GamesManager manager = new GamesManager();
                Game game = manager.GetGame(Int64.Parse(gamesListView.SelectedItems[0].Name));
                if (game == null)
                {
                    LogHelper.RaiseError(this, Locale.GetString("Game.NotFound"));
                }
                else if (MessageBox.Show(this, String.Format(Locale.GetString("Game.AskDelete.Message"), game.Name), Locale.GetString("Game.AskDelete.Title"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (manager.DelGame(game))
                    {
                        LogHelper.RaiseSuccess(this, String.Format(Locale.GetString("Game.Deleted"), game.Name));
                    }
                    else
                    {
                        LogHelper.RaiseError(this, String.Format(Locale.GetString("Game.NotDeleted"), game.Name));
                    }
                }
            }
            refreshWindow();
        }

        private void refreshJeux()
        {
            this.gamesListView.Items.Clear();
            this.smallIcons.Images.Clear();
            this.largeIcons.Images.Clear();

            ColumnHeaderAutoResizeStyle resizeStyle = ColumnHeaderAutoResizeStyle.HeaderSize;

            GamesManager manager = new GamesManager();
            foreach (Game game in manager.GetGames())
            {
                bool valid = true;
                ListViewItem item = new ListViewItem(game.Name, game.ID.ToString());
                item.Name = game.ID.ToString();
                item.Checked = true;
                item.ToolTipText = "";

                ListViewItem.ListViewSubItem exeItem = new ListViewItem.ListViewSubItem(item, game.Exe);
                exeItem.Tag = "Exe";
                item.SubItems.Add(exeItem);
                if (!game.exeOK())
                {
                    valid = false;
                    item.ToolTipText += Locale.GetString("Error.InvalidExe");
                }

                ListViewItem.ListViewSubItem isoItem = new ListViewItem.ListViewSubItem(item, game.Iso);
                exeItem.Tag = "Iso";
                item.SubItems.Add(game.Iso);
                if (!game.isoOK())
                {
                    valid = false;
                    item.ToolTipText += Locale.GetString("Error.InvalidIso");
                }

                if (!game.iconOK())
                {
                    valid = false;
                    item.ToolTipText += Locale.GetString("Error.InvalidIcon");
                }

                try
                {
                    if(!valid)
                    {
                        item.Checked = false;
                        smallIcons.Images.Add(game.ID.ToString(), DTWrapper.GUI.Properties.Resources.warning);
                        largeIcons.Images.Add(game.ID.ToString(), DTWrapper.GUI.Properties.Resources.warning);
                    }
                    else
                    {
                        smallIcons.Images.Add(game.ID.ToString(), Icon.ExtractAssociatedIcon(game.Icon));
                        largeIcons.Images.Add(game.ID.ToString(), Icon.ExtractAssociatedIcon(game.Icon));
                    }
                }
                catch (Exception e)
                {
                    LogHelper.WriteLine(e.ToString(), LogHelper.MessageType.ERROR);
                }

                this.gamesListView.Items.Add(item);
                resizeStyle = ColumnHeaderAutoResizeStyle.ColumnContent;
            }

            nameColumn.AutoResize(resizeStyle);
            exeColumn.AutoResize(resizeStyle);
            isoColumn.AutoResize(resizeStyle);
            refreshButtonsState();
        }

        private void refreshButtonsState()
        {
            if (this.gamesListView.SelectedItems.Count > 0)
            {
                if (this.gamesListView.SelectedItems[0].Checked
                && virtualDrive.IsValid)
                {
                    this.startGameButton.Enabled = true;
                    this.startMenuItem.Enabled = true;
                }
                this.editGameButton.Enabled = true;
                this.deleteGameButton.Enabled = true;
                this.gameMenu.Enabled = true;
            }
            else
            {
                this.startGameButton.Enabled = false;
                this.startMenuItem.Enabled = false;
                this.editGameButton.Enabled = false;
                this.deleteGameButton.Enabled = false;
                this.gameMenu.Enabled = false;
            }
        }

        private void editOptions()
        {
            OptionsWindow options = new OptionsWindow();
            options.ShowDialog(this);
            virtualDrive = new VirtualDrive(Properties.Settings.Default.DriveType, Properties.Settings.Default.DriveNum);
            selectedDrive.Text = virtualDrive.ToString();
        }

        private void showAbout()
        {
            AboutWindow about = new AboutWindow();
            about.ShowDialog(this);
        }

        #endregion

        #region Games List

        private void gamesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshButtonsState();
        }

        private void gamesListView_MouseDoubleClick(object sender, EventArgs e)
        {
            startSelectedGame();
        }

        #endregion

        #region Menu

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addGameMenuItem_Click(object sender, EventArgs e)
        {
            addGame();
        }

        private void optionsMenuItem_Click(object sender, EventArgs e)
        {
            editOptions();
        }

        private void startMenuItem_Click(object sender, EventArgs e)
        {
            startSelectedGame();
        }

        private void editMenuItem_Click(object sender, EventArgs e)
        {
            editSelectedGame();
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            deleteSelectedGame();
        }

        private void aboutItem_Click(object sender, EventArgs e)
        {
            showAbout();
        }

        #endregion

        #region Toolbar

        private void addGameButton_Click(object sender, EventArgs e)
        {
            addGame();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            startSelectedGame();
        }

        private void editGameButton_Click(object sender, EventArgs e)
        {
            editSelectedGame();
        }

        private void deleteGameButton_Click(object sender, EventArgs e)
        {
            deleteSelectedGame();
        }

        private void detailsListViewMode_Click(object sender, EventArgs e)
        {
            this.gamesListView.View = View.Details;
            Properties.Settings.Default.GamesView = View.Details;
            Properties.Settings.Default.Save();
            checkSelectedViewMode(this.detailsListViewMode);
        }

        private void listListViewMode_Click(object sender, EventArgs e)
        {
            this.gamesListView.View = View.List;
            Properties.Settings.Default.GamesView = View.List;
            Properties.Settings.Default.Save();
            checkSelectedViewMode(this.listListViewMode);
        }

        private void smallIconsListViewMode_Click(object sender, EventArgs e)
        {
            this.gamesListView.View = View.SmallIcon;
            Properties.Settings.Default.GamesView = View.SmallIcon;
            Properties.Settings.Default.Save();
            checkSelectedViewMode(this.smallIconsListViewMode);
        }

        private void largeIconsListViewMode_Click(object sender, EventArgs e)
        {
            this.gamesListView.View = View.LargeIcon;
            Properties.Settings.Default.GamesView = View.LargeIcon;
            Properties.Settings.Default.Save();
            checkSelectedViewMode(this.largeIconsListViewMode);
        }

        private void checkSelectedViewMode(ToolStripMenuItem selected)
        {
            foreach (ToolStripMenuItem item in this.listViewDisplayModeDropDown.DropDownItems)
            {
                item.Checked = false;
            }
            selected.Checked = true;
        }

        #endregion
    }
}
