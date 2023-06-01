namespace QNote
{
    partial class QNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QNote));
            this.Options = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Views = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.InputBox = new System.Windows.Forms.RichTextBox();
            this.Status = new System.Windows.Forms.ToolStrip();
            this.LCStatus = new System.Windows.Forms.ToolStripLabel();
            this.ZoomStatus = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.UnicodeType = new System.Windows.Forms.ToolStripLabel();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBArToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Options.SuspendLayout();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // Options
            // 
            this.Options.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Options.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Edit,
            this.Views,
            this.Settings});
            this.Options.Location = new System.Drawing.Point(0, 0);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(1059, 33);
            this.Options.TabIndex = 0;
            this.Options.Text = "Options";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(54, 29);
            this.File.Text = "File";
            // 
            // Edit
            // 
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unduToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.findToolStripMenuItem,
            this.findNextToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(58, 29);
            this.Edit.Text = "Edit";
            // 
            // Views
            // 
            this.Views.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.statusBArToolStripMenuItem});
            this.Views.Name = "Views";
            this.Views.Size = new System.Drawing.Size(65, 29);
            this.Views.Text = "View";
            // 
            // Settings
            // 
            this.Settings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(40, 29);
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(0, 50);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(1059, 558);
            this.InputBox.TabIndex = 1;
            this.InputBox.TabStop = false;
            this.InputBox.Text = "";
            // 
            // Status
            // 
            this.Status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Status.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LCStatus,
            this.UnicodeType,
            this.toolStripLabel3,
            this.ZoomStatus});
            this.Status.Location = new System.Drawing.Point(0, 619);
            this.Status.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(1059, 30);
            this.Status.TabIndex = 2;
            // 
            // LCStatus
            // 
            this.LCStatus.Name = "LCStatus";
            this.LCStatus.Size = new System.Drawing.Size(95, 25);
            this.LCStatus.Text = "Ln 0, Col 0";
            // 
            // ZoomStatus
            // 
            this.ZoomStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ZoomStatus.Name = "ZoomStatus";
            this.ZoomStatus.Size = new System.Drawing.Size(57, 25);
            this.ZoomStatus.Text = "100%";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Margin = new System.Windows.Forms.Padding(50, 2, 50, 3);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(140, 25);
            this.toolStripLabel3.Text = "Windows (CRLF)";
            // 
            // UnicodeType
            // 
            this.UnicodeType.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UnicodeType.Margin = new System.Windows.Forms.Padding(5, 5, 50, 0);
            this.UnicodeType.Name = "UnicodeType";
            this.UnicodeType.Size = new System.Drawing.Size(59, 25);
            this.UnicodeType.Text = "UTF-8";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // unduToolStripMenuItem
            // 
            this.unduToolStripMenuItem.Name = "unduToolStripMenuItem";
            this.unduToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.unduToolStripMenuItem.Text = "Undu";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // findNextToolStripMenuItem
            // 
            this.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            this.findNextToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.findNextToolStripMenuItem.Text = "Time / Date";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(288, 34);
            this.resetToolStripMenuItem.Text = "Restore Default Zoom";
            // 
            // statusBArToolStripMenuItem
            // 
            this.statusBArToolStripMenuItem.Checked = true;
            this.statusBArToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBArToolStripMenuItem.Name = "statusBArToolStripMenuItem";
            this.statusBArToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.statusBArToolStripMenuItem.Text = "Status Bar";
            // 
            // QNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 649);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.Options);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Options;
            this.Name = "QNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QNote";
            this.Resize += new System.EventHandler(this.QNote_Resize);
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Options;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Views;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.RichTextBox InputBox;
        private System.Windows.Forms.ToolStrip Status;
        private System.Windows.Forms.ToolStripLabel LCStatus;
        private System.Windows.Forms.ToolStripLabel ZoomStatus;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel UnicodeType;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unduToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBArToolStripMenuItem;
    }
}

