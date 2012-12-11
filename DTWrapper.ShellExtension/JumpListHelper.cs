using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using System.Windows.Shell;

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
            JumpList jumpList = new JumpList();
            jumpList.BeginInit();
            jumpList.JumpItemsRejected += jumpList_JumpItemsRejected;
            jumpList.JumpItemsRemovedByUser += jumpList_JumpItemsRemovedByUser;
            jumpList.ShowFrequentCategory = false;
            jumpList.ShowRecentCategory = false;

            foreach (Prog prog in new ProgList().GetJumpList())
            {
                JumpTask task = new JumpTask();
                task.ApplicationPath = System.Reflection.Assembly.GetEntryAssembly().Location;
                task.Arguments = "start " + prog.ID;
                task.CustomCategory = Locale.GetString("Programs");
                task.Description = String.Format(Locale.GetString("ProgramDesc"), prog.Name);
                task.IconResourcePath = prog.Icon;
                task.IconResourceIndex = 0;
                task.Title = prog.Name;
                task.WorkingDirectory = Environment.CurrentDirectory;
                jumpList.JumpItems.Add(task);
            }
            jumpList.EndInit();
            jumpList.Apply();
        }

        private static void jumpList_JumpItemsRemovedByUser(object sender, JumpItemsRemovedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void jumpList_JumpItemsRejected(object sender, JumpItemsRejectedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Jump Items Rejected:\n", e.RejectionReasons.Count);
            for (int i = 0; i < e.RejectionReasons.Count; ++i)
            {
                if (e.RejectedItems[i].GetType() == typeof(JumpPath))
                    sb.AppendFormat("Reason: {0}\tItem: {1}\n", e.RejectionReasons[i], ((JumpPath)e.RejectedItems[i]).Path);
                else
                    sb.AppendFormat("Reason: {0}\tItem: {1}\n", e.RejectionReasons[i], ((JumpTask)e.RejectedItems[i]).ApplicationPath);
            }

            LogHelper.RaiseError(null, sb.ToString());
        }
    }
}
