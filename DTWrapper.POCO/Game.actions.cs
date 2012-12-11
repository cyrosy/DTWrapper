/*
 * Copyright 2012 Cyril SAINT-YVES
 * 
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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using DTWrapper.Helpers;

namespace DTWrapper.POCO
{
    /// <summary>
    /// Add actions to auto-generated Game class
    /// </summary>
    public partial class Game
    {
        private ResourceManager Locale = new ResourceManager("DTWrapper.POCO.Game", typeof(Game).Assembly);

        /// <summary>
        /// Run the game
        /// </summary>
        /// <param name="virtualDrive">Where the disk image will be mounted</param>
        /// <returns>true on success</returns>
        public bool play(VirtualDrive virtualDrive)
        {
            if (!virtualDrive.IsValid)
            {
                LogHelper.WriteLine(Locale.GetString("InvalidDrive"));
                return false;
            }

            if (!exeOK())
            {
                LogHelper.WriteLine(Locale.GetString("ExeNotFound"));
                return false;
            }

            if (!isoOK())
            {
                LogHelper.WriteLine(Locale.GetString("IsoNotFound"));
                return false;
            }

            if (!DT.Mount(Iso, virtualDrive))
            {
                LogHelper.WriteLine(Locale.GetString("IsoNotMounted"));
                return false;
            }

            LogHelper.WriteLine(String.Format(Locale.GetString("Starting"), Name), LogHelper.MessageType.INFO);

            try
            {
                ProcessStartInfo launchStartInfo = new ProcessStartInfo(Exe);
                launchStartInfo.UseShellExecute = false;
                
                Process launchProcess = new Process();
                launchProcess.StartInfo = launchStartInfo;
                launchProcess.Start();

                LogHelper.WriteLine(String.Format(Locale.GetString("Started"), Name), LogHelper.MessageType.INFO);
                LogHelper.WriteLine(String.Format(Locale.GetString("Waiting"), Name), LogHelper.MessageType.INFO);

                launchProcess.WaitForExit();
            }
            catch (Exception e)
            {
                LogHelper.WriteLine(e.Message + Environment.NewLine + e.StackTrace);
                return false;
            }

            DT.Umount(virtualDrive);
            return true;
        }

        /// <summary>
        /// Check the name validity
        /// </summary>
        /// <returns>true is name is valid</returns>
        public bool nameOK()
        {
            return (this.Name.Length > 0);
        }

        /// <summary>
        /// Check the exe path validity
        /// </summary>
        /// <returns>true if path is valid</returns>
        public bool exeOK()
        {
            return (this.Exe.Length > 0) && File.Exists(this.Exe);
        }

        /// <summary>
        /// Check the disk image path validity
        /// </summary>
        /// <returns>true if path is valid</returns>
        public bool isoOK()
        {
            return (this.Iso.Length > 0) && File.Exists(this.Iso);
        }

        /// <summary>
        /// Check the icon path validity
        /// </summary>
        /// <returns>true if path is valid</returns>
        public bool iconOK()
        {
            return (this.Icon.Length > 0) && File.Exists(this.Icon);
        }
    }
}
