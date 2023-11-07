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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SettingsBox = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingFontType = new System.Windows.Forms.Button();
            this.SettingBackgroundColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SettingFontColor = new System.Windows.Forms.Button();
            this.SettingResetToDefault = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SettingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveSetting
            // 
            this.SaveSetting.Location = new System.Drawing.Point(838, 606);
            this.SaveSetting.Name = "SaveSetting";
            this.SaveSetting.Size = new System.Drawing.Size(114, 58);
            this.SaveSetting.TabIndex = 0;
            this.SaveSetting.Text = "Save";
            this.SaveSetting.UseVisualStyleBackColor = true;
            this.SaveSetting.Click += new System.EventHandler(this.SaveSetting_Click);
            // 
            // CancellSetting
            // 
            this.CancellSetting.Location = new System.Drawing.Point(707, 606);
            this.CancellSetting.Name = "CancellSetting";
            this.CancellSetting.Size = new System.Drawing.Size(114, 58);
            this.CancellSetting.TabIndex = 1;
            this.CancellSetting.Text = "Cancell";
            this.CancellSetting.UseVisualStyleBackColor = true;
            this.CancellSetting.Click += new System.EventHandler(this.CancellSetting_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SettingsBox);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 569);
            this.tabControl1.TabIndex = 2;
            // 
            // SettingsBox
            // 
            this.SettingsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.SettingsBox.Controls.Add(this.SettingFontColor);
            this.SettingsBox.Controls.Add(this.label3);
            this.SettingsBox.Controls.Add(this.label2);
            this.SettingsBox.Controls.Add(this.SettingBackgroundColor);
            this.SettingsBox.Controls.Add(this.label1);
            this.SettingsBox.Controls.Add(this.SettingFontType);
            this.SettingsBox.Location = new System.Drawing.Point(4, 29);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsBox.Size = new System.Drawing.Size(944, 536);
            this.SettingsBox.TabIndex = 1;
            this.SettingsBox.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font";
            // 
            // SettingFontType
            // 
            this.SettingFontType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingFontType.Location = new System.Drawing.Point(274, 32);
            this.SettingFontType.Name = "SettingFontType";
            this.SettingFontType.Size = new System.Drawing.Size(623, 69);
            this.SettingFontType.TabIndex = 0;
            this.SettingFontType.UseVisualStyleBackColor = true;
            this.SettingFontType.Click += new System.EventHandler(this.SettingFontType_Click);
            // 
            // SettingBackgroundColor
            // 
            this.SettingBackgroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingBackgroundColor.Location = new System.Drawing.Point(274, 202);
            this.SettingBackgroundColor.Name = "SettingBackgroundColor";
            this.SettingBackgroundColor.Size = new System.Drawing.Size(623, 69);
            this.SettingBackgroundColor.TabIndex = 2;
            this.SettingBackgroundColor.UseVisualStyleBackColor = true;
            this.SettingBackgroundColor.Click += new System.EventHandler(this.SettingBackgroundColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Background Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Font Color";
            // 
            // SettingFontColor
            // 
            this.SettingFontColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingFontColor.Location = new System.Drawing.Point(274, 114);
            this.SettingFontColor.Name = "SettingFontColor";
            this.SettingFontColor.Size = new System.Drawing.Size(623, 69);
            this.SettingFontColor.TabIndex = 5;
            this.SettingFontColor.UseVisualStyleBackColor = true;
            this.SettingFontColor.Click += new System.EventHandler(this.SettingFontColor_Click);
            // 
            // SettingResetToDefault
            // 
            this.SettingResetToDefault.Location = new System.Drawing.Point(30, 606);
            this.SettingResetToDefault.Name = "SettingResetToDefault";
            this.SettingResetToDefault.Size = new System.Drawing.Size(98, 58);
            this.SettingResetToDefault.TabIndex = 3;
            this.SettingResetToDefault.Text = "Default";
            this.SettingResetToDefault.UseVisualStyleBackColor = true;
            this.SettingResetToDefault.Click += new System.EventHandler(this.SettingResetToDefault_Click);
            // 
            // QNoteSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 676);
            this.Controls.Add(this.SettingResetToDefault);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CancellSetting);
            this.Controls.Add(this.SaveSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QNoteSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.QNoteSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.SettingsBox.ResumeLayout(false);
            this.SettingsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveSetting;
        private System.Windows.Forms.Button CancellSetting;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SettingsBox;
        private System.Windows.Forms.Button SettingFontType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SettingBackgroundColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SettingFontColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SettingResetToDefault;
    }
}