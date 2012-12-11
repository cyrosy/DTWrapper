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
        private static string _filename = "DTWrapper.conf";
        private VirtualDriveType _virtualDriveType = VirtualDriveType.NONE;
        private int _virtualDriveNum = -1;
        private View _listView = View.Details;

        public VirtualDrive VirtualDrive
        {
            get
            {
                return new VirtualDrive(_virtualDriveType, _virtualDriveNum);
            }
            set
            {
                _virtualDriveType = value.Type;
                _virtualDriveNum = value.Num;
                Save(this);
            } 
        }
        public View ListView
        {
            get
            {
                return _listView;
            }
            set
            {
                _listView = value;
                Save(this);
            }
        }

        public bool FileExists() { return File.Exists(_filename); }

        public Options()
        {
            Reload();
        }

        public static bool Save(Options options)
        {
            try {
                if (File.Exists(_filename))
                {
                    if (File.Exists(_filename + ".bak")) File.Delete(_filename + ".bak");
                    File.Move(_filename, _filename + ".bak");
                }

                FileStream file = File.Open(_filename, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, options);
                file.Flush();
                file.Close();
                return true;
            }
            catch (Exception e)
            {
                LogHelper.WriteLine(e.Message + Environment.NewLine + e.StackTrace.ToString());
                if(File.Exists(_filename)) File.Delete(_filename);
                File.Move(_filename + ".bak", _filename);
                return false;
            }
        }

        public static Options Load()
        {
            if (!File.Exists(_filename)) return null;
            try
            {
                FileStream file = File.OpenRead(_filename);
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
