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
            this.QFile = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.FilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.EditUndu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.EditFind = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDate = new System.Windows.Forms.ToolStripMenuItem();
            this.EditFont = new System.Windows.Forms.ToolStripMenuItem();
            this.Views = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewSoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewZoomReset = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.InputBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.InputBox = new System.Windows.Forms.RichTextBox();
            this.StatusBar = new System.Windows.Forms.ToolStrip();
            this.LCStatus = new System.Windows.Forms.ToolStripLabel();
            this.UnicodeType = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.ZoomStatus = new System.Windows.Forms.ToolStripLabel();
            this.Options.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Options
            // 
            this.Options.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Options.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QFile,
            this.Edit,
            this.Views,
            this.Settings,
            this.InputBoxFind});
            this.Options.Location = new System.Drawing.Point(0, 0);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(1059, 33);
            this.Options.TabIndex = 0;
            this.Options.Text = "Options";
            // 
            // QFile
            // 
            this.QFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileOpen,
            this.FileSave,
            this.FileSaveAs,
            this.FilePrint,
            this.FileExit});
            this.QFile.Name = "QFile";
            this.QFile.Size = new System.Drawing.Size(54, 29);
            this.QFile.Text = "File";
            // 
            // FileOpen
            // 
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.Size = new System.Drawing.Size(176, 34);
            this.FileOpen.Text = "Open";
            this.FileOpen.Click += new System.EventHandler(this.FileOpen_Click);
            // 
            // FileSave
            // 
            this.FileSave.Name = "FileSave";
            this.FileSave.Size = new System.Drawing.Size(176, 34);
            this.FileSave.Text = "Save";
            this.FileSave.Click += new System.EventHandler(this.FileSave_Click);
            // 
            // FileSaveAs
            // 
            this.FileSaveAs.Name = "FileSaveAs";
            this.FileSaveAs.Size = new System.Drawing.Size(176, 34);
            this.FileSaveAs.Text = "Save As";
            this.FileSaveAs.Click += new System.EventHandler(this.FileSaveAs_Click);
            // 
            // FilePrint
            // 
            this.FilePrint.Name = "FilePrint";
            this.FilePrint.Size = new System.Drawing.Size(176, 34);
            this.FilePrint.Text = "Print";
            this.FilePrint.Click += new System.EventHandler(this.FilePrint_Click);
            // 
            // FileExit
            // 
            this.FileExit.Name = "FileExit";
            this.FileExit.Size = new System.Drawing.Size(176, 34);
            this.FileExit.Text = "Exit";
            this.FileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // Edit
            // 
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditUndu,
            this.EditCut,
            this.EditCopy,
            this.EditPaste,
            this.EditDelete,
            this.EditFind,
            this.EditDate,
            this.EditFont});
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(58, 29);
            this.Edit.Text = "Edit";
            // 
            // EditUndu
            // 
            this.EditUndu.Name = "EditUndu";
            this.EditUndu.Size = new System.Drawing.Size(206, 34);
            this.EditUndu.Text = "Undu";
            this.EditUndu.Click += new System.EventHandler(this.EditUndu_Click);
            // 
            // EditCut
            // 
            this.EditCut.Name = "EditCut";
            this.EditCut.Size = new System.Drawing.Size(206, 34);
            this.EditCut.Text = "Cut";
            // 
            // EditCopy
            // 
            this.EditCopy.Name = "EditCopy";
            this.EditCopy.Size = new System.Drawing.Size(206, 34);
            this.EditCopy.Text = "Copy";
            this.EditCopy.Click += new System.EventHandler(this.EditCopy_Click);
            // 
            // EditPaste
            // 
            this.EditPaste.Name = "EditPaste";
            this.EditPaste.Size = new System.Drawing.Size(206, 34);
            this.EditPaste.Text = "Paste";
            this.EditPaste.Click += new System.EventHandler(this.EditPaste_Click);
            // 
            // EditDelete
            // 
            this.EditDelete.Name = "EditDelete";
            this.EditDelete.Size = new System.Drawing.Size(206, 34);
            this.EditDelete.Text = "Delete";
            this.EditDelete.Click += new System.EventHandler(this.EditDelete_Click);
            // 
            // EditFind
            // 
            this.EditFind.Name = "EditFind";
            this.EditFind.Size = new System.Drawing.Size(206, 34);
            this.EditFind.Text = "Find";
            this.EditFind.Click += new System.EventHandler(this.EditFind_Click);
            // 
            // EditDate
            // 
            this.EditDate.Name = "EditDate";
            this.EditDate.Size = new System.Drawing.Size(206, 34);
            this.EditDate.Text = "Time / Date";
            this.EditDate.Click += new System.EventHandler(this.EditDate_Click);
            // 
            // EditFont
            // 
            this.EditFont.Name = "EditFont";
            this.EditFont.Size = new System.Drawing.Size(206, 34);
            this.EditFont.Text = "Font";
            // 
            // Views
            // 
            this.Views.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewZoom,
            this.ViewStatusBar});
            this.Views.Name = "Views";
            this.Views.Size = new System.Drawing.Size(65, 29);
            this.Views.Text = "View";
            // 
            // ViewZoom
            // 
            this.ViewZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewSoomIn,
            this.ViewZoomOut,
            this.ViewZoomReset});
            this.ViewZoom.Name = "ViewZoom";
            this.ViewZoom.Size = new System.Drawing.Size(270, 34);
            this.ViewZoom.Text = "Zoom";
            // 
            // ViewSoomIn
            // 
            this.ViewSoomIn.Name = "ViewSoomIn";
            this.ViewSoomIn.Size = new System.Drawing.Size(288, 34);
            this.ViewSoomIn.Text = "Zoom In";
            this.ViewSoomIn.Click += new System.EventHandler(this.ViewSoomIn_Click);
            // 
            // ViewZoomOut
            // 
            this.ViewZoomOut.Name = "ViewZoomOut";
            this.ViewZoomOut.Size = new System.Drawing.Size(288, 34);
            this.ViewZoomOut.Text = "Zoom Out";
            this.ViewZoomOut.Click += new System.EventHandler(this.ViewZoomOut_Click);
            // 
            // ViewZoomReset
            // 
            this.ViewZoomReset.Name = "ViewZoomReset";
            this.ViewZoomReset.Size = new System.Drawing.Size(288, 34);
            this.ViewZoomReset.Text = "Restore Default Zoom";
            this.ViewZoomReset.Click += new System.EventHandler(this.ViewZoomReset_Click);
            // 
            // ViewStatusBar
            // 
            this.ViewStatusBar.Checked = true;
            this.ViewStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ViewStatusBar.Name = "ViewStatusBar";
            this.ViewStatusBar.Size = new System.Drawing.Size(270, 34);
            this.ViewStatusBar.Text = "Status Bar";
            this.ViewStatusBar.Click += new System.EventHandler(this.ViewStatusBar_Click);
            // 
            // Settings
            // 
            this.Settings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(40, 29);
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // InputBoxFind
            // 
            this.InputBoxFind.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBoxFind.Name = "InputBoxFind";
            this.InputBoxFind.Size = new System.Drawing.Size(400, 37);
            this.InputBoxFind.Visible = false;
            this.InputBoxFind.Leave += new System.EventHandler(this.InputBoxFind_Leave);
            this.InputBoxFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBoxFind_KeyDown);
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.Black;
            this.InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.ForeColor = System.Drawing.Color.Lime;
            this.InputBox.Location = new System.Drawing.Point(0, 50);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(1059, 558);
            this.InputBox.TabIndex = 1;
            this.InputBox.TabStop = false;
            this.InputBox.Text = "";
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown);
            // 
            // StatusBar
            // 
            this.StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LCStatus,
            this.UnicodeType,
            this.toolStripLabel3,
            this.ZoomStatus});
            this.StatusBar.Location = new System.Drawing.Point(0, 619);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1059, 30);
            this.StatusBar.TabIndex = 2;
            // 
            // LCStatus
            // 
            this.LCStatus.Name = "LCStatus";
            this.LCStatus.Size = new System.Drawing.Size(95, 25);
            this.LCStatus.Text = "Ln 0, Col 0";
            // 
            // UnicodeType
            // 
            this.UnicodeType.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UnicodeType.Margin = new System.Windows.Forms.Padding(5, 5, 50, 0);
            this.UnicodeType.Name = "UnicodeType";
            this.UnicodeType.Size = new System.Drawing.Size(59, 25);
            this.UnicodeType.Text = "UTF-8";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Margin = new System.Windows.Forms.Padding(50, 2, 50, 3);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(140, 25);
            this.toolStripLabel3.Text = "Windows (CRLF)";
            // 
            // ZoomStatus
            // 
            this.ZoomStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ZoomStatus.Name = "ZoomStatus";
            this.ZoomStatus.Size = new System.Drawing.Size(57, 25);
            this.ZoomStatus.Text = "100%";
            // 
            // QNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 649);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.Options);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Options;
            this.Name = "QNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QNote";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QNote_KeyDown);
            this.Resize += new System.EventHandler(this.QNote_Resize);
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Options;
        private System.Windows.Forms.ToolStripMenuItem QFile;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Views;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.RichTextBox InputBox;
        private System.Windows.Forms.ToolStrip StatusBar;
        private System.Windows.Forms.ToolStripLabel LCStatus;
        private System.Windows.Forms.ToolStripLabel ZoomStatus;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel UnicodeType;
        private System.Windows.Forms.ToolStripMenuItem FileOpen;
        private System.Windows.Forms.ToolStripMenuItem FileSave;
        private System.Windows.Forms.ToolStripMenuItem FileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem FilePrint;
        private System.Windows.Forms.ToolStripMenuItem FileExit;
        private System.Windows.Forms.ToolStripMenuItem EditUndu;
        private System.Windows.Forms.ToolStripMenuItem EditCut;
        private System.Windows.Forms.ToolStripMenuItem EditCopy;
        private System.Windows.Forms.ToolStripMenuItem EditPaste;
        private System.Windows.Forms.ToolStripMenuItem EditDelete;
        private System.Windows.Forms.ToolStripMenuItem EditFind;
        private System.Windows.Forms.ToolStripMenuItem EditDate;
        private System.Windows.Forms.ToolStripMenuItem EditFont;
        private System.Windows.Forms.ToolStripMenuItem ViewZoom;
        private System.Windows.Forms.ToolStripMenuItem ViewSoomIn;
        private System.Windows.Forms.ToolStripMenuItem ViewZoomOut;
        private System.Windows.Forms.ToolStripMenuItem ViewZoomReset;
        private System.Windows.Forms.ToolStripMenuItem ViewStatusBar;
        private System.Windows.Forms.ToolStripTextBox InputBoxFind;
    }
}

