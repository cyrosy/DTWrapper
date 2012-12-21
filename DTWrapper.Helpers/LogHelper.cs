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
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace DTWrapper.Helpers
{
    /// <summary>
    /// Manages the log file
    /// </summary>
    public class LogHelper
    {
        private static readonly int logsToKeep = 10;
        private static readonly string Folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DTWrapper", "Logs");
        private static string Filename = "";

        private LogHelper() {}

        /// <summary>
        /// Rotate the old log files, and create a new one
        /// </summary>
        private static void init()
        {
            try
            {
                DirectoryInfo dirInfos = new DirectoryInfo(Folder);
                if (!dirInfos.Exists)
                {
                    dirInfos.Create();
                }

                IEnumerable<FileInfo> files = from f
                                              in dirInfos.GetFiles()
                                              where f.Extension != ".log"
                                              orderby f.Name
                                              select f;

                foreach (FileInfo file in files)
                {
                    if (file.Exists)
                    {
                        file.Delete();
                    }
                }

                files = from f
                        in dirInfos.GetFiles()
                        where f.Extension == ".log"
                        orderby f.Name
                        select f;

                for (int i = files.Count() - 1; i >= 0; i--)
                {
                    if (files.ElementAt(i).Exists)
                    {
                        if (i < logsToKeep - 1)
                        {
                            files.ElementAt(i).MoveTo(files.ElementAt(i).DirectoryName + "/" + (i + 1) + ".log");
                        }
                        else
                        {
                            files.ElementAt(i).Delete();
                        }
                    }
                }
            }
            catch (Exception e) { MessageBox.Show(null, e.StackTrace.ToString(), e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }

            Filename = "0.log";
        }

        /// <summary>
        /// Write a line to log file, with default level of ERROR
        /// </summary>
        /// <param name="msg">The message to write</param>
        public static void WriteLine(string msg)
        {
            WriteLine(msg, MessageType.ERROR);
        }

        /// <summary>
        /// Write a line to log file, with specified level
        /// </summary>
        /// <param name="msg">The message to write</param>
        /// <param name="type">The level of the message</param>
        public static void WriteLine(string msg, MessageType type)
        {
            if (Filename.Length == 0)
            {
                init();
            }

            StreamWriter LogStream = new StreamWriter(Folder + "/" + Filename, true);

            DateTime now = DateTime.Now;
            String preamble = "[" + now.ToString() + "][" + type.ToString() + "] ";
            LogStream.WriteLine(preamble + msg.Replace(Environment.NewLine, Environment.NewLine.PadRight(preamble.Length)));

            LogStream.Flush();
            LogStream.Close();
        }

        /// <summary>
        /// Write an error message to the log file and display it on a modal window
        /// </summary>
        /// <param name="owner">The parent window</param>
        /// <param name="msg">The error message</param>
        public static void RaiseError(IWin32Window owner, string msg)
        {
            WriteLine(msg, MessageType.ERROR);
            MessageBox.Show(owner, msg, Localization.Strings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        /// <summary>
        /// Write an info message to the log file and display it on a modal window
        /// </summary>
        /// <param name="owner">The parent window</param>
        /// <param name="msg">The info message</param>
        public static void RaiseSuccess(IWin32Window owner, string msg)
        {
            WriteLine(msg, MessageType.INFO);
            MessageBox.Show(owner, msg, Localization.Strings.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Possible levels for logs
        /// </summary>
        public enum MessageType
        {
            DEBUG,
            INFO,
            WARNING,
            ERROR,
            CRITICAL
        }
    }
}
