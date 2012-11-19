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
using Microsoft.Win32;

namespace DTWrapper.Helpers
{
    /// <summary>
    /// Reads informations from Windows registry
    /// </summary>
    public class RegistryHelper
    {
        private static bool doInit = true;
        private static RegistryKey DTProKey = null;
        private static string type = "";
        private static string path = "";
        private static string version = "";

        private static ResourceManager Locale = new ResourceManager("DTWrapper.Helpers.DTHelper", typeof(DTHelper).Assembly);

        /// <summary>
        /// Scan the registry for DT key
        /// </summary>
        /// <returns>true if DT key is found</returns>
        private static bool Init()
        {
            doInit = false;
            DTProKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\DT Soft\\DAEMON Tools Pro");
            if (!KeyFound())
            {
                DTProKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\DT Soft\\DAEMON Tools Pro");
                if (KeyFound())
                {
                    LogHelper.WriteLine(Locale.GetString("x64OS"), LogHelper.MessageType.INFO);
                }
                else
                {
                    LogHelper.WriteLine(Locale.GetString("DTKeyNotFound"), LogHelper.MessageType.CRITICAL);
                    return false;
                }
            }

            path = (string)DTProKey.GetValue("Path");

            if (!path.EndsWith("\\"))
            {
                path += "\\";
            }

            if (path.IndexOf("Lite") > 0)
            {
                path += "DTLite.exe";
                type = "Lite";
            }
            else
            {
                path += "DTAgent.exe";
                type = "Pro";
            }

            version = (string)DTProKey.GetValue("Version Major") + '.'
                    + (string)DTProKey.GetValue("Version Minor") + '.'
                    + (string)DTProKey.GetValue("Version Release");
            return true;
        }

        /// <summary>
        /// Checks if the DT key has been found
        /// </summary>
        /// <returns>true if the key has been found</returns>
        public static bool KeyFound()
        {
            if (doInit)
            {
                return Init();
            }

            return DTProKey != null;
        }

        /// <summary>
        /// Get the path to DT
        /// </summary>
        /// <returns>The path to DT</returns>
        public static string DTPath()
        {
            if(KeyFound() || (doInit && Init()))
            {
                return path;
            }
            return "";
        }

        /// <summary>
        /// Get the type of DT
        /// </summary>
        /// <returns>Lite or Pro</returns>
        public static string Type()
        {
            if (KeyFound() || (doInit && Init()))
            {
                return type;
            }
            return "";
        }

        /// <summary>
        /// Get the version of DT
        /// </summary>
        /// <returns>DT's version</returns>
        public static string Version()
        {
            if (KeyFound() || (doInit && Init()))
            {
                return version;
            }
            return "0";
        }
    }
}
