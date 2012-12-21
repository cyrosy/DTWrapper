using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DTWrapper.GUI
{
    public enum InfoType
    {
        Loading,
        None
    }

    public partial class InfoWindow : Form
    {
        public InfoWindow(string msg, InfoType type = InfoType.Loading)
        {
            InitializeComponent();
            this.infoLabel.Text = msg;
            switch (type)
            {
                case InfoType.Loading:
                    infoIcon.Size = new Size(24, 24);
                    infoIcon.Image = DTWrapper.GUI.Properties.Resources.loading;
                    ImageAnimator.Animate(infoIcon.Image, new EventHandler(this.OnFrameChanged));
                    break;
                default:
                    infoIcon.Size = new Size(0, 0);
                    break;
            }
        }

        private void OnFrameChanged(object o, EventArgs e)
        {
            infoIcon.Invalidate();
        }
    }
}
