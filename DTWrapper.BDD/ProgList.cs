using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using DTWrapper.Helpers;

namespace DTWrapper.BDD
{
    [Serializable]
    public class ProgList
    {
        private static readonly string Directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DTWrapper");
        private const string Filename = "DTWrapper.progs";
        private List<Prog> _progs = new List<Prog>();

        public List<Prog> Progs { get { if (_progs.Count < 1) Reload(); return (from p in _progs select p).ToList(); } }
        public int CurrentID { get; private set; }

        public ProgList()
        {
            Reload();
        }

        public Prog CreateProg()
        {
            return new Prog(++CurrentID);
        }

        public bool Add(Prog program)
        {
            if (!program.IsOK()) return false;
            _progs.Add(program);
            return Save(this);
        }

        public bool Update(Prog program)
        {
            try
            {
                int index = _progs.IndexOf(Get(program.ID));
                _progs.RemoveAt(index);
                _progs.Insert(index, program);
                return Save(this);
            }
            catch (Exception e)
            {
                LogHelper.WriteLine(e.Message + Environment.NewLine + e.StackTrace);
                return false;
            }
        }

        public Prog Get(int id)
        {
            return (from p in _progs where p.ID.Equals(id) select p).FirstOrDefault();
        }

        public Prog Get(string name)
        {
            return (from p in _progs where p.Name.Equals(name) select p).FirstOrDefault();
        }

        public bool Del(Prog program)
        {
            return (_progs.Remove(program) && Save(this));
        }

        public bool Del(int id)
        {
            return (_progs.Remove(Get(id)) && Save(this));
        }

        public static bool Save(ProgList list)
        {
            string filepath = Path.Combine(Directory, Filename);
            try
            {
                if (File.Exists(filepath))
                {
                    if (File.Exists(filepath + ".bak")) File.Delete(filepath + ".bak");
                    File.Move(filepath, filepath + ".bak");
                }

                FileStream file = File.Open(filepath, FileMode.Create);
                var fm = new BinaryFormatter();
                fm.Serialize(file, list);
                file.Flush();
                file.Close();
                if (File.Exists(filepath + ".bak")) File.Delete(filepath + ".bak");
                return true;
            }
            catch (Exception e)
            {
                LogHelper.WriteLine(e.Message + Environment.NewLine + e.StackTrace);
                if (File.Exists(filepath)) File.Delete(filepath);
                if (File.Exists(filepath + ".bak")) File.Move(filepath + ".bak", filepath);
                return false;
            }
        }

        public static ProgList Load()
        {
            string filepath = Path.Combine(Directory, Filename);
            if (!File.Exists(filepath)) return null;
            try
            {
                FileStream file = File.OpenRead(filepath);
                var bf = new BinaryFormatter();
                var tmp = (ProgList)bf.Deserialize(file);
                file.Close();

                return tmp;
            }
            catch (Exception e)
            {
                LogHelper.WriteLine(e.Message + Environment.NewLine + e.StackTrace);
                return null;
            }
        }

        public bool Reload()
        {
            ProgList tmp = Load();
            if (tmp == null) return false;

            CurrentID = tmp.CurrentID;
            _progs = tmp.Progs;
            return true;
        }

        public List<Prog> GetJumpList()
        {
            return (from p in _progs where p.InJumpList.Equals(true) select p).ToList();
        }
    }
}
