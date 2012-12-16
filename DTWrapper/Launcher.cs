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
using System.Resources;
using System.Text;
using System.Windows.Forms;

using DTWrapper.CLI;
using DTWrapper.GUI;
using DTWrapper.Helpers;

namespace DTWrapper
{
    class Launcher
    {
        private static ResourceManager Locale = new ResourceManager("DTWrapper.Launcher", typeof(Launcher).Assembly);
        /// <summary>
        /// Application's entry point
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show(Locale.GetString("AlreadyRunning"), Locale.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                if (args.Length < 1)
                {
                    RunGUI();
                }
                else
                {
                    Environment.Exit(Program.Main(args));
                }
            }
        }

        private static void RunGUI()
        {
            try
            {
                Application.Run(new MainWindow());
            }
            catch (Exception e)
            {
                LogHelper.RaiseError(null, e.Message + Environment.NewLine + e.StackTrace.ToString());
            }
        }
    }
}
