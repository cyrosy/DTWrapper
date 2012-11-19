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
using System.Linq;
using System.Resources;
using System.Text;

namespace DTWrapper.Helpers
{
    /// <summary>
    /// Types of DT drives
    /// </summary>
    public enum DriveType
    {
        NONE,
        DT,
        IDE,
        SCSI
    }

    /// <summary>
    /// Interacts with DT
    /// </summary>
    public class DTHelper
    {
        private static string DT = null;

        private static ResourceManager Locale = new ResourceManager("DTWrapper.Helpers.DTHelper", typeof(DTHelper).Assembly);

        /// <summary>
        /// Get DT path from registry
        /// </summary>
        private static void ReadRegistry()
        {
            DT = RegistryHelper.DTPath();
        }

        /// <summary>
        /// Add a virtual drive
        /// </summary>
        /// <param name="type">The new virtual drive type</param>
        /// <returns>true on success</returns>
        public static bool AddDrv(DriveType type)
        {
            LogHelper.WriteLine(String.Format(Locale.GetString("AddingDrive"), type.ToString()), LogHelper.MessageType.INFO);

            int ret = DTExec("-get_count " + type.ToString());
            DTExec("-add " + type.ToString());

            if (ret + 1 == DTExec("-get_count " + type.ToString()))
            {
                LogHelper.WriteLine(Locale.GetString("Done"), LogHelper.MessageType.INFO);
                return true;
            }

            LogHelper.WriteLine(Locale.GetString("Error"));
            return false;
        }

        /// <summary>
        /// Get the number of virtual drive
        /// </summary>
        /// <param name="type">If specified, count only this type of virtual drives</param>
        /// <returns>The number of virtual drives</returns>
        public static int CountDrv(DriveType type = DriveType.NONE)
        {
            int ret = 0;
            string command = "-get_count";
            string typeName = "";

            if (type != DriveType.NONE)
            {
                command += " " + type.ToString();
                typeName = type.ToString();
            }

            LogHelper.WriteLine(String.Format(Locale.GetString("SearchDrive"), typeName), LogHelper.MessageType.INFO);
            ret = DTExec(command);
            LogHelper.WriteLine(String.Format(Locale.GetString("FoundDrive"), ret, typeName), LogHelper.MessageType.INFO);
            return ret;
        }

        /// <summary>
        /// Get the letter of a virtual drive
        /// </summary>
        /// <param name="type">Type of virtual drive</param>
        /// <param name="num">Number of virtual drive</param>
        /// <returns>Letter of virtual drive</returns>
        public static char GetLetter(DriveType type, int num)
        {
            return (char)(DTExec("-get_letter " + type.ToString() + "," + num) + 65);
        }

        /// <summary>
        /// Mount a disk image to a virtual drive
        /// </summary>
        /// <param name="Iso">Path to the disk image</param>
        /// <param name="virtualDrive">The destination virtual drive</param>
        /// <returns>true on success</returns>
        public static bool Mount(string Iso, VirtualDrive virtualDrive)
        {
            LogHelper.WriteLine(String.Format(Locale.GetString("Mounting"), Iso), LogHelper.MessageType.INFO);

            if (DTExec("-mount " + virtualDrive.Type.ToString() + "," + virtualDrive.Num + ",\"" + Iso + "\"") == 0)
            {
                LogHelper.WriteLine(Locale.GetString("Mounted"), LogHelper.MessageType.INFO);
                return true;
            }
            else
            {
                LogHelper.WriteLine(Locale.GetString("MountError"), LogHelper.MessageType.INFO);
                return false;
            }
        }

        /// <summary>
        /// Remove a disk image from a virtual drive
        /// </summary>
        /// <param name="virtualDrive">The virtual drive to empty</param>
        public static void Umount(VirtualDrive virtualDrive)
        {
            LogHelper.WriteLine(Locale.GetString("Unmounting"), LogHelper.MessageType.INFO);
            DTExec("-unmount " + virtualDrive.Type.ToString() + ", " + virtualDrive.Num);
            LogHelper.WriteLine(Locale.GetString("Unmounted"), LogHelper.MessageType.INFO);
        }

        /// <summary>
        /// Execute a command with DT
        /// </summary>
        /// <param name="Args">Arguments to pass to DT</param>
        /// <returns>The exit status code</returns>
        private static int DTExec(string Args)
        {
            if (DT == null)
            {
                ReadRegistry();
            }

            try
            {
                System.Diagnostics.ProcessStartInfo dtStartInfo = new System.Diagnostics.ProcessStartInfo(DT, Args);
                dtStartInfo.RedirectStandardOutput = true;
                dtStartInfo.RedirectStandardError = true;
                dtStartInfo.UseShellExecute = false;
                dtStartInfo.CreateNoWindow = true;

                System.Diagnostics.Process dtProcess = new System.Diagnostics.Process();
                dtProcess.StartInfo = dtStartInfo;
                dtProcess.Start();
                dtProcess.WaitForExit();

                return dtProcess.ExitCode;
            }
            catch (Exception e)
            {
                LogHelper.WriteLine(e.Message + Environment.NewLine + e.StackTrace);
                return -1;
            }
        }
    }
}
