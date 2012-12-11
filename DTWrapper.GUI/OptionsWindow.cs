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

using DTWrapper.BDD;
using DTWrapper.Helpers;

namespace DTWrapper.GUI
{
    public partial class OptionsWindow : Form
    {
        private ResourceManager Locale = new ResourceManager("DTWrapper.GUI.OptionsWindow", typeof(OptionsWindow).Assembly);
        private Options _options;

        public OptionsWindow(Options options)
        {
            InitializeComponent();
            _options = options;
            if (!loadDrives())
            {
                LogHelper.RaiseError(this, Locale.GetString("NoDTDrive"));
            }
        }

        #region actions

        private bool saveOptions()
        {
            if (driveField.SelectedIndex < 0 || driveField.SelectedIndex >= driveField.Items.Count)
            {
                return false;
            }

            VirtualDrive drive = (VirtualDrive)driveField.SelectedItem;
            if (drive.Num >= DT.CountDrv(drive.Type))
            {
                return false;
            }

            _options.VirtualDrive = drive;
            LogHelper.WriteLine(String.Format(Locale.GetString("DriveSelected"), drive.ToString()), LogHelper.MessageType.INFO);
            return true;
        }

        private bool loadDrives()
        {
            InfoWindow info = new InfoWindow(Locale.GetString("DriveSearching"));
            info.Show(this);
            driveField.Items.Clear();
            List<VirtualDrive> drives = new List<VirtualDrive>();

            for (int i = 0; i < DT.CountDrv(VirtualDriveType.DT); i++)
            {
                drives.Add(new VirtualDrive(VirtualDriveType.DT, i));
            }

            for (int i = 0; i < DT.CountDrv(VirtualDriveType.SCSI); i++)
            {
                drives.Add(new VirtualDrive(VirtualDriveType.SCSI, i));
            }

            if (DT.Type == DTType.Pro)
            {
                for (int i = 0; i < DT.CountDrv(VirtualDriveType.IDE); i++)
                {
                    drives.Add(new VirtualDrive(VirtualDriveType.IDE, i));
                }
            }

            drives.Sort((x,y) => string.Compare(x.Letter.ToString(), y.Letter.ToString()));

            if (drives.Count < 1)
            {
                return false;
            }

            foreach (VirtualDrive drive in drives)
            {
                driveField.Items.Add(drive);
                
                if (drive.Type == _options.VirtualDrive.Type
                && drive.Num == _options.VirtualDrive.Num)
                {
                    driveField.SelectedIndex = driveField.Items.Count - 1;
                }
            }
            info.Close();

            return true;
        }

        #endregion

        #region buttons

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveOptions())
            {
                this.Close();
            }
        }

        #endregion
    }
}
