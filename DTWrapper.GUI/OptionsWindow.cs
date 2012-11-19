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

namespace DTWrapper.GUI
{
    public partial class OptionsWindow : Form
    {
        private ResourceManager Locale = new ResourceManager("DTWrapper.GUI.OptionsWindow", typeof(OptionsWindow).Assembly);

        public OptionsWindow()
        {
            InitializeComponent();
            if (!loadDrives())
            {
                addDrive();
                loadDrives();
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
            if (drive.Num >= DTHelper.CountDrv(drive.Type))
            {
                return false;
            }

            Properties.Settings.Default.DriveType = drive.Type;
            Properties.Settings.Default.DriveNum = drive.Num;
            Properties.Settings.Default.Save();
            LogHelper.WriteLine(String.Format(Locale.GetString("DriveSelected"), drive.Type.ToString(), drive.Num, drive.Letter), LogHelper.MessageType.INFO);
            return true;
        }

        private bool loadDrives()
        {
            driveField.Items.Clear();
            List<VirtualDrive> drives = new List<VirtualDrive>();

            for (int i = 0; i < DTHelper.CountDrv(DriveType.DT); i++)
            {
                drives.Add(new VirtualDrive(DriveType.DT, i));
            }

            for (int i = 0; i < DTHelper.CountDrv(DriveType.SCSI); i++)
            {
                drives.Add(new VirtualDrive(DriveType.SCSI, i));
            }

            if (RegistryHelper.Type() == "Pro")
            {
                for (int i = 0; i < DTHelper.CountDrv(DriveType.IDE); i++)
                {
                    drives.Add(new VirtualDrive(DriveType.IDE, i));
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
                
                if (drive.Type == Properties.Settings.Default.DriveType
                && drive.Num == Properties.Settings.Default.DriveNum)
                {
                    driveField.SelectedIndex = driveField.Items.Count - 1;
                }
            }

            return true;
        }

        private void addDrive()
        {
            MessageBox.Show(Locale.GetString("AddDrive.Text"), Locale.GetString("AddDrive.Title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (RegistryHelper.Type() == "Pro" && DTHelper.AddDrv(DriveType.IDE))
            {
                LogHelper.RaiseSuccess(this, String.Format(Locale.GetString("AddDrive.Added"), DriveType.IDE.ToString()));
            }
            else
            {
                if (DTHelper.AddDrv(DriveType.SCSI))
                {
                    LogHelper.RaiseSuccess(this, String.Format(Locale.GetString("AddDrive.Added"), DriveType.SCSI.ToString()));
                }
                else
                {
                    if (DTHelper.AddDrv(DriveType.DT))
                    {
                        LogHelper.RaiseSuccess(this, String.Format(Locale.GetString("AddDrive.Added"), DriveType.DT.ToString()));
                    }
                    else
                    {
                        LogHelper.RaiseError(this, Locale.GetString("AddDrive.NotAdded"));
                    }
                }
            }
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
