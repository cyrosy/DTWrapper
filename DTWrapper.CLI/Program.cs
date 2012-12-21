using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTWrapper.BDD;
using DTWrapper.Helpers;
using DTWrapper.GUI;

namespace DTWrapper.CLI
{
    public class Program
    {
        public static int Main(string[] args)
        {
            if (args.Length < 2)
                return Help();
            switch (args[0])
            {
                case "start":
                    if (args.Length == 2) return Start(args[1]);
                    return UnknownCommand();
                case "help":
                    return Help();
                default:
                    return UnknownCommand();
            }
        }

        private static int UnknownCommand()
        {
            Help();
            return -1;
        }

        private static int Help()
        {
            string progName = Environment.GetCommandLineArgs().ElementAt(0);
            string msg = Localization.Strings.Usage + ":"
                       + "\n\t" + progName + " help"
                       + "\n\t" + progName + " start <programName>|<programID>";
            ShowMessage(msg, Localization.Strings.Usage);
            return 0;
        }

        private static int Start(string progName)
        {
            System.Windows.Forms.NotifyIcon trayIcon = new NotifyIcon();
            trayIcon.Icon = GUI.Properties.Resources.icon;
            ProgList progs = new ProgList();
            Prog prog;

            try
            {
                int progId = Int32.Parse(progName);
                prog = progs.Get(progId);
            }
            catch (FormatException e)
            {
                prog = progs.Get(progName);
            }

            if (prog == null || !prog.IsOK() || (prog.DiskImage.Length > 0 && !prog.DiskImageOK()))
            {
                ShowError(String.Format(Localization.Strings.ProgNotFound, progName));
                return -1;
            }

            InfoWindow info = new InfoWindow(String.Format(Localization.Strings.ProgPreparing, prog.Name));
            info.Show();

            trayIcon.Text = String.Format(Localization.Strings.ProgWaitingEnd, prog.Name);

            Options opts = null;
            VirtualDrive virtualDrive = null;
            if(prog.DiskImage.Length > 0)
            {
                if (!new MainWindow().findDT())
                {
                    return -1;
                }

                opts = new Options();
                if (!opts.Reload())
                {
                    ShowError(Localization.Strings.OptionsError);
                    return -1;
                }
                virtualDrive = opts.VirtualDrive;

                if (!virtualDrive.IsValid)
                {
                    info.Close();
                    ShowError(Localization.Strings.InvalidDrive + " : " + virtualDrive.ToString());
                    return -1;
                }
                else
                {
                    info.Close();
                    info = new InfoWindow(String.Format(Localization.Strings.DiskImageMounting, prog.DiskImage, prog.Name));
                    info.Show();
                    if (!prog.MountDiskImage(virtualDrive))
                    {
                        ShowError(Localization.Strings.ErrorMounting);
                        return -1;
                    }
                }
            }

            info.Close();
            info = new InfoWindow(String.Format(Localization.Strings.ProgStarting, prog.Name));
            info.Show();

            Process proc = prog.Start();
            trayIcon.Visible = true;
            info.Close();
            proc.WaitForExit();
            trayIcon.Visible = false;

            if (virtualDrive != null && virtualDrive.IsValid)
            {
                info = new InfoWindow(Localization.Strings.DiskImageUnmounting);
                info.Show();
                virtualDrive.Umount();
                info.Close();
            }
            return 0;
        }

        private static void ShowMessage(string msg, string caption)
        {
            MessageBox.Show(null, msg, Localization.Strings.ProgramName + " - " + caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void ShowError(string msg)
        {
            MessageBox.Show(null, msg, Localization.Strings.ProgramName + " - " + Localization.Strings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
