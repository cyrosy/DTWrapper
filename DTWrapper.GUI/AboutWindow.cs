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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTWrapper.Helpers;

namespace DTWrapper.GUI
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
            programIcon.Image = new Icon(DTWrapper.GUI.Properties.Resources.icon, 64, 64).ToBitmap();
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "LICENCE.txt")))
            {
                string[] licence = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "LICENCE.txt"));
                foreach (string line in licence)
                {
                    this.licenceText.Text += String.Format("{0}\r\n", line);
                }
            }
        }
    }
}
