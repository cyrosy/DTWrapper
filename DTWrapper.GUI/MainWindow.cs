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
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;

using DTWrapper.BDD;
using DTWrapper.Helpers;
using DTWrapper.ShellExtension;

namespace DTWrapper.GUI
{
    public partial class MainWindow : Form
    {
        private Options _options = new Options();
        private ResourceManager Locale = new ResourceManager("DTWrapper.GUI.MainWindow", typeof(MainWindow).Assembly);
        private VirtualDrive virtualDrive;
        private ProgList progList = new ProgList();

        public MainWindow()
        {
            InitializeComponent();
            this.Load += new EventHandler(findDT);
            this.Shown += MainWindow_Shown;
            refreshWindow();
            
            _options.Reload();

            switch (_options.ListView)
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

        void MainWindow_Shown(object sender, EventArgs e)
        {
            JumpListHelper.Update();
        }

        #region Actions

        public void findDT(object sender, EventArgs e) { findDT(); }
        public void findDT()
        {
            InfoWindow info = new InfoWindow(Locale.GetString("DT.Searching"));
            info.Show(this);
            if (DT.Type == DTType.None)
            {
                LogHelper.RaiseError(this, Locale.GetString("DT.NotFound"));
                this.DTVersion.Text = Locale.GetString("DT.NotFound");
                info.Close();
            }
            else
            {
                this.DTVersion.Text = "DT " + DT.Type.ToString() + " " + DT.Version;
                LogHelper.WriteLine(this.DTVersion.Text, LogHelper.MessageType.INFO);
                if (!_options.FileExists() || !_options.Reload() || !_options.VirtualDrive.IsValid)
                {
                    info.Close();
                    editOptions();
                }
                else
                {
                    virtualDrive = _options.VirtualDrive;
                    selectedDrive.Text = virtualDrive.ToString();
                    info.Close();
                }
            }
        }

        private void refreshWindow()
        {
            refreshProgs();
            refreshButtonsState();
        }

        private void addProg()
        {
            EditProgWindow editProg = new EditProgWindow(progList);
            editProg.ShowDialog(this);
            refreshWindow();
        }

        private bool startSelectedProg()
        {
            refreshButtonsState();
            if (!this.startButton.Enabled) return false;
            
            InfoWindow info = new InfoWindow(Locale.GetString("Prog.Preparing"));
            info.Show(this);

            Prog prog = progList.Get(Int32.Parse(progsListView.SelectedItems[0].Name));
            if (prog.DiskImage.Length > 0 && !virtualDrive.IsValid)
            {
                info.Close();
                return false;
            }

            this.Hide();
            this.trayIcon.Text = String.Format(Locale.GetString("trayIcon.Text"), prog.Name);
            this.trayIcon.Visible = true;
            info.Close();

            info = new InfoWindow(String.Format(Locale.GetString("Prog.Mounting"), prog.DiskImage, prog.Name));
            info.Show(this);
            if (!prog.MountDiskImage(virtualDrive)) info.Close();
            else
            {
                info.Close();
                info = new InfoWindow(String.Format(Locale.GetString("Prog.Starting"), prog.Name));
                Process proc = prog.Start();
                info.Close();
                proc.WaitForExit();


                if (prog.DiskImage.Length > 0)
                {
                    info = new InfoWindow(String.Format(Locale.GetString("Prog.Unmounting"), prog.DiskImage));
                    info.Show(this);
                    virtualDrive.Umount();
                    info.Close();
                }
            }

            this.trayIcon.Visible = false;
            refreshWindow();
            this.Show();
            return true;
        }

        private void editSelectedProg()
        {
            if (this.progsListView.SelectedItems.Count == 1)
            {
                EditProgWindow editGame = new EditProgWindow(progList, Int32.Parse(progsListView.SelectedItems[0].Name));
                editGame.ShowDialog(this);
            }
            JumpListHelper.Update();
            refreshWindow();
        }

        private void deleteSelectedProg()
        {
            if (this.progsListView.SelectedItems.Count == 1)
            {
                Prog prog = progList.Get(Int32.Parse(progsListView.SelectedItems[0].Name));
                if (prog == null)
                {
                    LogHelper.RaiseError(this, Locale.GetString("Prog.NotFound"));
                }
                else if (MessageBox.Show(this, String.Format(Locale.GetString("Prog.AskDelete.Message"), prog.Name), Locale.GetString("Prog.AskDelete.Title"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (progList.Del(prog))
                    {
                        LogHelper.RaiseSuccess(this, String.Format(Locale.GetString("Prog.Deleted"), prog.Name));
                    }
                    else
                    {
                        LogHelper.RaiseError(this, String.Format(Locale.GetString("Prog.NotDeleted"), prog.Name));
                    }
                }
            }
            refreshWindow();
        }

        private void createShortcutSelectedProg()
        {
            if (progsListView.SelectedItems.Count == 1)
            {
                Prog prog = progList.Get(Int32.Parse(progsListView.SelectedItems[0].Name));
                ShortcutHelper.createShortcut(prog);
            }
        }

        private void refreshProgs()
        {
            this.progsListView.Items.Clear();
            this.smallIcons.Images.Clear();
            this.largeIcons.Images.Clear();

            ColumnHeaderAutoResizeStyle resizeStyle = ColumnHeaderAutoResizeStyle.HeaderSize;

            foreach (Prog prog in progList.Progs)
            {
                bool valid = true;
                ListViewItem item = new ListViewItem(prog.Name, prog.ID.ToString());
                item.Name = prog.ID.ToString();
                item.Checked = true;
                item.ToolTipText = prog.ID.ToString();

                ListViewItem.ListViewSubItem exeItem = new ListViewItem.ListViewSubItem(item, prog.Path);
                exeItem.Tag = "Exe";
                item.SubItems.Add(exeItem);
                if (!prog.PathOK())
                {
                    valid = false;
                    item.ToolTipText += Locale.GetString("Error.InvalidExe");
                }

                ListViewItem.ListViewSubItem isoItem = new ListViewItem.ListViewSubItem(item, prog.DiskImage);
                exeItem.Tag = "Disk Image";
                item.SubItems.Add(prog.DiskImage);
                if (!prog.DiskImageOK())
                {
                    valid = false;
                    item.ToolTipText += Locale.GetString("Error.InvalidIso");
                }

                if (!prog.IconOK())
                {
                    valid = false;
                    item.ToolTipText += Locale.GetString("Error.InvalidIcon");
                }

                try
                {
                    if(!valid)
                    {
                        item.Checked = false;
                        smallIcons.Images.Add(prog.ID.ToString(), DTWrapper.GUI.Properties.Resources.warning);
                        largeIcons.Images.Add(prog.ID.ToString(), DTWrapper.GUI.Properties.Resources.warning);
                    }
                    else
                    {
                        smallIcons.Images.Add(prog.ID.ToString(), Icon.ExtractAssociatedIcon(prog.Icon));
                        largeIcons.Images.Add(prog.ID.ToString(), Icon.ExtractAssociatedIcon(prog.Icon));
                    }
                }
                catch (Exception e)
                {
                    LogHelper.WriteLine(e.ToString(), LogHelper.MessageType.ERROR);
                }

                this.progsListView.Items.Add(item);
                resizeStyle = ColumnHeaderAutoResizeStyle.ColumnContent;
            }

            nameColumn.AutoResize(resizeStyle);
            exeColumn.AutoResize(resizeStyle);
            isoColumn.AutoResize(resizeStyle);
            
            refreshButtonsState();
        }

        private void refreshButtonsState()
        {
            if (this.progsListView.SelectedItems.Count > 0)
            {
                if (this.progsListView.SelectedItems[0].Checked
                && virtualDrive.IsValid)
                {
                    this.startButton.Enabled = true;
                }
                this.editButton.Enabled = true;
                this.deleteButton.Enabled = true;
                this.shortcutButton.Enabled = true;
            }
            else
            {
                this.startButton.Enabled = false;
                this.editButton.Enabled = false;
                this.deleteButton.Enabled = false;
                this.shortcutButton.Enabled = false;
            }
        }

        private void editOptions()
        {
            OptionsWindow options = new OptionsWindow(_options);
            options.ShowDialog(this);
            virtualDrive = _options.VirtualDrive;
            selectedDrive.Text = virtualDrive.ToString();
        }

        private void showAbout()
        {
            AboutWindow about = new AboutWindow();
            about.ShowDialog(this);
        }

        #endregion

        #region Programs List

        private void gamesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshButtonsState();
        }

        private void gamesListView_MouseDoubleClick(object sender, EventArgs e)
        {
            startSelectedProg();
        }

        #endregion

        #region Menu

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addMenuItem_Click(object sender, EventArgs e)
        {
            addProg();
        }

        private void optionsMenuItem_Click(object sender, EventArgs e)
        {
            editOptions();
        }

        private void aboutItem_Click(object sender, EventArgs e)
        {
            showAbout();
        }

        #endregion

        #region Toolbar

        private void addGameButton_Click(object sender, EventArgs e)
        {
            addProg();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            startSelectedProg();
        }

        private void editGameButton_Click(object sender, EventArgs e)
        {
            editSelectedProg();
        }

        private void deleteGameButton_Click(object sender, EventArgs e)
        {
            deleteSelectedProg();
        }

        private void shortcutButton_Click(object sender, EventArgs e)
        {
            createShortcutSelectedProg();
        }

        private void detailsListViewMode_Click(object sender, EventArgs e)
        {
            this.progsListView.View = View.Details;
            _options.ListView = View.Details;
            checkSelectedViewMode(this.detailsListViewMode);
        }

        private void listListViewMode_Click(object sender, EventArgs e)
        {
            this.progsListView.View = View.List;
            _options.ListView = View.List;
            checkSelectedViewMode(this.listListViewMode);
        }

        private void smallIconsListViewMode_Click(object sender, EventArgs e)
        {
            this.progsListView.View = View.SmallIcon;
            _options.ListView = View.SmallIcon;
            checkSelectedViewMode(this.smallIconsListViewMode);
        }

        private void largeIconsListViewMode_Click(object sender, EventArgs e)
        {
            this.progsListView.View = View.LargeIcon;
            _options.ListView = View.LargeIcon;
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
