using System;
using System.Globalization;
using System.IO;
using System.Linq;
using IWshRuntimeLibrary;

using DTWrapper.BDD;

namespace DTWrapper.ShellExtension
{
    public class ShortcutHelper
    {
        public static void CreateShortcut(Prog prog)
        {
            var shell = new WshShell();
            string shortcutName = "<>:\"/\\|?*".ToCharArray().Union(Path.GetInvalidFileNameChars()).Aggregate(prog.Name, (current, c) => current.Replace(c.ToString(CultureInfo.InvariantCulture), ""));

            string shortcutAddress = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), shortcutName + ".lnk");

            var shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = prog.Name + " via DTWrapper";
            shortcut.TargetPath = System.Reflection.Assembly.GetEntryAssembly().Location;
            shortcut.Arguments = "start " + prog.ID;
            shortcut.IconLocation = prog.Icon;
            shortcut.WorkingDirectory = Environment.CurrentDirectory;
            shortcut.Save();
        }
    }
}
