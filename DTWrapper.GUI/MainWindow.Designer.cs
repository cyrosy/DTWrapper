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
            this.gamesListView = new System.Windows.Forms.ListView();
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
            this.addGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.startMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.addGameButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.startGameButton = new System.Windows.Forms.ToolStripButton();
            this.editGameButton = new System.Windows.Forms.ToolStripButton();
            this.deleteGameButton = new System.Windows.Forms.ToolStripButton();
            this.listViewDisplayModeDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.detailsListViewMode = new System.Windows.Forms.ToolStripMenuItem();
            this.listListViewMode = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconsListViewMode = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconsListViewMode = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.statusBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            resources.ApplyResources(this.trayIcon, "trayIcon");
            // 
            // gamesListView
            // 
            this.gamesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.exeColumn,
            this.isoColumn});
            resources.ApplyResources(this.gamesListView, "gamesListView");
            this.gamesListView.FullRowSelect = true;
            this.gamesListView.GridLines = true;
            this.gamesListView.HideSelection = false;
            this.gamesListView.LargeImageList = this.largeIcons;
            this.gamesListView.MultiSelect = false;
            this.gamesListView.Name = "gamesListView";
            this.gamesListView.SmallImageList = this.smallIcons;
            this.gamesListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.gamesListView.UseCompatibleStateImageBehavior = false;
            this.gamesListView.View = System.Windows.Forms.View.Details;
            this.gamesListView.SelectedIndexChanged += new System.EventHandler(this.gamesListView_SelectedIndexChanged);
            this.gamesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gamesListView_MouseDoubleClick);
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
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DTVersion,
            this.selectedDrive});
            resources.ApplyResources(this.statusBar, "statusBar");
            this.statusBar.Name = "statusBar";
            this.statusBar.SizingGrip = false;
            // 
            // DTVersion
            // 
            this.DTVersion.Name = "DTVersion";
            resources.ApplyResources(this.DTVersion, "DTVersion");
            // 
            // selectedDrive
            // 
            this.selectedDrive.Name = "selectedDrive";
            resources.ApplyResources(this.selectedDrive, "selectedDrive");
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.gameMenu,
            this.aboutMenu});
            resources.ApplyResources(this.menuBar, "menuBar");
            this.menuBar.Name = "menuBar";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGameMenuItem,
            this.optionsMenuItem,
            this.exitMenuItem});
            this.fileMenu.Name = "fileMenu";
            resources.ApplyResources(this.fileMenu, "fileMenu");
            // 
            // addGameMenuItem
            // 
            this.addGameMenuItem.Image = global::DTWrapper.GUI.Properties.Resources.add;
            this.addGameMenuItem.Name = "addGameMenuItem";
            resources.ApplyResources(this.addGameMenuItem, "addGameMenuItem");
            this.addGameMenuItem.Click += new System.EventHandler(this.addGameMenuItem_Click);
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.Name = "optionsMenuItem";
            resources.ApplyResources(this.optionsMenuItem, "optionsMenuItem");
            this.optionsMenuItem.Click += new System.EventHandler(this.optionsMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            resources.ApplyResources(this.exitMenuItem, "exitMenuItem");
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // gameMenu
            // 
            this.gameMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startMenuItem,
            this.editMenuItem,
            this.deleteMenuItem});
            this.gameMenu.Name = "gameMenu";
            resources.ApplyResources(this.gameMenu, "gameMenu");
            // 
            // startMenuItem
            // 
            this.startMenuItem.Image = global::DTWrapper.GUI.Properties.Resources.play;
            this.startMenuItem.Name = "startMenuItem";
            resources.ApplyResources(this.startMenuItem, "startMenuItem");
            this.startMenuItem.Click += new System.EventHandler(this.startMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.Image = global::DTWrapper.GUI.Properties.Resources.edit;
            this.editMenuItem.Name = "editMenuItem";
            resources.ApplyResources(this.editMenuItem, "editMenuItem");
            this.editMenuItem.Click += new System.EventHandler(this.editMenuItem_Click);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Image = global::DTWrapper.GUI.Properties.Resources.del;
            this.deleteMenuItem.Name = "deleteMenuItem";
            resources.ApplyResources(this.deleteMenuItem, "deleteMenuItem");
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutItem});
            this.aboutMenu.Name = "aboutMenu";
            resources.ApplyResources(this.aboutMenu, "aboutMenu");
            // 
            // aboutItem
            // 
            this.aboutItem.Name = "aboutItem";
            resources.ApplyResources(this.aboutItem, "aboutItem");
            this.aboutItem.Click += new System.EventHandler(this.aboutItem_Click);
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGameButton,
            this.toolStripSeparator1,
            this.startGameButton,
            this.editGameButton,
            this.deleteGameButton,
            this.listViewDisplayModeDropDown});
            resources.ApplyResources(this.toolBar, "toolBar");
            this.toolBar.Name = "toolBar";
            // 
            // addGameButton
            // 
            this.addGameButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addGameButton.Image = global::DTWrapper.GUI.Properties.Resources.add;
            resources.ApplyResources(this.addGameButton, "addGameButton");
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // startGameButton
            // 
            this.startGameButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startGameButton.Image = global::DTWrapper.GUI.Properties.Resources.play;
            resources.ApplyResources(this.startGameButton, "startGameButton");
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // editGameButton
            // 
            this.editGameButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editGameButton.Image = global::DTWrapper.GUI.Properties.Resources.edit;
            resources.ApplyResources(this.editGameButton, "editGameButton");
            this.editGameButton.Name = "editGameButton";
            this.editGameButton.Click += new System.EventHandler(this.editGameButton_Click);
            // 
            // deleteGameButton
            // 
            this.deleteGameButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteGameButton.Image = global::DTWrapper.GUI.Properties.Resources.del;
            resources.ApplyResources(this.deleteGameButton, "deleteGameButton");
            this.deleteGameButton.Name = "deleteGameButton";
            this.deleteGameButton.Click += new System.EventHandler(this.deleteGameButton_Click);
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
            resources.ApplyResources(this.listViewDisplayModeDropDown, "listViewDisplayModeDropDown");
            this.listViewDisplayModeDropDown.Name = "listViewDisplayModeDropDown";
            // 
            // detailsListViewMode
            // 
            this.detailsListViewMode.Name = "detailsListViewMode";
            resources.ApplyResources(this.detailsListViewMode, "detailsListViewMode");
            this.detailsListViewMode.Click += new System.EventHandler(this.detailsListViewMode_Click);
            // 
            // listListViewMode
            // 
            this.listListViewMode.Name = "listListViewMode";
            resources.ApplyResources(this.listListViewMode, "listListViewMode");
            this.listListViewMode.Click += new System.EventHandler(this.listListViewMode_Click);
            // 
            // smallIconsListViewMode
            // 
            this.smallIconsListViewMode.Name = "smallIconsListViewMode";
            resources.ApplyResources(this.smallIconsListViewMode, "smallIconsListViewMode");
            this.smallIconsListViewMode.Click += new System.EventHandler(this.smallIconsListViewMode_Click);
            // 
            // largeIconsListViewMode
            // 
            this.largeIconsListViewMode.Name = "largeIconsListViewMode";
            resources.ApplyResources(this.largeIconsListViewMode, "largeIconsListViewMode");
            this.largeIconsListViewMode.Click += new System.EventHandler(this.largeIconsListViewMode_Click);
            // 
            // menuBarSeparator
            // 
            this.menuBarSeparator.Name = "menuBarSeparator";
            resources.ApplyResources(this.menuBarSeparator, "menuBarSeparator");
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.gamesListView);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuBar;
            this.Name = "MainWindow";
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
        private System.Windows.Forms.ListView gamesListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader exeColumn;
        private System.Windows.Forms.ColumnHeader isoColumn;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripSeparator menuBarSeparator;
        private System.Windows.Forms.ImageList smallIcons;
        private System.Windows.Forms.ImageList largeIcons;
        private System.Windows.Forms.ToolStripButton addGameButton;
        private System.Windows.Forms.ToolStripButton startGameButton;
        private System.Windows.Forms.ToolStripButton editGameButton;
        private System.Windows.Forms.ToolStripButton deleteGameButton;
        private System.Windows.Forms.ToolStripDropDownButton listViewDisplayModeDropDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem detailsListViewMode;
        private System.Windows.Forms.ToolStripMenuItem listListViewMode;
        private System.Windows.Forms.ToolStripMenuItem smallIconsListViewMode;
        private System.Windows.Forms.ToolStripMenuItem largeIconsListViewMode;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem addGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameMenu;
        private System.Windows.Forms.ToolStripMenuItem startMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel DTVersion;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel selectedDrive;
    }
}