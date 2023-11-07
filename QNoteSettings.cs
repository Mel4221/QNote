using QuickTools.QData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QNote
{
    public partial class QNoteSettings : Form
    {
        //public QNote _QNote;
        private ColorDialog FontColorDialog = new ColorDialog();
        private ColorDialog BackgroundColorDialog = new ColorDialog();
        private FontDialog FontDialog = new FontDialog();
        private bool _FontChanged { get; set; } = false;
        private bool _BackgroundColorChanged { get; set; } = false;
        private bool _FontColorChanged { get; set; } = false;

      
        public readonly string SettingsFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "QNote.settings");
        private static KeyManager SettingsManagear { get; set; }
        
        private void LaodSettings()
        {
            SettingsManagear = new KeyManager(SettingsFile); 
            SettingsManagear.Create();
            SettingsManagear.LoadKeys();
            if(SettingsManagear.Keys.Count > 0)
            {
                

                SettingFontType.Font = new Font(Get("Font"), float.Parse(Get("FontSize")), FontStyle.Regular);
                SettingFontType.Text = $"{SettingFontType.Font.Name} {SettingFontType.Font.Size}";
                SettingFontColor.BackColor = Color.FromName(Get("FontColor"));
                SettingBackgroundColor.BackColor = Color.FromName(Get("BackgroundColor"));


            }

        }


        private static string Get(string setting)
        {
            SettingsManagear = new KeyManager(new QNoteSettings().SettingsFile);
            SettingsManagear.Create();
            SettingsManagear.LoadKeys();
            return SettingsManagear.GetKey(setting).Value; 
        }

        private static void Update(string setting,string value)
        {
            SettingsManagear = new KeyManager(new QNoteSettings().SettingsFile);
            SettingsManagear.Create();
            SettingsManagear.LoadKeys();
            SettingsManagear.UpdateKey(new Key() {Name=setting,Value=value,IsEmpty=false});
            SettingsManagear.SaveKeys();
            GC.Collect();
        }

        public static void ResetToDefaultSettings()
        {
            SettingsManagear = new KeyManager(new QNoteSettings().SettingsFile);
            SettingsManagear.Drop();
            SettingsManagear.CheckForNotRepetedKeys = true; 
            GC.Collect();
            SettingsManagear.AddKey(new Key()
            { 
                    Name="Font",
                    Value="Microsoft Sans Serif",
                    IsEmpty = false
            });
            SettingsManagear.AddKey(new Key()
            {
                Name="Style",
                Value="regular",
                IsEmpty = false
            });
            SettingsManagear.AddKey(new Key()
            {
                Name="FontSize",
                Value="12",
                IsEmpty = false
            });
            SettingsManagear.AddKey(new Key()
            {
                Name="FontColor",
                Value="Lime",
                IsEmpty = false
            });
            SettingsManagear.AddKey(new Key()
            {
                Name="BackgroundColor",
                Value="black",
                IsEmpty = false
            });
            SettingsManagear.WriteKeys(new QNoteSettings().SettingsFile, SettingsManagear.Keys); 
           

        }
       
        public QNoteSettings()
        {
            InitializeComponent();
        }
        private void LoadComponent()
        {
             LaodSettings();
            //SettingFontType.Text = $"{this._QNote.InputBox.Font.Name}";
            //SettingFontColor.BackColor = this._QNote.InputBox.ForeColor;
            //SettingBackgroundColor.BackColor = this._QNote.InputBox.BackColor;
        }
        
         private void SaveSetting_Click(object sender, EventArgs e)
        {

            if (_FontChanged)
            {
                Update("Font",this.FontDialog.Font.Name);
                Update("FontSize", this.FontDialog.Font.Size.ToString());  

            }
            if (_FontColorChanged)
            {
                //this._QNote.InputBox.ForeColor = this.ColorDialog.Color; 
                Update("FontColor", this.FontColorDialog.Color.Name);

            }
            if (_BackgroundColorChanged)
            {
                //this._QNote.InputBox.BackColor = this.ColorDialog.Color;
                Update("BackgroundColor", this.BackgroundColorDialog.Color.Name);
            }
            QNote.Reload = true;
            this.Close();


        }

        private void CancellSetting_Click(object sender, EventArgs e)
        {
            QNote.Reload = true;
            this.Close();
            
        }


        private void SettingFontType_Click(object sender, EventArgs e)
        {
            DialogResult result =   FontDialog.ShowDialog();
            this.SettingFontType.Font = FontDialog.Font;
            if (result == DialogResult.OK)
            {
                _FontChanged = true;
                //MessageBox.Show($"Font: {FontDialog.Font.Name} Size: {FontDialog.Font.Size} Color: {FontDialog}");
            }
        }

        private void QNoteSettings_Load(object sender, EventArgs e)
        {
            LoadComponent();
        }

        private void SettingBackgroundColor_Click(object sender, EventArgs e)
        {
            DialogResult result = BackgroundColorDialog.ShowDialog();
            this.SettingBackgroundColor.BackColor = BackgroundColorDialog.Color;
            if (result == DialogResult.OK)
            {
                _BackgroundColorChanged = true;
            }
        }

        private void SettingFontColor_Click(object sender, EventArgs e)
        {
            DialogResult result = this.FontColorDialog.ShowDialog();
            this.SettingFontColor.BackColor = this.FontColorDialog.Color; 
            if(result == DialogResult.OK)
            {
                _FontColorChanged = true;
            }
        }

        private void SettingResetToDefault_Click(object sender, EventArgs e)
        {
            ResetToDefaultSettings();
            LaodSettings();
        }
    }
}