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
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.closeButton, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.programIcon, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.programName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.programVersion, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.programLicence, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.licenceText, 1, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // programIcon
            // 
            resources.ApplyResources(this.programIcon, "programIcon");
            this.programIcon.Name = "programIcon";
            this.tableLayoutPanel2.SetRowSpan(this.programIcon, 4);
            this.programIcon.TabStop = false;
            // 
            // programName
            // 
            resources.ApplyResources(this.programName, "programName");
            this.programName.Name = "programName";
            // 
            // programVersion
            // 
            resources.ApplyResources(this.programVersion, "programVersion");
            this.programVersion.Name = "programVersion";
            // 
            // programLicence
            // 
            resources.ApplyResources(this.programLicence, "programLicence");
            this.programLicence.Name = "programLicence";
            // 
            // licenceText
            // 
            resources.ApplyResources(this.licenceText, "licenceText");
            this.licenceText.Name = "licenceText";
            this.licenceText.ReadOnly = true;
            // 
            // AboutWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
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