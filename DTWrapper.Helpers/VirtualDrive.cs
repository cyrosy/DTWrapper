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
using System.Resources;
using System.Text;

namespace DTWrapper.Helpers
{
    /// <summary>
    /// Represents a DaemonTools virtual drive
    /// </summary>
    public class VirtualDrive
    {
        private ResourceManager Locale = new ResourceManager("DTWrapper.Helpers.VirtualDrive", typeof(VirtualDrive).Assembly);

        public DriveType Type { get; private set; }
        public int Num { get; private set; }
        public char Letter { get; private set; }
        public bool IsValid { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="type">The virtual drive type</param>
        /// <param name="num">The virtual drive number</param>
        public VirtualDrive(DriveType type, int num)
        {
            IsValid = false;
            Type = type;
            Num = num;
            if (Type != DriveType.NONE)
            {
                Letter = DTHelper.GetLetter(Type, Num);
                if (Num >= 0 && Num < DTHelper.CountDrv(Type))
                {
                    IsValid = true;
                }
            }
        }

        /// <summary>
        /// Get a string representing the virtual drive
        /// </summary>
        /// <returns>(X:) Type-n</returns>
        public override string ToString()
        {
            if (!IsValid)
            {
                return Locale.GetString("InvalidDrive");
            }
            return "(" + Letter + ":) " + Type.ToString() + "-" + Num; 
        }
    }
}
