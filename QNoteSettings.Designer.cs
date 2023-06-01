namespace QNote
{
    partial class QNoteSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QNoteSettings));
            this.SaveSetting = new System.Windows.Forms.Button();
            this.CancellSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveSetting
            // 
            this.SaveSetting.Location = new System.Drawing.Point(898, 587);
            this.SaveSetting.Name = "SaveSetting";
            this.SaveSetting.Size = new System.Drawing.Size(114, 58);
            this.SaveSetting.TabIndex = 0;
            this.SaveSetting.Text = "Save";
            this.SaveSetting.UseVisualStyleBackColor = true;
            this.SaveSetting.Click += new System.EventHandler(this.SaveSetting_Click);
            // 
            // CancellSetting
            // 
            this.CancellSetting.Location = new System.Drawing.Point(767, 587);
            this.CancellSetting.Name = "CancellSetting";
            this.CancellSetting.Size = new System.Drawing.Size(114, 58);
            this.CancellSetting.TabIndex = 1;
            this.CancellSetting.Text = "Cancell";
            this.CancellSetting.UseVisualStyleBackColor = true;
            this.CancellSetting.Click += new System.EventHandler(this.CancellSetting_Click);
            // 
            // QNoteSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 676);
            this.Controls.Add(this.CancellSetting);
            this.Controls.Add(this.SaveSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QNoteSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveSetting;
        private System.Windows.Forms.Button CancellSetting;
    }
}