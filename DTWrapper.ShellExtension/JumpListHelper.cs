using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Taskbar;

using DTWrapper.BDD;
using DTWrapper.Helpers;

namespace DTWrapper.ShellExtension
{
    public class JumpListHelper
    {
        private static ResourceManager Locale = new ResourceManager("DTWrapper.ShellExtension.JumpListHelper", typeof(JumpListHelper).Assembly);

        private JumpListHelper() { }

        public static void Update()
        {
            JumpList jumpList = JumpList.CreateJumpList();
            List<Prog> progs =  new ProgList().GetJumpList();
            progs.Reverse();

            foreach (Prog prog in progs)
            {
                JumpListLink task = new JumpListLink(System.Reflection.Assembly.GetEntryAssembly().Location, prog.Name);
                task.Arguments = "start " + prog.ID;
                if(File.Exists(prog.Icon)) task.IconReference = new IconReference(@prog.Icon, 0);
                task.WorkingDirectory = Environment.CurrentDirectory;
                jumpList.AddUserTasks(task);
            }

            jumpList.Refresh();
        }
    }
}
