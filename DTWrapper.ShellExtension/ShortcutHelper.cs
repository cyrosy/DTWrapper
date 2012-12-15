using System;
using System.Collections.Generic;
using System.IO;
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
            string shortcutName = prog.Name;
            foreach (char c in "<>:\"/\\|?*".ToCharArray().Union(Path.GetInvalidFileNameChars()))
            {
                shortcutName = shortcutName.Replace(c.ToString(), "");
            }

            string shortcutAddress = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), shortcutName + ".lnk");

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
