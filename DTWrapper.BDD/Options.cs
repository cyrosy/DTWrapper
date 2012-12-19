using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

using DTWrapper.Helpers;

namespace DTWrapper.BDD
{
    [Serializable]
    public class Options
    {
        private static readonly string _directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DTWrapper");
        private static readonly string _filename = "DTWrapper.conf";

        private VirtualDriveType _virtualDriveType = VirtualDriveType.NONE;
        private int _virtualDriveNum = -1;
        private View _listView = View.Details;

        public VirtualDrive VirtualDrive
        {
            get { return new VirtualDrive(_virtualDriveType, _virtualDriveNum); }
            set {
                _virtualDriveType = value.Type;
                _virtualDriveNum = value.Num;
                Save(this);
            }
        }

        public View ListView
        {
            get { return _listView; }
            set
            {
                _listView = value;
                Save(this);
            }
        }

        public Options()
        {
            Reload();
        }

        public static bool Save(Options options)
        {
            string filepath = Path.Combine(_directory, _filename);
            try {
                if (File.Exists(filepath))
                {
                    if (File.Exists(filepath + ".bak")) File.Delete(filepath + ".bak");
                    File.Move(filepath, filepath + ".bak");
                }

                FileStream file = File.Open(filepath, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, options);
                file.Flush();
                file.Close();
                if (File.Exists(filepath + ".bak")) File.Delete(filepath + ".bak");
                return true;
            }
            catch (Exception e)
            {
                LogHelper.WriteLine(e.Message + Environment.NewLine + e.StackTrace.ToString());
                if (File.Exists(filepath)) File.Delete(filepath);
                if (File.Exists(filepath + ".bak")) File.Move(filepath + ".bak", filepath);
                return false;
            }
        }

        public static Options Load()
        {
            string filepath = Path.Combine(_directory, _filename);
            if (!File.Exists(filepath)) return null;
            try
            {
                FileStream file = File.OpenRead(filepath);
                BinaryFormatter bf = new BinaryFormatter();
                Options tmp = (Options)bf.Deserialize(file);
                file.Close();

                return tmp;
            }
            catch (Exception e)
            {
                LogHelper.WriteLine(e.Message + Environment.NewLine + e.StackTrace.ToString());
                return null;
            }
        }

        public bool Reload()
        {
            Options tmp = Load();
            if (tmp == null) return false;

            _virtualDriveNum = tmp.VirtualDrive.Num;
            _virtualDriveType = tmp.VirtualDrive.Type;
            _listView = tmp.ListView;
            return true;
        }
    }
}
