/*
 * This file is part of DTWrapper.
 * 
 * DTWrapper is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * DTWrapper is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with DTWrapper. If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTWrapper.Helpers
{
    /// <summary>
    /// Represents a DaemonTools virtual drive
    /// </summary>
    public class VirtualDrive
    {
        private int _num;
        private VirtualDriveType _type;
        private char _letter;

        public int Num { get { return _num; } }
        public VirtualDriveType Type { get { return _type; } }
        public char Letter { get { return _letter; } }
        public bool IsValid { get { return (_type == VirtualDriveType.NONE) ? false : (DT.CountDrv(_type) > _num); } }

        public VirtualDrive(VirtualDriveType type, int num)
        {
            _type = type;
            _num = num;
            _letter = DT.GetLetter(type, num);
        }

        /// <summary>
        /// Mount a disk image in the virtual drive
        /// </summary>
        /// <param name="path">Path to the disk image</param>
        /// <returns>true on success, false on failure</returns>
        public bool Mount(string Path)
        {
            return DT.Exec("-mount " + _type.ToString() + "," + _num + ",\"" + Path + "\"") == 0;
        }

        /// <summary>
        /// Unmount a disk image from the virtual drive
        /// </summary>
        /// <returns>true on success, false on failure</returns>
        public bool Umount()
        {
            return DT.Exec("-unmount " + _type.ToString() + "," + _num) == 0;
        }

        public override string ToString()
        {
            if (_type == VirtualDriveType.NONE)
                return "None";
            return _type.ToString() + "-" + _num.ToString() + " (" + _letter + ":)";
        }
    }
}
