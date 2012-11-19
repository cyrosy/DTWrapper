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
    partial class EditGameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGameWindow));
            this.basicOptions = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.exeLabel = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.exePathField = new System.Windows.Forms.TextBox();
            this.exePathButton = new System.Windows.Forms.Button();
            this.nameLabelState = new System.Windows.Forms.PictureBox();
            this.exeLabelState = new System.Windows.Forms.PictureBox();
            this.isoLabel = new System.Windows.Forms.Label();
            this.isoPathField = new System.Windows.Forms.TextBox();
            this.isoLabelState = new System.Windows.Forms.PictureBox();
            this.isoPathButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.exeBrowserWindow = new System.Windows.Forms.OpenFileDialog();
            this.isoBrowserWindow = new System.Windows.Forms.OpenFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.basicTab = new System.Windows.Forms.TabPage();
            this.advancedTab = new System.Windows.Forms.TabPage();
            this.advancedOptions = new System.Windows.Forms.TableLayoutPanel();
            this.iconPathField = new System.Windows.Forms.TextBox();
            this.iconPathLabel = new System.Windows.Forms.Label();
            this.iconPreview = new System.Windows.Forms.PictureBox();
            this.iconPathButton = new System.Windows.Forms.Button();
            this.iconLabelState = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.iconBrowserWindow = new System.Windows.Forms.OpenFileDialog();
            this.launcherBrowserWindow = new System.Windows.Forms.OpenFileDialog();
            this.basicOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabelState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeLabelState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isoLabelState)).BeginInit();
            this.tabControl.SuspendLayout();
            this.basicTab.SuspendLayout();
            this.advancedTab.SuspendLayout();
            this.advancedOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLabelState)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // basicOptions
            // 
            resources.ApplyResources(this.basicOptions, "basicOptions");
            this.basicOptions.Controls.Add(this.nameLabel, 0, 0);
            this.basicOptions.Controls.Add(this.exeLabel, 0, 2);
            this.basicOptions.Controls.Add(this.nameField, 0, 1);
            this.basicOptions.Controls.Add(this.exePathField, 0, 3);
            this.basicOptions.Controls.Add(this.exePathButton, 2, 3);
            this.basicOptions.Controls.Add(this.nameLabelState, 1, 1);
            this.basicOptions.Controls.Add(this.exeLabelState, 1, 3);
            this.basicOptions.Controls.Add(this.isoLabel, 0, 4);
            this.basicOptions.Controls.Add(this.isoPathField, 0, 5);
            this.basicOptions.Controls.Add(this.isoLabelState, 1, 5);
            this.basicOptions.Controls.Add(this.isoPathButton, 2, 5);
            this.basicOptions.Name = "basicOptions";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // exeLabel
            // 
            resources.ApplyResources(this.exeLabel, "exeLabel");
            this.exeLabel.Name = "exeLabel";
            // 
            // nameField
            // 
            resources.ApplyResources(this.nameField, "nameField");
            this.nameField.Name = "nameField";
            this.nameField.TextChanged += new System.EventHandler(this.nameField_TextChanged);
            // 
            // exePathField
            // 
            resources.ApplyResources(this.exePathField, "exePathField");
            this.exePathField.Name = "exePathField";
            this.exePathField.TextChanged += new System.EventHandler(this.exePathField_TextChanged);
            // 
            // exePathButton
            // 
            resources.ApplyResources(this.exePathButton, "exePathButton");
            this.exePathButton.Name = "exePathButton";
            this.exePathButton.UseVisualStyleBackColor = true;
            this.exePathButton.Click += new System.EventHandler(this.executablePathButton_Click);
            // 
            // nameLabelState
            // 
            resources.ApplyResources(this.nameLabelState, "nameLabelState");
            this.nameLabelState.Name = "nameLabelState";
            this.nameLabelState.TabStop = false;
            // 
            // exeLabelState
            // 
            resources.ApplyResources(this.exeLabelState, "exeLabelState");
            this.exeLabelState.Name = "exeLabelState";
            this.exeLabelState.TabStop = false;
            // 
            // isoLabel
            // 
            resources.ApplyResources(this.isoLabel, "isoLabel");
            this.isoLabel.Name = "isoLabel";
            // 
            // isoPathField
            // 
            resources.ApplyResources(this.isoPathField, "isoPathField");
            this.isoPathField.Name = "isoPathField";
            this.isoPathField.TextChanged += new System.EventHandler(this.isoPathField_TextChanged);
            // 
            // isoLabelState
            // 
            resources.ApplyResources(this.isoLabelState, "isoLabelState");
            this.isoLabelState.Name = "isoLabelState";
            this.isoLabelState.TabStop = false;
            // 
            // isoPathButton
            // 
            resources.ApplyResources(this.isoPathButton, "isoPathButton");
            this.isoPathButton.Name = "isoPathButton";
            this.isoPathButton.UseVisualStyleBackColor = true;
            this.isoPathButton.Click += new System.EventHandler(this.isoPathButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // exeBrowserWindow
            // 
            resources.ApplyResources(this.exeBrowserWindow, "exeBrowserWindow");
            this.exeBrowserWindow.RestoreDirectory = true;
            this.exeBrowserWindow.FileOk += new System.ComponentModel.CancelEventHandler(this.exeBrowserWindow_FileOk);
            // 
            // isoBrowserWindow
            // 
            resources.ApplyResources(this.isoBrowserWindow, "isoBrowserWindow");
            this.isoBrowserWindow.RestoreDirectory = true;
            this.isoBrowserWindow.FileOk += new System.ComponentModel.CancelEventHandler(this.isoBrowserWindow_FileOk);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.basicTab);
            this.tabControl.Controls.Add(this.advancedTab);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.HotTrack = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // basicTab
            // 
            this.basicTab.Controls.Add(this.basicOptions);
            resources.ApplyResources(this.basicTab, "basicTab");
            this.basicTab.Name = "basicTab";
            this.basicTab.UseVisualStyleBackColor = true;
            // 
            // advancedTab
            // 
            this.advancedTab.Controls.Add(this.advancedOptions);
            resources.ApplyResources(this.advancedTab, "advancedTab");
            this.advancedTab.Name = "advancedTab";
            this.advancedTab.UseVisualStyleBackColor = true;
            // 
            // advancedOptions
            // 
            resources.ApplyResources(this.advancedOptions, "advancedOptions");
            this.advancedOptions.Controls.Add(this.iconPathField, 0, 1);
            this.advancedOptions.Controls.Add(this.iconPathLabel, 0, 0);
            this.advancedOptions.Controls.Add(this.iconPreview, 0, 2);
            this.advancedOptions.Controls.Add(this.iconPathButton, 2, 1);
            this.advancedOptions.Controls.Add(this.iconLabelState, 1, 1);
            this.advancedOptions.Name = "advancedOptions";
            // 
            // iconPathField
            // 
            resources.ApplyResources(this.iconPathField, "iconPathField");
            this.iconPathField.Name = "iconPathField";
            this.iconPathField.TextChanged += new System.EventHandler(this.iconPathField_TextChanged);
            // 
            // iconPathLabel
            // 
            resources.ApplyResources(this.iconPathLabel, "iconPathLabel");
            this.iconPathLabel.Name = "iconPathLabel";
            // 
            // iconPreview
            // 
            resources.ApplyResources(this.iconPreview, "iconPreview");
            this.iconPreview.Name = "iconPreview";
            this.iconPreview.TabStop = false;
            // 
            // iconPathButton
            // 
            resources.ApplyResources(this.iconPathButton, "iconPathButton");
            this.iconPathButton.Name = "iconPathButton";
            this.iconPathButton.UseVisualStyleBackColor = true;
            this.iconPathButton.Click += new System.EventHandler(this.iconPathButton_Click);
            // 
            // iconLabelState
            // 
            resources.ApplyResources(this.iconLabelState, "iconLabelState");
            this.iconLabelState.Name = "iconLabelState";
            this.iconLabelState.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.saveButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancelButton, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // iconBrowserWindow
            // 
            resources.ApplyResources(this.iconBrowserWindow, "iconBrowserWindow");
            this.iconBrowserWindow.RestoreDirectory = true;
            this.iconBrowserWindow.FileOk += new System.ComponentModel.CancelEventHandler(this.iconBrowserWindow_FileOk);
            // 
            // launcherBrowserWindow
            // 
            resources.ApplyResources(this.launcherBrowserWindow, "launcherBrowserWindow");
            this.launcherBrowserWindow.RestoreDirectory = true;
            // 
            // EditGameWindow
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.tableLayoutPanel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditGameWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.basicOptions.ResumeLayout(false);
            this.basicOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabelState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeLabelState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isoLabelState)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.basicTab.ResumeLayout(false);
            this.advancedTab.ResumeLayout(false);
            this.advancedOptions.ResumeLayout(false);
            this.advancedOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLabelState)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel basicOptions;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox exePathField;
        private System.Windows.Forms.TextBox isoPathField;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label exeLabel;
        private System.Windows.Forms.Label isoLabel;
        private System.Windows.Forms.Button exePathButton;
        private System.Windows.Forms.Button isoPathButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.OpenFileDialog exeBrowserWindow;
        private System.Windows.Forms.OpenFileDialog isoBrowserWindow;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage basicTab;
        private System.Windows.Forms.TabPage advancedTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TableLayoutPanel advancedOptions;
        private System.Windows.Forms.Label iconPathLabel;
        private System.Windows.Forms.TextBox iconPathField;
        private System.Windows.Forms.Button iconPathButton;
        private System.Windows.Forms.OpenFileDialog iconBrowserWindow;
        private System.Windows.Forms.PictureBox iconPreview;
        private System.Windows.Forms.PictureBox nameLabelState;
        private System.Windows.Forms.PictureBox exeLabelState;
        private System.Windows.Forms.PictureBox isoLabelState;
        private System.Windows.Forms.PictureBox iconLabelState;
        private System.Windows.Forms.OpenFileDialog launcherBrowserWindow;
    }
}