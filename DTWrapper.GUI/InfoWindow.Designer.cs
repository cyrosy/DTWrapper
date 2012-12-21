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
            this.infoLabel.AutoSize = true;
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel.Location = new System.Drawing.Point(35, 5);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(5);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(204, 231);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = Localization.Strings.InfoText;
            // 
            // infoIcon
            // 
            this.infoIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoIcon.Location = new System.Drawing.Point(3, 3);
            this.infoIcon.Name = "infoIcon";
            this.infoIcon.Size = new System.Drawing.Size(24, 235);
            this.infoIcon.TabIndex = 1;
            this.infoIcon.TabStop = false;
            // 
            // infoLayout
            // 
            this.infoLayout.AutoSize = true;
            this.infoLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infoLayout.ColumnCount = 2;
            this.infoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.infoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.infoLayout.Controls.Add(this.infoIcon, 0, 0);
            this.infoLayout.Controls.Add(this.infoLabel, 1, 0);
            this.infoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLayout.Location = new System.Drawing.Point(20, 10);
            this.infoLayout.Name = "infoLayout";
            this.infoLayout.RowCount = 1;
            this.infoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.infoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 241F));
            this.infoLayout.Size = new System.Drawing.Size(244, 241);
            this.infoLayout.TabIndex = 2;
            // 
            // InfoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.infoLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::DTWrapper.GUI.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InfoWindow";
            this.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = Localization.Strings.Information;
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