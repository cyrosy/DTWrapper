namespace DTWrapper.GUI
{
    partial class InfoWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoWindow));
            this.infoLabel = new System.Windows.Forms.Label();
            this.infoIcon = new System.Windows.Forms.PictureBox();
            this.infoLayout = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.infoIcon)).BeginInit();
            this.infoLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            resources.ApplyResources(this.infoLabel, "infoLabel");
            this.infoLabel.Name = "infoLabel";
            // 
            // infoIcon
            // 
            resources.ApplyResources(this.infoIcon, "infoIcon");
            this.infoIcon.Name = "infoIcon";
            this.infoIcon.TabStop = false;
            // 
            // infoLayout
            // 
            resources.ApplyResources(this.infoLayout, "infoLayout");
            this.infoLayout.Controls.Add(this.infoIcon, 0, 0);
            this.infoLayout.Controls.Add(this.infoLabel, 1, 0);
            this.infoLayout.Name = "infoLayout";
            // 
            // InfoWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.infoLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoWindow";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.infoIcon)).EndInit();
            this.infoLayout.ResumeLayout(false);
            this.infoLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.PictureBox infoIcon;
        private System.Windows.Forms.TableLayoutPanel infoLayout;
    }
}