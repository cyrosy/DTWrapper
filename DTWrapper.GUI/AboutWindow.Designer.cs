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

namespace DTWrapper.GUI
{
    partial class AboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.closeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.programIcon = new System.Windows.Forms.PictureBox();
            this.programName = new System.Windows.Forms.Label();
            this.programVersion = new System.Windows.Forms.Label();
            this.programLicence = new System.Windows.Forms.Label();
            this.licenceText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.closeButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 231);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 30);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Location = new System.Drawing.Point(306, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 24);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = Localization.Strings.Close;
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.programIcon, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.programName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.programVersion, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.programLicence, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.licenceText, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(384, 231);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // programIcon
            // 
            this.programIcon.Location = new System.Drawing.Point(10, 10);
            this.programIcon.Margin = new System.Windows.Forms.Padding(10);
            this.programIcon.Name = "programIcon";
            this.tableLayoutPanel2.SetRowSpan(this.programIcon, 4);
            this.programIcon.Size = new System.Drawing.Size(64, 64);
            this.programIcon.TabIndex = 0;
            this.programIcon.TabStop = false;
            // 
            // programName
            // 
            this.programName.AutoSize = true;
            this.programName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.programName.Location = new System.Drawing.Point(87, 3);
            this.programName.Margin = new System.Windows.Forms.Padding(3);
            this.programName.Name = "programName";
            this.programName.Size = new System.Drawing.Size(294, 18);
            this.programName.TabIndex = 1;
            this.programName.Text = Localization.Strings.ProgramName;
            this.programName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // programVersion
            // 
            this.programVersion.AutoSize = true;
            this.programVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programVersion.Location = new System.Drawing.Point(87, 27);
            this.programVersion.Margin = new System.Windows.Forms.Padding(3);
            this.programVersion.Name = "programVersion";
            this.programVersion.Size = new System.Drawing.Size(294, 13);
            this.programVersion.TabIndex = 2;
            this.programVersion.Text = Localization.Strings.ProgramVersion;
            this.programVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // programLicence
            // 
            this.programLicence.AutoSize = true;
            this.programLicence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.programLicence.Location = new System.Drawing.Point(87, 46);
            this.programLicence.Margin = new System.Windows.Forms.Padding(3);
            this.programLicence.Name = "programLicence";
            this.programLicence.Size = new System.Drawing.Size(294, 13);
            this.programLicence.TabIndex = 3;
            this.programLicence.Text = Localization.Strings.Licence;
            this.programLicence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // licenceText
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.licenceText, 2);
            this.licenceText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.licenceText.Location = new System.Drawing.Point(3, 87);
            this.licenceText.Multiline = true;
            this.licenceText.Name = "licenceText";
            this.licenceText.ReadOnly = true;
            this.licenceText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.licenceText.Size = new System.Drawing.Size(378, 152);
            this.licenceText.TabIndex = 4;
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = Properties.Resources.icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = Localization.Strings.About;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox programIcon;
        private System.Windows.Forms.Label programName;
        private System.Windows.Forms.Label programVersion;
        private System.Windows.Forms.Label programLicence;
        private System.Windows.Forms.TextBox licenceText;
    }
}