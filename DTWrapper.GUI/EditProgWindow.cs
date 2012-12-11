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
using DTWrapper.BDD;

namespace DTWrapper.GUI
{
    public partial class EditProgWindow : Form
    {
        private ResourceManager Locale = new ResourceManager("DTWrapper.GUI.EditProgWindow", typeof(EditProgWindow).Assembly);
        private Prog _prog;
        private ProgList _progList;
        private string _error;
        private bool _isNew;

        #region Constructor

        public EditProgWindow(ProgList progList, int id = -1)
        {
            InitializeComponent();
            this.AcceptButton = this.saveButton;
            this.CancelButton = this.cancelButton;
            _progList = progList;

            if (id < 0)
            {
                this.Text = Locale.GetString("Title.AddGame");
                _prog = _progList.CreateProg();
                _isNew = true;
            }
            else
            {
                this.Text = Locale.GetString("Title.EditGame");
                _prog = progList.Get(id);
                _isNew = false;
                this.nameField.Text = _prog.Name;
                this.pathField.Text = _prog.Path;
                this.diskImageField.Text = _prog.DiskImage;
                this.iconField.Text = _prog.Icon;
                this.jumpListBox.CheckState = _prog.InJumpList ? CheckState.Checked : CheckState.Unchecked;

                updateIconPreview();
            }
        }

        #endregion

        #region Actions
        
        private bool saveGame()
        {
            if (!checkGame())
            {
                LogHelper.RaiseError(this, _error);
                return false;
            }

            if (!_isNew)
            {
                if (_progList.Update(_prog))
                {
                    return true;
                }
                else
                {
                    LogHelper.RaiseError(this, String.Format(Locale.GetString("Error.Updating"), _prog.Name));
                    return false;
                }
            }
            else
            {
                if (_progList.Add(_prog))
                {
                    return true;
                }
                else
                {
                    LogHelper.RaiseError(this, String.Format(Locale.GetString("Error.Adding"), _prog.Name));
                    return false;
                }
            }
        }

        private void updateIconPreview()
        {
            if (this.iconField.Text.Length > 0)
            {
                try
                {
                    this.iconPreview.Image = Icon.ExtractAssociatedIcon(this.iconField.Text).ToBitmap();
                    setOKState(iconLabelState);
                }
                catch (Exception e)
                {
                    LogHelper.WriteLine(e.ToString(), LogHelper.MessageType.ERROR);
                    setWarnState(iconLabelState);
                }
            }
        }

        private void setOKState(PictureBox image)
        {
            image.Image = null;
        }

        private void setWarnState(PictureBox image)
        {
            image.Image = DTWrapper.GUI.Properties.Resources.warning;
        }

        #endregion

        #region formCheck

        private bool checkGame()
        {
            _error = "";
            bool valid = true;

            if (!checkName())
            {
                valid = false;
                _error += Locale.GetString("Error.InvalidName") + Environment.NewLine;
            }

            if (!checkExe())
            {
                valid = false;
                _error += Locale.GetString("Error.InvalidEXE") + Environment.NewLine;
            }

            if (!checkIso())
            {
                valid = false;
                _error += Locale.GetString("Error.InvalidISO") + Environment.NewLine;
            }

            if (!checkIcon())
            {
                valid = false;
                _error += Locale.GetString("Error.InvalidIcon") + Environment.NewLine;
            }

            this._prog.InJumpList = (this.jumpListBox.CheckState == CheckState.Checked);

            return valid;
        }

        private bool checkName()
        {
            this._prog.Name = this.nameField.Text;
            if (this._prog.NameOK())
            {
                setOKState(nameLabelState);
                return true;
            }

            setWarnState(nameLabelState);
            return false;
        }

        private bool checkExe()
        {
            this._prog.Path = this.pathField.Text;
            if (this._prog.PathOK())
            {
                setOKState(pathLabelState);
                return true;
            }

            setWarnState(pathLabelState);
            return false;
        }

        private bool checkIso()
        {
            this._prog.DiskImage = this.diskImageField.Text;
            if (this._prog.DiskImageOK())
            {
                setOKState(diskImageLabelState);
                return true;
            }

            setWarnState(diskImageLabelState);
            return false;
        }

        private bool checkIcon()
        {
            this._prog.Icon = this.iconField.Text;
            if (this._prog.IconOK())
            {
                setOKState(iconLabelState);
                return true;
            }

            setWarnState(iconLabelState);
            return false;
        }

        #endregion

        #region Buttons

        private void pathButton_Click(object sender, EventArgs e)
        {
            this.pathBrowser.InitialDirectory = (this.pathField.Text.Length < 1)
                ? Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
                : Path.GetDirectoryName(this.pathField.Text);
            this.pathBrowser.ShowDialog(this);
        }

        private void diskImageButton_Click(object sender, EventArgs e)
        {
            this.diskImageBrowser.InitialDirectory = (this.diskImageField.Text.Length < 1)
                ? Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                : Path.GetDirectoryName(this.diskImageField.Text);
            this.diskImageBrowser.ShowDialog(this);
        }

        private void iconButton_Click(object sender, EventArgs e)
        {
            this.iconBrowser.InitialDirectory = (this.iconField.Text.Length < 1)
                ? (this.pathField.Text.Length < 1)
                    ? Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                    : Path.GetDirectoryName(this.pathField.Text)
                : Path.GetDirectoryName(this.iconField.Text);
            this.iconBrowser.ShowDialog(this);
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

        private void diskImageBrowser_FileOk(object sender, CancelEventArgs e)
        {
            this.diskImageField.Text = this.diskImageBrowser.FileName;
            checkIso();
        }

        private void pathBrowser_FileOk(object sender, CancelEventArgs e)
        {
            if (this.iconField.Text == this.pathField.Text)
            {
                this.iconField.Text = this.pathBrowser.FileName;
                checkIcon();
            }

            this.pathField.Text = this.pathBrowser.FileName;
            checkExe();

            if (this.nameField.Text.Length < 1)
            {
                this.nameField.Text = this.pathBrowser.SafeFileName.Replace(".exe", "");
                checkName();
            }
        }

        private void iconBrowser_FileOk(object sender, CancelEventArgs e)
        {
            this.iconField.Text = this.iconBrowser.FileName;
            checkIcon();
        }

        #endregion

        #region fieldUpdates

        private void nameField_TextChanged(object sender, EventArgs e)
        {
            checkName();
        }

        private void pathField_TextChanged(object sender, EventArgs e)
        {
            checkExe();
        }

        private void diskImageField_TextChanged(object sender, EventArgs e)
        {
            checkIso();
        }

        private void iconField_TextChanged(object sender, EventArgs e)
        {
            checkIcon();
            updateIconPreview();
        }

        #endregion
    }
}
