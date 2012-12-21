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
            this.argsLabel = new System.Windows.Forms.Label();
            this.argsField = new System.Windows.Forms.TextBox();
            this.jumpListLabelState = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.jumpListLabelState)).BeginInit();
            this.buttonsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // basicOptions
            // 
            this.basicOptions.ColumnCount = 3;
            this.basicOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.basicOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.basicOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
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
            this.basicOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicOptions.Location = new System.Drawing.Point(3, 3);
            this.basicOptions.Name = "basicOptions";
            this.basicOptions.RowCount = 7;
            this.basicOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.basicOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.basicOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.basicOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.basicOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.basicOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.basicOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.basicOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.basicOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.basicOptions.Size = new System.Drawing.Size(370, 169);
            this.basicOptions.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(294, 25);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = Localization.Strings.Name;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathLabel.Location = new System.Drawing.Point(3, 50);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(294, 25);
            this.pathLabel.TabIndex = 11;
            this.pathLabel.Text = Localization.Strings.ExecutablePath;
            this.pathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameField
            // 
            this.nameField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameField.Location = new System.Drawing.Point(3, 28);
            this.nameField.MaxLength = 50;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(294, 20);
            this.nameField.TabIndex = 1;
            this.nameField.TextChanged += new System.EventHandler(this.nameField_TextChanged);
            // 
            // pathField
            // 
            this.pathField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathField.Location = new System.Drawing.Point(3, 78);
            this.pathField.Name = "pathField";
            this.pathField.Size = new System.Drawing.Size(294, 20);
            this.pathField.TabIndex = 2;
            this.pathField.TextChanged += new System.EventHandler(this.pathField_TextChanged);
            // 
            // pathButton
            // 
            this.pathButton.AutoSize = true;
            this.pathButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pathButton.Location = new System.Drawing.Point(328, 78);
            this.pathButton.Name = "pathButton";
            this.pathButton.Size = new System.Drawing.Size(26, 19);
            this.pathButton.TabIndex = 3;
            this.pathButton.Text = "...";
            this.pathButton.UseVisualStyleBackColor = true;
            this.pathButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // nameLabelState
            // 
            this.nameLabelState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabelState.Image = global::DTWrapper.GUI.Properties.Resources.warning;
            this.nameLabelState.Location = new System.Drawing.Point(300, 25);
            this.nameLabelState.Margin = new System.Windows.Forms.Padding(0);
            this.nameLabelState.Name = "nameLabelState";
            this.nameLabelState.Size = new System.Drawing.Size(25, 25);
            this.nameLabelState.TabIndex = 6;
            this.nameLabelState.TabStop = false;
            // 
            // pathLabelState
            // 
            this.pathLabelState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathLabelState.Image = global::DTWrapper.GUI.Properties.Resources.warning;
            this.pathLabelState.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pathLabelState.Location = new System.Drawing.Point(300, 75);
            this.pathLabelState.Margin = new System.Windows.Forms.Padding(0);
            this.pathLabelState.Name = "pathLabelState";
            this.pathLabelState.Size = new System.Drawing.Size(25, 25);
            this.pathLabelState.TabIndex = 6;
            this.pathLabelState.TabStop = false;
            // 
            // diskImageLabel
            // 
            this.diskImageLabel.AutoSize = true;
            this.diskImageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diskImageLabel.Location = new System.Drawing.Point(3, 100);
            this.diskImageLabel.Name = "diskImageLabel";
            this.diskImageLabel.Size = new System.Drawing.Size(294, 25);
            this.diskImageLabel.TabIndex = 12;
            this.diskImageLabel.Text = Localization.Strings.DiskImagePath;
            this.diskImageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // diskImageField
            // 
            this.diskImageField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diskImageField.Location = new System.Drawing.Point(3, 128);
            this.diskImageField.Name = "diskImageField";
            this.diskImageField.Size = new System.Drawing.Size(294, 20);
            this.diskImageField.TabIndex = 4;
            this.diskImageField.TextChanged += new System.EventHandler(this.diskImageField_TextChanged);
            // 
            // diskImageLabelState
            // 
            this.diskImageLabelState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diskImageLabelState.Image = global::DTWrapper.GUI.Properties.Resources.warning;
            this.diskImageLabelState.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.diskImageLabelState.Location = new System.Drawing.Point(300, 125);
            this.diskImageLabelState.Margin = new System.Windows.Forms.Padding(0);
            this.diskImageLabelState.Name = "diskImageLabelState";
            this.diskImageLabelState.Size = new System.Drawing.Size(25, 25);
            this.diskImageLabelState.TabIndex = 6;
            this.diskImageLabelState.TabStop = false;
            // 
            // diskImageButton
            // 
            this.diskImageButton.AutoSize = true;
            this.diskImageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.diskImageButton.Location = new System.Drawing.Point(328, 128);
            this.diskImageButton.Name = "diskImageButton";
            this.diskImageButton.Size = new System.Drawing.Size(26, 19);
            this.diskImageButton.TabIndex = 5;
            this.diskImageButton.Text = "...";
            this.diskImageButton.UseVisualStyleBackColor = true;
            this.diskImageButton.Click += new System.EventHandler(this.diskImageButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 29);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = Localization.Strings.Cancel;
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // pathBrowser
            // 
            this.pathBrowser.Filter = Localization.Strings.ExecutableFilter;
            this.pathBrowser.RestoreDirectory = true;
            this.pathBrowser.Title = Localization.Strings.ExecutablePath;
            this.pathBrowser.FileOk += new System.ComponentModel.CancelEventHandler(this.pathBrowser_FileOk);
            // 
            // diskImageBrowser
            // 
            this.diskImageBrowser.Filter = Localization.Strings.DiskImageFilter;
            this.diskImageBrowser.RestoreDirectory = true;
            this.diskImageBrowser.Title = Localization.Strings.DiskImagePath;
            this.diskImageBrowser.FileOk += new System.ComponentModel.CancelEventHandler(this.diskImageBrowser_FileOk);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.basicTab);
            this.tabControl.Controls.Add(this.advancedTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(384, 201);
            this.tabControl.TabIndex = 1;
            // 
            // basicTab
            // 
            this.basicTab.Controls.Add(this.basicOptions);
            this.basicTab.Location = new System.Drawing.Point(4, 22);
            this.basicTab.Name = "basicTab";
            this.basicTab.Padding = new System.Windows.Forms.Padding(3);
            this.basicTab.Size = new System.Drawing.Size(376, 175);
            this.basicTab.TabIndex = 0;
            this.basicTab.Text = Localization.Strings.Basic;
            this.basicTab.UseVisualStyleBackColor = true;
            // 
            // advancedTab
            // 
            this.advancedTab.Controls.Add(this.advancedOptions);
            this.advancedTab.Location = new System.Drawing.Point(4, 22);
            this.advancedTab.Name = "advancedTab";
            this.advancedTab.Padding = new System.Windows.Forms.Padding(3);
            this.advancedTab.Size = new System.Drawing.Size(376, 175);
            this.advancedTab.TabIndex = 1;
            this.advancedTab.Text = Localization.Strings.Advanced;
            this.advancedTab.UseVisualStyleBackColor = true;
            // 
            // advancedOptions
            // 
            this.advancedOptions.ColumnCount = 3;
            this.advancedOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.advancedOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.advancedOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.advancedOptions.Controls.Add(this.iconField, 0, 4);
            this.advancedOptions.Controls.Add(this.iconLabel, 0, 3);
            this.advancedOptions.Controls.Add(this.iconButton, 2, 4);
            this.advancedOptions.Controls.Add(this.iconLabelState, 1, 4);
            this.advancedOptions.Controls.Add(this.iconPreview, 0, 5);
            this.advancedOptions.Controls.Add(this.jumpListLabel, 0, 0);
            this.advancedOptions.Controls.Add(this.jumpListBox, 2, 0);
            this.advancedOptions.Controls.Add(this.argsLabel, 0, 1);
            this.advancedOptions.Controls.Add(this.argsField, 0, 2);
            this.advancedOptions.Controls.Add(this.jumpListLabelState, 1, 0);
            this.advancedOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedOptions.Location = new System.Drawing.Point(3, 3);
            this.advancedOptions.Name = "advancedOptions";
            this.advancedOptions.RowCount = 6;
            this.advancedOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.advancedOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.advancedOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.advancedOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.advancedOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.advancedOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.advancedOptions.Size = new System.Drawing.Size(370, 169);
            this.advancedOptions.TabIndex = 0;
            // 
            // iconField
            // 
            this.iconField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconField.Location = new System.Drawing.Point(3, 103);
            this.iconField.Name = "iconField";
            this.iconField.Size = new System.Drawing.Size(294, 20);
            this.iconField.TabIndex = 1;
            this.iconField.TextChanged += new System.EventHandler(this.iconField_TextChanged);
            // 
            // iconLabel
            // 
            this.iconLabel.AutoSize = true;
            this.iconLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconLabel.Location = new System.Drawing.Point(3, 75);
            this.iconLabel.Name = "iconLabel";
            this.iconLabel.Size = new System.Drawing.Size(294, 25);
            this.iconLabel.TabIndex = 50;
            this.iconLabel.Text = Localization.Strings.IconPath;
            this.iconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconButton
            // 
            this.iconButton.AutoSize = true;
            this.iconButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iconButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.iconButton.Location = new System.Drawing.Point(328, 103);
            this.iconButton.Name = "iconButton";
            this.iconButton.Size = new System.Drawing.Size(26, 19);
            this.iconButton.TabIndex = 4;
            this.iconButton.Text = "...";
            this.iconButton.UseVisualStyleBackColor = true;
            this.iconButton.Click += new System.EventHandler(this.iconButton_Click);
            // 
            // iconLabelState
            // 
            this.iconLabelState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconLabelState.Image = global::DTWrapper.GUI.Properties.Resources.warning;
            this.iconLabelState.Location = new System.Drawing.Point(300, 100);
            this.iconLabelState.Margin = new System.Windows.Forms.Padding(0);
            this.iconLabelState.Name = "iconLabelState";
            this.iconLabelState.Size = new System.Drawing.Size(25, 25);
            this.iconLabelState.TabIndex = 5;
            this.iconLabelState.TabStop = false;
            // 
            // iconPreview
            // 
            this.iconPreview.InitialImage = null;
            this.iconPreview.Location = new System.Drawing.Point(3, 128);
            this.iconPreview.Name = "iconPreview";
            this.iconPreview.Size = new System.Drawing.Size(100, 50);
            this.iconPreview.TabIndex = 1;
            this.iconPreview.TabStop = false;
            // 
            // jumpListLabel
            // 
            this.jumpListLabel.AutoSize = true;
            this.jumpListLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jumpListLabel.Location = new System.Drawing.Point(3, 3);
            this.jumpListLabel.Margin = new System.Windows.Forms.Padding(3);
            this.jumpListLabel.Name = "jumpListLabel";
            this.jumpListLabel.Size = new System.Drawing.Size(294, 19);
            this.jumpListLabel.TabIndex = 51;
            this.jumpListLabel.Text = Localization.Strings.AddToJumpList;
            this.jumpListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // jumpListBox
            // 
            this.jumpListBox.AutoSize = true;
            this.jumpListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jumpListBox.Location = new System.Drawing.Point(328, 3);
            this.jumpListBox.Name = "jumpListBox";
            this.jumpListBox.Size = new System.Drawing.Size(39, 19);
            this.jumpListBox.TabIndex = 52;
            this.jumpListBox.UseVisualStyleBackColor = true;
            // 
            // argsLabel
            // 
            this.argsLabel.AutoSize = true;
            this.argsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.argsLabel.Location = new System.Drawing.Point(3, 25);
            this.argsLabel.Name = "argsLabel";
            this.argsLabel.Size = new System.Drawing.Size(294, 25);
            this.argsLabel.TabIndex = 53;
            this.argsLabel.Text = Localization.Strings.Args;
            this.argsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // argsField
            // 
            this.argsField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.argsField.Location = new System.Drawing.Point(3, 53);
            this.argsField.Name = "argsField";
            this.argsField.Size = new System.Drawing.Size(294, 20);
            this.argsField.TabIndex = 54;
            // 
            // jumpListLabelState
            // 
            this.jumpListLabelState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jumpListLabelState.Location = new System.Drawing.Point(300, 0);
            this.jumpListLabelState.Margin = new System.Windows.Forms.Padding(0);
            this.jumpListLabelState.Name = "jumpListLabelState";
            this.jumpListLabelState.Size = new System.Drawing.Size(25, 25);
            this.jumpListLabelState.TabIndex = 55;
            this.jumpListLabelState.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 201);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(384, 0);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonsTable
            // 
            this.buttonsTable.AutoSize = true;
            this.buttonsTable.ColumnCount = 2;
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTable.Controls.Add(this.saveButton, 1, 0);
            this.buttonsTable.Controls.Add(this.cancelButton, 0, 0);
            this.buttonsTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsTable.Location = new System.Drawing.Point(0, 201);
            this.buttonsTable.Name = "buttonsTable";
            this.buttonsTable.RowCount = 1;
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.buttonsTable.Size = new System.Drawing.Size(384, 35);
            this.buttonsTable.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.saveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveButton.Location = new System.Drawing.Point(292, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(89, 29);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = Localization.Strings.Save;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // iconBrowser
            // 
            this.iconBrowser.Filter = Localization.Strings.IconFilter;
            this.iconBrowser.RestoreDirectory = true;
            this.iconBrowser.Title = Localization.Strings.IconPath;
            this.iconBrowser.FileOk += new System.ComponentModel.CancelEventHandler(this.iconBrowser_FileOk);
            // 
            // EditProgWindow
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(384, 236);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonsTable);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = Properties.Resources.icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProgWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = Localization.Strings.EditProgram;
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
            ((System.ComponentModel.ISupportInitialize)(this.jumpListLabelState)).EndInit();
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
        private System.Windows.Forms.Label argsLabel;
        private System.Windows.Forms.TextBox argsField;
        private System.Windows.Forms.PictureBox jumpListLabelState;
    }
}