using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Resources;
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
        private static ResourceManager Locale = new ResourceManager("DTWrapper.CLI.Program", typeof(Program).Assembly);

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
            string msg = Locale.GetString("Usage") + ":"
                       + "\n\t" + progName + " help"
                       + "\n\t" + progName + " start <programName>|<programID>";
            ShowMessage(msg, Locale.GetString("Usage"));
            return 0;
        }

        private static int Start(string progName)
        {
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
                ShowError(String.Format(Locale.GetString("InvalidProgram"), progName));
                return -1;
            }

            InfoWindow info = new InfoWindow(String.Format(Locale.GetString("ProgPreparing"), prog.Name));
            info.Show();

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
                    ShowError(Locale.GetString("OptionsError"));
                    return -1;
                }
                virtualDrive = opts.VirtualDrive;

                if (!virtualDrive.IsValid)
                {
                    info.Close();
                    ShowError(Locale.GetString("InvalidDrive") + " : " + virtualDrive.ToString());
                    return -1;
                }
                else
                {
                    info.Close();
                    info = new InfoWindow(String.Format(Locale.GetString("DiskImageMounting"), prog.DiskImage, prog.Name));
                    info.Show();
                    if (!prog.MountDiskImage(virtualDrive))
                    {
                        ShowError(Locale.GetString("ErrorMounting"));
                        return -1;
                    }
                }
            }

            info.Close();
            info = new InfoWindow(String.Format(Locale.GetString("ProgStarting"), prog.Name));
            info.Show();

            Process proc = prog.Start();
            info.Close();
            proc.WaitForExit();

            if (virtualDrive != null && virtualDrive.IsValid)
            {
                info = new InfoWindow(Locale.GetString("DiskImageUnmounting"));
                info.Show();
                virtualDrive.Umount();
                info.Close();
            }
            return 0;
        }

        private static void ShowMessage(string msg, string caption)
        {
            MessageBox.Show(null, msg, Locale.GetString("DTWrapper") + " - " + caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void ShowError(string msg)
        {
            MessageBox.Show(null, msg, Locale.GetString("DTWrapper") + " - " + Locale.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
