﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using DTWrapper.Helpers;

namespace DTWrapper.BDD
{
    [Serializable]
    public class Prog
    {
        private int _id;
        private string _name;
        private string _path;
        private string _diskImage;
        private string _icon;
        private bool _inJumpList;

        public int ID { get { return _id; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Path { get { return _path; } set { if(File.Exists(value)) _path = value; } }
        public string DiskImage { get { return _diskImage; } set { if (File.Exists(value) || value.Length == 0) _diskImage = value; } }
        public string Icon { get { return _icon; } set { if (File.Exists(value) || value.Length == 0) _icon = value; } }
        public bool InJumpList { get { return false;/*_inJumpList;*/ } set { _inJumpList = value; } }

        public Prog(int id)
        {
            _id = id;
            _inJumpList = false;
        }

        public Prog(Prog program)
        {
            _id = program.ID;
            _name = program.Name;
            _path = program.Path;
            _diskImage = program.DiskImage;
            _icon = program.Icon;
            _inJumpList = program.InJumpList;
        }

        public bool MountDiskImage(VirtualDrive vd)
        {
            if (_diskImage.Length == 0) return true;
            if (!File.Exists(_diskImage) || !vd.IsValid) return false;
            return vd.Mount(_diskImage);
        }

        public Process Start()
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(_path);
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            return process;
        }

        public bool NameOK()
        {
            return (_name.Length > 0);
        }

        public bool PathOK()
        {
            return (_path.Length > 0 && File.Exists(_path));
        }

        public bool DiskImageOK()
        {
            return (_diskImage.Length > 0 && File.Exists(_path)) || (_diskImage.Length == 0);
        }

        public bool IconOK()
        {
            return (_icon.Length > 0 && File.Exists(_icon)) || (_icon.Length == 0);
        }

        public bool IsOK()
        {
            return (NameOK() && PathOK() && DiskImageOK() && IconOK());
        }
    }
}