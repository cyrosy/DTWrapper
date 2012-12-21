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
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Microsoft.Win32;

namespace DTWrapper.Helpers
{
    /// <summary>
    /// Types of DT drives
    /// </summary>
    [DataContract]
    public enum VirtualDriveType
    {
        NONE,
        DT,
        IDE,
        SCSI
    }

    public enum DTType
    {
        None,
        Lite,
        Pro
    }

    /// <summary>
    /// Interacts with DT
    /// </summary>
    public class DT
    {
        private static string _path = "";
        private static DTType _type = DTType.None;
        private static string _version = "";

        private DT(){}

        public static string Path
        {
            get
            {
                if (_path.Length < 1)
                    ReadRegistry();

                return _path;
            }
        }

        public static DTType Type
        {
            get
            {
                if (_type == DTType.None)
                    ReadRegistry();

                return _type;
            }
        }

        public static string Version
        {
            get
            {
                if (_version.Length < 1)
                    ReadRegistry();

                return _version;
            }
        }

        /// <summary>
        /// Read informations from Windows registry
        /// </summary>
        public static void ReadRegistry()
        {
            RegistryKey regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\DT Soft\\DAEMON Tools Pro");
            if (regKey == null)
                regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\DT Soft\\DAEMON Tools Pro");

            if (regKey == null)
            {
                _path = "";
                _type = DTType.None;
                _version = "";
            }
            else
            {
                _path = (string)regKey.GetValue("Path");
                if (!_path.EndsWith("\\"))
                {
                    _path += "\\";
                }

                if (_path.IndexOf("Lite") > 0)
                {
                    _type = DTType.Lite;
                    _path += "DTLite.exe";
                }
                else
                {
                    _type = DTType.Pro;
                    _path += "DTAgent.exe";
                }

                _version = (string)regKey.GetValue("Version Major") + '.'
                         + (string)regKey.GetValue("Version Minor") + '.'
                         + (string)regKey.GetValue("Version Release");
            }
        }

        /// <summary>
        /// Get the number of virtual drive
        /// </summary>
        /// <param name="type">If specified, count only this type of virtual drives</param>
        /// <returns>The number of virtual drives</returns>
        public static int CountDrv(VirtualDriveType type = VirtualDriveType.NONE)
        {
            string command = "-get_count";

            if (type != VirtualDriveType.NONE)
            {
                command += " " + type.ToString();
            }

            return Exec(command);
        }

        /// <summary>
        /// Get the letter of a virtual drive
        /// </summary>
        /// <param name="type">Type of virtual drive</param>
        /// <param name="num">Number of virtual drive</param>
        /// <returns>Letter of virtual drive</returns>
        public static char GetLetter(VirtualDriveType type, int num)
        {
            if (type != VirtualDriveType.NONE)
            {
                int ret = Exec("-get_letter " + type.ToString() + "," + num);
                if(ret < 0 || ret > 25)
                    return '?';
                return (char)(ret + 65);
            }
            return ' ';
        }

        /// <summary>
        /// Execute a command with Daemon Tools
        /// </summary>
        /// <param name="command">Command to be executed by Daemon Tools</param>
        /// <returns>Exit code of Daemon Tools, -1 on failure</returns>
        public static int Exec(string command)
        {
            if (_type == DTType.None)
            {
                return -1;
            }

            try
            {
                Process dtProcess = new Process();
                dtProcess.StartInfo = new ProcessStartInfo(_path, command);
                dtProcess.StartInfo.RedirectStandardOutput = true;
                dtProcess.StartInfo.RedirectStandardError = true;
                dtProcess.StartInfo.UseShellExecute = false;
                dtProcess.StartInfo.CreateNoWindow = true;
                dtProcess.Start();
                dtProcess.WaitForExit();
                
                return dtProcess.ExitCode;
            }
            catch (Exception e)
            {
                LogHelper.WriteLine(e.Message + Environment.NewLine + e.StackTrace.ToString());
                return -1;
            }
        }
    }
}
