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
            this.progListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createShortcutOnDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinToTaskbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuBarSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.progListContextMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            resources.ApplyResources(this.trayIcon, "trayIcon");
            // 
            // progsListView
            // 
            resources.ApplyResources(this.progsListView, "progsListView");
            this.progsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.exeColumn,
            this.isoColumn});
            this.progsListView.ContextMenuStrip = this.progListContextMenu;
            this.progsListView.FullRowSelect = true;
            this.progsListView.GridLines = true;
            this.progsListView.HideSelection = false;
            this.progsListView.LargeImageList = this.largeIcons;
            this.progsListView.MultiSelect = false;
            this.progsListView.Name = "progsListView";
            this.progsListView.SmallImageList = this.smallIcons;
            this.progsListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.progsListView.UseCompatibleStateImageBehavior = false;
            this.progsListView.View = System.Windows.Forms.View.Details;
            this.progsListView.SelectedIndexChanged += new System.EventHandler(this.gamesListView_SelectedIndexChanged);
            this.progsListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gamesListView_MouseDoubleClick);
            // 
            // nameColumn
            // 
            this.nameColumn.Tag = "Nom";
            resources.ApplyResources(this.nameColumn, "nameColumn");
            // 
            // exeColumn
            // 
            this.exeColumn.Tag = "Exe";
            resources.ApplyResources(this.exeColumn, "exeColumn");
            // 
            // isoColumn
            // 
            this.isoColumn.Tag = "Iso";
            resources.ApplyResources(this.isoColumn, "isoColumn");
            // 
            // progListContextMenu
            // 
            resources.ApplyResources(this.progListContextMenu, "progListContextMenu");
            this.progListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createShortcutOnDesktopToolStripMenuItem,
            this.pinToTaskbarToolStripMenuItem});
            this.progListContextMenu.Name = "progListContextMenu";
            // 
            // createShortcutOnDesktopToolStripMenuItem
            // 
            resources.ApplyResources(this.createShortcutOnDesktopToolStripMenuItem, "createShortcutOnDesktopToolStripMenuItem");
            this.createShortcutOnDesktopToolStripMenuItem.Name = "createShortcutOnDesktopToolStripMenuItem";
            this.createShortcutOnDesktopToolStripMenuItem.Click += new System.EventHandler(this.createShortcutOnDesktopToolStripMenuItem_Click);
            // 
            // pinToTaskbarToolStripMenuItem
            // 
            resources.ApplyResources(this.pinToTaskbarToolStripMenuItem, "pinToTaskbarToolStripMenuItem");
            this.pinToTaskbarToolStripMenuItem.Name = "pinToTaskbarToolStripMenuItem";
            this.pinToTaskbarToolStripMenuItem.Click += new System.EventHandler(this.pinToTaskbarToolStripMenuItem_Click);
            // 
            // largeIcons
            // 
            this.largeIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            resources.ApplyResources(this.largeIcons, "largeIcons");
            this.largeIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // smallIcons
            // 
            this.smallIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            resources.ApplyResources(this.smallIcons, "smallIcons");
            this.smallIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // statusBar
            // 
            resources.ApplyResources(this.statusBar, "statusBar");
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DTVersion,
            this.selectedDrive});
            this.statusBar.Name = "statusBar";
            this.statusBar.SizingGrip = false;
            // 
            // DTVersion
            // 
            resources.ApplyResources(this.DTVersion, "DTVersion");
            this.DTVersion.Name = "DTVersion";
            // 
            // selectedDrive
            // 
            resources.ApplyResources(this.selectedDrive, "selectedDrive");
            this.selectedDrive.Name = "selectedDrive";
            // 
            // menuBar
            // 
            resources.ApplyResources(this.menuBar, "menuBar");
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.aboutMenu});
            this.menuBar.Name = "menuBar";
            // 
            // fileMenu
            // 
            resources.ApplyResources(this.fileMenu, "fileMenu");
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuItem,
            this.optionsMenuItem,
            this.exitMenuItem});
            this.fileMenu.Name = "fileMenu";
            // 
            // addMenuItem
            // 
            resources.ApplyResources(this.addMenuItem, "addMenuItem");
            this.addMenuItem.Image = global::DTWrapper.GUI.Properties.Resources.add;
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.Click += new System.EventHandler(this.addMenuItem_Click);
            // 
            // optionsMenuItem
            // 
            resources.ApplyResources(this.optionsMenuItem, "optionsMenuItem");
            this.optionsMenuItem.Name = "optionsMenuItem";
            this.optionsMenuItem.Click += new System.EventHandler(this.optionsMenuItem_Click);
            // 
            // exitMenuItem
            // 
            resources.ApplyResources(this.exitMenuItem, "exitMenuItem");
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // aboutMenu
            // 
            resources.ApplyResources(this.aboutMenu, "aboutMenu");
            this.aboutMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutItem});
            this.aboutMenu.Name = "aboutMenu";
            // 
            // aboutItem
            // 
            resources.ApplyResources(this.aboutItem, "aboutItem");
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.Click += new System.EventHandler(this.aboutItem_Click);
            // 
            // toolBar
            // 
            resources.ApplyResources(this.toolBar, "toolBar");
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addButton,
            this.toolStripSeparator1,
            this.startButton,
            this.editButton,
            this.deleteButton,
            this.listViewDisplayModeDropDown});
            this.toolBar.Name = "toolBar";
            // 
            // addButton
            // 
            resources.ApplyResources(this.addButton, "addButton");
            this.addButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addButton.Image = global::DTWrapper.GUI.Properties.Resources.add;
            this.addButton.Name = "addButton";
            this.addButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startButton.Image = global::DTWrapper.GUI.Properties.Resources.play;
            this.startButton.Name = "startButton";
            this.startButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // editButton
            // 
            resources.ApplyResources(this.editButton, "editButton");
            this.editButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editButton.Image = global::DTWrapper.GUI.Properties.Resources.edit;
            this.editButton.Name = "editButton";
            this.editButton.Click += new System.EventHandler(this.editGameButton_Click);
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Image = global::DTWrapper.GUI.Properties.Resources.del;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Click += new System.EventHandler(this.deleteGameButton_Click);
            // 
            // listViewDisplayModeDropDown
            // 
            resources.ApplyResources(this.listViewDisplayModeDropDown, "listViewDisplayModeDropDown");
            this.listViewDisplayModeDropDown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.listViewDisplayModeDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listViewDisplayModeDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsListViewMode,
            this.listListViewMode,
            this.smallIconsListViewMode,
            this.largeIconsListViewMode});
            this.listViewDisplayModeDropDown.Image = global::DTWrapper.GUI.Properties.Resources.zoom;
            this.listViewDisplayModeDropDown.Name = "listViewDisplayModeDropDown";
            // 
            // detailsListViewMode
            // 
            resources.ApplyResources(this.detailsListViewMode, "detailsListViewMode");
            this.detailsListViewMode.Name = "detailsListViewMode";
            this.detailsListViewMode.Click += new System.EventHandler(this.detailsListViewMode_Click);
            // 
            // listListViewMode
            // 
            resources.ApplyResources(this.listListViewMode, "listListViewMode");
            this.listListViewMode.Name = "listListViewMode";
            this.listListViewMode.Click += new System.EventHandler(this.listListViewMode_Click);
            // 
            // smallIconsListViewMode
            // 
            resources.ApplyResources(this.smallIconsListViewMode, "smallIconsListViewMode");
            this.smallIconsListViewMode.Name = "smallIconsListViewMode";
            this.smallIconsListViewMode.Click += new System.EventHandler(this.smallIconsListViewMode_Click);
            // 
            // largeIconsListViewMode
            // 
            resources.ApplyResources(this.largeIconsListViewMode, "largeIconsListViewMode");
            this.largeIconsListViewMode.Name = "largeIconsListViewMode";
            this.largeIconsListViewMode.Click += new System.EventHandler(this.largeIconsListViewMode_Click);
            // 
            // menuBarSeparator
            // 
            resources.ApplyResources(this.menuBarSeparator, "menuBarSeparator");
            this.menuBarSeparator.Name = "menuBarSeparator";
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.progsListView);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuBar;
            this.Name = "MainWindow";
            this.progListContextMenu.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip progListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem createShortcutOnDesktopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinToTaskbarToolStripMenuItem;
    }
}