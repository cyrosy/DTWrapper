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
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.progsListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isoColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.largeIcons = new System.Windows.Forms.ImageList(this.components);
            this.smallIcons = new System.Windows.Forms.ImageList(this.components);
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.DTVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.selectedDrive = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.addButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.startButton = new System.Windows.Forms.ToolStripButton();
            this.editButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.listViewDisplayModeDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.detailsListViewMode = new System.Windows.Forms.ToolStripMenuItem();
            this.listListViewMode = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconsListViewMode = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconsListViewMode = new System.Windows.Forms.ToolStripMenuItem();
            this.shortcutButton = new System.Windows.Forms.ToolStripButton();
            this.menuBarSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.statusBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = Properties.Resources.icon;
            this.trayIcon.Text = Localization.Strings.ProgWaitingEnd;
            // 
            // progsListView
            // 
            this.progsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.exeColumn,
            this.isoColumn});
            this.progsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progsListView.FullRowSelect = true;
            this.progsListView.GridLines = true;
            this.progsListView.HideSelection = false;
            this.progsListView.LargeImageList = this.largeIcons;
            this.progsListView.Location = new System.Drawing.Point(0, 49);
            this.progsListView.MultiSelect = false;
            this.progsListView.Name = "progsListView";
            this.progsListView.Size = new System.Drawing.Size(584, 291);
            this.progsListView.SmallImageList = this.smallIcons;
            this.progsListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.progsListView.TabIndex = 0;
            this.progsListView.UseCompatibleStateImageBehavior = false;
            this.progsListView.View = System.Windows.Forms.View.Details;
            this.progsListView.SelectedIndexChanged += new System.EventHandler(this.gamesListView_SelectedIndexChanged);
            this.progsListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gamesListView_MouseDoubleClick);
            // 
            // nameColumn
            // 
            this.nameColumn.Tag = "Nom";
            this.nameColumn.Text = Localization.Strings.Name;
            // 
            // exeColumn
            // 
            this.exeColumn.Tag = "Exe";
            this.exeColumn.Text = Localization.Strings.ExecutablePath;
            this.exeColumn.Width = 131;
            // 
            // isoColumn
            // 
            this.isoColumn.Tag = "Iso";
            this.isoColumn.Text = Localization.Strings.DiskImagePath;
            this.isoColumn.Width = 157;
            // 
            // largeIcons
            // 
            this.largeIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.largeIcons.ImageSize = new System.Drawing.Size(32, 32);
            this.largeIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // smallIcons
            // 
            this.smallIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.smallIcons.ImageSize = new System.Drawing.Size(16, 16);
            this.smallIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DTVersion,
            this.selectedDrive});
            this.statusBar.Location = new System.Drawing.Point(0, 340);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(584, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 3;
            // 
            // DTVersion
            // 
            this.DTVersion.Name = "DTVersion";
            this.DTVersion.Size = new System.Drawing.Size(166, 17);
            this.DTVersion.Text = Localization.Strings.DTVersion;
            // 
            // selectedDrive
            // 
            this.selectedDrive.Name = "selectedDrive";
            this.selectedDrive.Size = new System.Drawing.Size(173, 17);
            this.selectedDrive.Text = Localization.Strings.VirtualDrive;
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.aboutMenu});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(584, 24);
            this.menuBar.TabIndex = 1;
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuItem,
            this.optionsMenuItem,
            this.exitMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(142, 20);
            this.fileMenu.Text = Localization.Strings.File;
            // 
            // addMenuItem
            // 
            this.addMenuItem.Image = global::DTWrapper.GUI.Properties.Resources.add;
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addMenuItem.Size = new System.Drawing.Size(290, 22);
            this.addMenuItem.Text = Localization.Strings.AddProgram;
            this.addMenuItem.Click += new System.EventHandler(this.addMenuItem_Click);
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.Name = "optionsMenuItem";
            this.optionsMenuItem.Size = new System.Drawing.Size(290, 22);
            this.optionsMenuItem.Text = Localization.Strings.Options;
            this.optionsMenuItem.Click += new System.EventHandler(this.optionsMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitMenuItem.Size = new System.Drawing.Size(290, 22);
            this.exitMenuItem.Text = Localization.Strings.Exit;
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutItem});
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(188, 20);
            this.aboutMenu.Text = Localization.Strings.AboutMenu;
            // 
            // aboutItem
            // 
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.Size = new System.Drawing.Size(212, 22);
            this.aboutItem.Text = Localization.Strings.About;
            this.aboutItem.Click += new System.EventHandler(this.aboutItem_Click);
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addButton,
            this.toolStripSeparator1,
            this.startButton,
            this.editButton,
            this.deleteButton,
            this.listViewDisplayModeDropDown,
            this.shortcutButton});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(584, 25);
            this.toolBar.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addButton.Image = global::DTWrapper.GUI.Properties.Resources.add;
            this.addButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(23, 22);
            this.addButton.Text = Localization.Strings.AddProgram;
            this.addButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // startButton
            // 
            this.startButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startButton.Image = global::DTWrapper.GUI.Properties.Resources.play;
            this.startButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(23, 22);
            this.startButton.Text = Localization.Strings.Start;
            this.startButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // editButton
            // 
            this.editButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editButton.Image = global::DTWrapper.GUI.Properties.Resources.edit;
            this.editButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(23, 22);
            this.editButton.Text = Localization.Strings.Edit;
            this.editButton.Click += new System.EventHandler(this.editGameButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Image = global::DTWrapper.GUI.Properties.Resources.del;
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(23, 22);
            this.deleteButton.Text = Localization.Strings.Delete;
            this.deleteButton.Click += new System.EventHandler(this.deleteGameButton_Click);
            // 
            // listViewDisplayModeDropDown
            // 
            this.listViewDisplayModeDropDown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.listViewDisplayModeDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listViewDisplayModeDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsListViewMode,
            this.listListViewMode,
            this.smallIconsListViewMode,
            this.largeIconsListViewMode});
            this.listViewDisplayModeDropDown.Image = global::DTWrapper.GUI.Properties.Resources.zoom;
            this.listViewDisplayModeDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.listViewDisplayModeDropDown.Name = "listViewDisplayModeDropDown";
            this.listViewDisplayModeDropDown.Size = new System.Drawing.Size(29, 22);
            this.listViewDisplayModeDropDown.Text = Localization.Strings.View;
            // 
            // detailsListViewMode
            // 
            this.detailsListViewMode.Name = "detailsListViewMode";
            this.detailsListViewMode.Size = new System.Drawing.Size(236, 22);
            this.detailsListViewMode.Text = Localization.Strings.Details;
            this.detailsListViewMode.Click += new System.EventHandler(this.detailsListViewMode_Click);
            // 
            // listListViewMode
            // 
            this.listListViewMode.Name = "listListViewMode";
            this.listListViewMode.Size = new System.Drawing.Size(236, 22);
            this.listListViewMode.Text = Localization.Strings.List;
            this.listListViewMode.Click += new System.EventHandler(this.listListViewMode_Click);
            // 
            // smallIconsListViewMode
            // 
            this.smallIconsListViewMode.Name = "smallIconsListViewMode";
            this.smallIconsListViewMode.Size = new System.Drawing.Size(236, 22);
            this.smallIconsListViewMode.Text = Localization.Strings.SmallIcons;
            this.smallIconsListViewMode.Click += new System.EventHandler(this.smallIconsListViewMode_Click);
            // 
            // largeIconsListViewMode
            // 
            this.largeIconsListViewMode.Name = "largeIconsListViewMode";
            this.largeIconsListViewMode.Size = new System.Drawing.Size(236, 22);
            this.largeIconsListViewMode.Text = Localization.Strings.LargeIcons;
            this.largeIconsListViewMode.Click += new System.EventHandler(this.largeIconsListViewMode_Click);
            // 
            // shortcutButton
            // 
            this.shortcutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shortcutButton.Image = global::DTWrapper.GUI.Properties.Resources.shortcut;
            this.shortcutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shortcutButton.Name = "shortcutButton";
            this.shortcutButton.Size = new System.Drawing.Size(23, 22);
            this.shortcutButton.Text = Localization.Strings.CreateShortcut;
            this.shortcutButton.Click += new System.EventHandler(this.shortcutButton_Click);
            // 
            // menuBarSeparator
            // 
            this.menuBarSeparator.Name = "menuBarSeparator";
            this.menuBarSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.progsListView);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.DoubleBuffered = true;
            this.Icon = Properties.Resources.icon;
            this.MainMenuStrip = this.menuBar;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = Localization.Strings.ProgramName;
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ListView progsListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader exeColumn;
        private System.Windows.Forms.ColumnHeader isoColumn;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripSeparator menuBarSeparator;
        private System.Windows.Forms.ImageList smallIcons;
        private System.Windows.Forms.ImageList largeIcons;
        private System.Windows.Forms.ToolStripButton addButton;
        private System.Windows.Forms.ToolStripButton startButton;
        private System.Windows.Forms.ToolStripButton editButton;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripDropDownButton listViewDisplayModeDropDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem detailsListViewMode;
        private System.Windows.Forms.ToolStripMenuItem listListViewMode;
        private System.Windows.Forms.ToolStripMenuItem smallIconsListViewMode;
        private System.Windows.Forms.ToolStripMenuItem largeIconsListViewMode;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem addMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel DTVersion;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel selectedDrive;
        private System.Windows.Forms.ToolStripButton shortcutButton;
    }
}