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
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using DTWrapper.Helpers;
using DTWrapper.POCO;
using DTWrapper.BLL;

namespace DTWrapper.GUI
{
    public partial class EditGameWindow : Form
    {
        private ResourceManager Locale = new ResourceManager("DTWrapper.GUI.EditGameWindow", typeof(EditGameWindow).Assembly);
        private Game game;
        private string error;

        #region Constructors

        public EditGameWindow()
        {
            InitializeComponent();
            this.AcceptButton = this.saveButton;
            this.CancelButton = this.cancelButton;
            this.Text = Locale.GetString("Title.AddGame");

            this.game = new Game();
        }

        public EditGameWindow(Game game)
        {
            InitializeComponent();
            this.AcceptButton = this.saveButton;
            this.CancelButton = this.cancelButton;
            this.Text = Locale.GetString("Title.EditGame");

            this.game = game;
            this.nameField.Text = game.Name;
            this.exePathField.Text = game.Exe;
            this.isoPathField.Text = game.Iso;
            this.iconPathField.Text = game.Icon;

            updateIconPreview();
        }

        #endregion

        #region Actions
        
        private bool saveGame()
        {
            if (!checkGame())
            {
                LogHelper.RaiseError(this, error);
                return false;
            }

            GamesManager jeuxManager = new GamesManager();

            if (this.game.ID > 0)
            {
                if (jeuxManager.UpdateGame(this.game))
                {
                    return true;
                }
                else
                {
                    LogHelper.RaiseError(this, String.Format(Locale.GetString("Error.Updating"), game.Name));
                    return false;
                }
            }
            else
            {
                if (jeuxManager.AddGame(this.game))
                {
                    return true;
                }
                else
                {
                    LogHelper.RaiseError(this, String.Format(Locale.GetString("Error.Adding"), game.Name));
                    return false;
                }
            }
        }

        private void updateIconPreview()
        {
            if (this.iconPathField.Text.Length > 0)
            {
                try
                {
                    this.iconPreview.Image = Icon.ExtractAssociatedIcon(this.iconPathField.Text).ToBitmap();
                    setOKState(iconLabelState);
                }
                catch (Exception e)
                {
                    LogHelper.WriteLine(e.ToString(), LogHelper.MessageType.ERROR);
                    setWarnState(iconLabelState);
                }
            }
        }

        private void setOKState(System.Windows.Forms.PictureBox image)
        {
            image.Image = null;
        }

        private void setWarnState(System.Windows.Forms.PictureBox image)
        {
            image.Image = DTWrapper.GUI.Properties.Resources.warning;
        }

        #endregion

        #region formCheck

        private bool checkGame()
        {
            error = "";
            bool valid = true;

            if (!checkName())
            {
                valid = false;
                error += Locale.GetString("Error.InvalidName") + Environment.NewLine;
            }

            if (!checkExe())
            {
                valid = false;
                error += Locale.GetString("Error.InvalidEXE") + Environment.NewLine;
            }

            if (!checkIso())
            {
                valid = false;
                error += Locale.GetString("Error.InvalidISO") + Environment.NewLine;
            }

            if (!checkIcon())
            {
                valid = false;
                error += Locale.GetString("Error.InvalidIcon") + Environment.NewLine;
            }

            return valid;
        }

        private bool checkName()
        {
            this.game.Name = this.nameField.Text;
            if (this.game.nameOK())
            {
                setOKState(nameLabelState);
                return true;
            }

            setWarnState(nameLabelState);
            return false;
        }

        private bool checkExe()
        {
            this.game.Exe = this.exePathField.Text;
            if (this.game.exeOK())
            {
                setOKState(exeLabelState);
                return true;
            }

            setWarnState(exeLabelState);
            return false;
        }

        private bool checkIso()
        {
            this.game.Iso = this.isoPathField.Text;
            if (this.game.isoOK())
            {
                setOKState(isoLabelState);
                return true;
            }

            setWarnState(isoLabelState);
            return false;
        }

        private bool checkIcon()
        {
            this.game.Icon = this.iconPathField.Text;
            if (this.game.iconOK())
            {
                setOKState(iconLabelState);
                return true;
            }

            setWarnState(iconLabelState);
            return false;
        }

        #endregion

        #region Buttons

        private void executablePathButton_Click(object sender, EventArgs e)
        {
            this.exeBrowserWindow.InitialDirectory = (this.exePathField.Text.Length < 1)
                ? Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
                : Path.GetDirectoryName(this.exePathField.Text);
            this.exeBrowserWindow.ShowDialog(this);
        }

        private void isoPathButton_Click(object sender, EventArgs e)
        {
            this.isoBrowserWindow.InitialDirectory = (this.isoPathField.Text.Length < 1)
                ? Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                : Path.GetDirectoryName(this.isoPathField.Text);
            this.isoBrowserWindow.ShowDialog(this);
        }

        private void iconPathButton_Click(object sender, EventArgs e)
        {
            this.iconBrowserWindow.InitialDirectory = (this.iconPathField.Text.Length < 1)
                ? (this.exePathField.Text.Length < 1)
                    ? Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                    : Path.GetDirectoryName(this.exePathField.Text)
                : Path.GetDirectoryName(this.iconPathField.Text);
            this.iconBrowserWindow.ShowDialog(this);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveGame())
            {
                this.Close();
            }
        }

        #endregion

        #region Browsers

        private void isoBrowserWindow_FileOk(object sender, CancelEventArgs e)
        {
            this.isoPathField.Text = this.isoBrowserWindow.FileName;
            checkIso();
        }

        private void exeBrowserWindow_FileOk(object sender, CancelEventArgs e)
        {
            if (this.iconPathField.Text == this.exePathField.Text)
            {
                this.iconPathField.Text = this.exeBrowserWindow.FileName;
                checkIcon();
            }

            this.exePathField.Text = this.exeBrowserWindow.FileName;
            checkExe();

            if (this.nameField.Text.Length < 1)
            {
                this.nameField.Text = this.exeBrowserWindow.SafeFileName.Replace(".exe", "");
                checkName();
            }
        }

        private void iconBrowserWindow_FileOk(object sender, CancelEventArgs e)
        {
            this.iconPathField.Text = this.iconBrowserWindow.FileName;
            checkIcon();
        }

        #endregion

        #region fieldUpdates

        private void nameField_TextChanged(object sender, EventArgs e)
        {
            checkName();
        }

        private void exePathField_TextChanged(object sender, EventArgs e)
        {
            checkExe();
        }

        private void isoPathField_TextChanged(object sender, EventArgs e)
        {
            checkIso();
        }

        private void iconPathField_TextChanged(object sender, EventArgs e)
        {
            checkIcon();
            updateIconPreview();
        }

        #endregion
    }
}
