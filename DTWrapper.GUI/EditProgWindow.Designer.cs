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
    partial class EditProgWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProgWindow));
            this.basicOptions = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.pathField = new System.Windows.Forms.TextBox();
            this.pathButton = new System.Windows.Forms.Button();
            this.nameLabelState = new System.Windows.Forms.PictureBox();
            this.pathLabelState = new System.Windows.Forms.PictureBox();
            this.diskImageLabel = new System.Windows.Forms.Label();
            this.diskImageField = new System.Windows.Forms.TextBox();
            this.diskImageLabelState = new System.Windows.Forms.PictureBox();
            this.diskImageButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pathBrowser = new System.Windows.Forms.OpenFileDialog();
            this.diskImageBrowser = new System.Windows.Forms.OpenFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.basicTab = new System.Windows.Forms.TabPage();
            this.advancedTab = new System.Windows.Forms.TabPage();
            this.advancedOptions = new System.Windows.Forms.TableLayoutPanel();
            this.iconField = new System.Windows.Forms.TextBox();
            this.iconLabel = new System.Windows.Forms.Label();
            this.iconButton = new System.Windows.Forms.Button();
            this.iconLabelState = new System.Windows.Forms.PictureBox();
            this.iconPreview = new System.Windows.Forms.PictureBox();
            this.jumpListLabel = new System.Windows.Forms.Label();
            this.jumpListBox = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.iconBrowser = new System.Windows.Forms.OpenFileDialog();
            this.basicOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabelState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathLabelState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskImageLabelState)).BeginInit();
            this.tabControl.SuspendLayout();
            this.basicTab.SuspendLayout();
            this.advancedTab.SuspendLayout();
            this.advancedOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLabelState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPreview)).BeginInit();
            this.buttonsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // basicOptions
            // 
            resources.ApplyResources(this.basicOptions, "basicOptions");
            this.basicOptions.Controls.Add(this.nameLabel, 0, 0);
            this.basicOptions.Controls.Add(this.pathLabel, 0, 2);
            this.basicOptions.Controls.Add(this.nameField, 0, 1);
            this.basicOptions.Controls.Add(this.pathField, 0, 3);
            this.basicOptions.Controls.Add(this.pathButton, 2, 3);
            this.basicOptions.Controls.Add(this.nameLabelState, 1, 1);
            this.basicOptions.Controls.Add(this.pathLabelState, 1, 3);
            this.basicOptions.Controls.Add(this.diskImageLabel, 0, 4);
            this.basicOptions.Controls.Add(this.diskImageField, 0, 5);
            this.basicOptions.Controls.Add(this.diskImageLabelState, 1, 5);
            this.basicOptions.Controls.Add(this.diskImageButton, 2, 5);
            this.basicOptions.Name = "basicOptions";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // pathLabel
            // 
            resources.ApplyResources(this.pathLabel, "pathLabel");
            this.pathLabel.Name = "pathLabel";
            // 
            // nameField
            // 
            resources.ApplyResources(this.nameField, "nameField");
            this.nameField.Name = "nameField";
            this.nameField.TextChanged += new System.EventHandler(this.nameField_TextChanged);
            // 
            // pathField
            // 
            resources.ApplyResources(this.pathField, "pathField");
            this.pathField.Name = "pathField";
            this.pathField.TextChanged += new System.EventHandler(this.pathField_TextChanged);
            // 
            // pathButton
            // 
            resources.ApplyResources(this.pathButton, "pathButton");
            this.pathButton.Name = "pathButton";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // nameLabelState
            // 
            resources.ApplyResources(this.nameLabelState, "nameLabelState");
            this.nameLabelState.Name = "nameLabelState";
            this.nameLabelState.TabStop = false;
            // 
            // pathLabelState
            // 
            resources.ApplyResources(this.pathLabelState, "pathLabelState");
            this.pathLabelState.Name = "pathLabelState";
            this.pathLabelState.TabStop = false;
            // 
            // diskImageLabel
            // 
            resources.ApplyResources(this.diskImageLabel, "diskImageLabel");
            this.diskImageLabel.Name = "diskImageLabel";
            // 
            // diskImageField
            // 
            resources.ApplyResources(this.diskImageField, "diskImageField");
            this.diskImageField.Name = "diskImageField";
            this.diskImageField.TextChanged += new System.EventHandler(this.diskImageField_TextChanged);
            // 
            // diskImageLabelState
            // 
            resources.ApplyResources(this.diskImageLabelState, "diskImageLabelState");
            this.diskImageLabelState.Name = "diskImageLabelState";
            this.diskImageLabelState.TabStop = false;
            // 
            // diskImageButton
            // 
            resources.ApplyResources(this.diskImageButton, "diskImageButton");
            this.diskImageButton.Name = "diskImageButton";
            this.diskImageButton.UseVisualStyleBackColor = true;
            this.diskImageButton.Click += new System.EventHandler(this.diskImageButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // pathBrowser
            // 
            resources.ApplyResources(this.pathBrowser, "pathBrowser");
            this.pathBrowser.RestoreDirectory = true;
            this.pathBrowser.FileOk += new System.ComponentModel.CancelEventHandler(this.pathBrowser_FileOk);
            // 
            // diskImageBrowser
            // 
            resources.ApplyResources(this.diskImageBrowser, "diskImageBrowser");
            this.diskImageBrowser.RestoreDirectory = true;
            this.diskImageBrowser.FileOk += new System.ComponentModel.CancelEventHandler(this.diskImageBrowser_FileOk);
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
            this.advancedOptions.Controls.Add(this.iconField, 0, 2);
            this.advancedOptions.Controls.Add(this.iconLabel, 0, 1);
            this.advancedOptions.Controls.Add(this.iconButton, 2, 2);
            this.advancedOptions.Controls.Add(this.iconLabelState, 1, 2);
            this.advancedOptions.Controls.Add(this.iconPreview, 0, 3);
            this.advancedOptions.Controls.Add(this.jumpListLabel, 0, 0);
            this.advancedOptions.Controls.Add(this.jumpListBox, 2, 0);
            this.advancedOptions.Name = "advancedOptions";
            // 
            // iconField
            // 
            resources.ApplyResources(this.iconField, "iconField");
            this.iconField.Name = "iconField";
            this.iconField.TextChanged += new System.EventHandler(this.iconField_TextChanged);
            // 
            // iconLabel
            // 
            resources.ApplyResources(this.iconLabel, "iconLabel");
            this.iconLabel.Name = "iconLabel";
            // 
            // iconButton
            // 
            resources.ApplyResources(this.iconButton, "iconButton");
            this.iconButton.Name = "iconButton";
            this.iconButton.UseVisualStyleBackColor = true;
            this.iconButton.Click += new System.EventHandler(this.iconButton_Click);
            // 
            // iconLabelState
            // 
            resources.ApplyResources(this.iconLabelState, "iconLabelState");
            this.iconLabelState.Name = "iconLabelState";
            this.iconLabelState.TabStop = false;
            // 
            // iconPreview
            // 
            resources.ApplyResources(this.iconPreview, "iconPreview");
            this.iconPreview.Name = "iconPreview";
            this.iconPreview.TabStop = false;
            // 
            // jumpListLabel
            // 
            resources.ApplyResources(this.jumpListLabel, "jumpListLabel");
            this.jumpListLabel.Name = "jumpListLabel";
            // 
            // jumpListBox
            // 
            resources.ApplyResources(this.jumpListBox, "jumpListBox");
            this.jumpListBox.Name = "jumpListBox";
            this.jumpListBox.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // buttonsTable
            // 
            resources.ApplyResources(this.buttonsTable, "buttonsTable");
            this.buttonsTable.Controls.Add(this.saveButton, 1, 0);
            this.buttonsTable.Controls.Add(this.cancelButton, 0, 0);
            this.buttonsTable.Name = "buttonsTable";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // iconBrowser
            // 
            resources.ApplyResources(this.iconBrowser, "iconBrowser");
            this.iconBrowser.RestoreDirectory = true;
            this.iconBrowser.FileOk += new System.ComponentModel.CancelEventHandler(this.iconBrowser_FileOk);
            // 
            // EditProgWindow
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonsTable);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProgWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.basicOptions.ResumeLayout(false);
            this.basicOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabelState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathLabelState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diskImageLabelState)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.basicTab.ResumeLayout(false);
            this.advancedTab.ResumeLayout(false);
            this.advancedOptions.ResumeLayout(false);
            this.advancedOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLabelState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPreview)).EndInit();
            this.buttonsTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel basicOptions;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox pathField;
        private System.Windows.Forms.TextBox diskImageField;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label diskImageLabel;
        private System.Windows.Forms.Button pathButton;
        private System.Windows.Forms.Button diskImageButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.OpenFileDialog pathBrowser;
        private System.Windows.Forms.OpenFileDialog diskImageBrowser;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage basicTab;
        private System.Windows.Forms.TabPage advancedTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel buttonsTable;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TableLayoutPanel advancedOptions;
        private System.Windows.Forms.Label iconLabel;
        private System.Windows.Forms.TextBox iconField;
        private System.Windows.Forms.Button iconButton;
        private System.Windows.Forms.OpenFileDialog iconBrowser;
        private System.Windows.Forms.PictureBox iconPreview;
        private System.Windows.Forms.PictureBox nameLabelState;
        private System.Windows.Forms.PictureBox pathLabelState;
        private System.Windows.Forms.PictureBox diskImageLabelState;
        private System.Windows.Forms.PictureBox iconLabelState;
        private System.Windows.Forms.Label jumpListLabel;
        private System.Windows.Forms.CheckBox jumpListBox;
    }
}