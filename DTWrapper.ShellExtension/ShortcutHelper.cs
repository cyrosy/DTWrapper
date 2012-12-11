using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using IWshRuntimeLibrary;

using DTWrapper.BDD;

namespace DTWrapper.ShellExtension
{
    public class ShortcutHelper
    {
        public static void createShortcut(Prog prog)
        {
            WshShell shell = new WshShell();
            string shortcutAddress = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + prog.Name + ".lnk";

            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = prog.Name + " via DTWrapper";
            shortcut.TargetPath = System.Reflection.Assembly.GetEntryAssembly().Location;
            shortcut.Arguments = "start " + prog.ID;
            shortcut.IconLocation = prog.Icon;
            shortcut.WorkingDirectory = Environment.CurrentDirectory;
            shortcut.Save();
        }
    }
}
