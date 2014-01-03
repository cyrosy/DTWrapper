using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Taskbar;

using DTWrapper.BDD;

namespace DTWrapper.ShellExtension
{
    public class JumpListHelper
    {
        private JumpListHelper() { }

        public static bool IsSupported()
        {
            return TaskbarManager.IsPlatformSupported;
        }

        public static void Update()
        {
            if (IsSupported())
            {
                JumpList jumpList = JumpList.CreateJumpList();
                List<Prog> progs = new ProgList().GetJumpList();
                progs.Reverse();

                foreach (Prog prog in progs)
                {
                    var task = new JumpListLink(System.Reflection.Assembly.GetEntryAssembly().Location, prog.Name)
                    {
                        Arguments = "start " + prog.ID
                    };
                    if (File.Exists(prog.Icon)) task.IconReference = new IconReference(@prog.Icon, 0);
                    task.WorkingDirectory = Environment.CurrentDirectory;
                    jumpList.AddUserTasks(task);
                }

                jumpList.Refresh();
            }
        }
    }
}
