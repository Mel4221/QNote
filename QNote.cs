using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace QNote
{
    public partial class QNote : Form
    {
        public QNote()
        {
            InitializeComponent();
            this.InitComponents();

        }
        private void InitComponents()
        {
            RichTextBox box = this.InputBox;
            //box.Size = new Size(this.Width - 22, this.Height - 147);
            box.Size = new Size(this.Width - 22, this.Height - 100);
            this.Controls.Add(box);
        }
        private void Settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            new QNoteSettings().Show();
        }

        private void QNote_Resize(object sender, EventArgs e)
        {
            //width 22
            //height 147
            //this.InputBox = new Control()
            //{

            //};
            ////this.InputBox.Size.Height = this.Height - 147; 
            //this.Text = $"X{this.Width} Y{this.Height}";
            RichTextBox box = this.InputBox;
            //box.Size = new Size(this.Width - 22, this.Height - 147);
            box.Size = new Size(this.Width - 22, this.Height - 100);
            this.Controls.Add(box);
        }



        /// <summary>
        /// EXit the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewStatusBar_Click(object sender, EventArgs e)
        {
          switch(this.ViewStatusBar.Checked)
            {
                case true:
                    this.ViewStatusBar.Checked = false;
                    this.StatusBar.Visible = false; 
                    break;
                case false:
                    this.ViewStatusBar.Checked = true;
                    this.StatusBar.Visible = true;
                    break;

            }
        }
        private OpenFileDialog OpenFile;
        private void FileOpen_Click(object sender, EventArgs e)
        {
            this.OpenFile = new OpenFileDialog();
            this.OpenFile.Title = "Open File";
            this.OpenFile.Filter = "Text File|*.txt" + "|All Files|*.*";
            //this.OpenFile.Filter = "Word Documents|*.doc|Excel Worksheets|*.xls|PowerPoint Presentations|*.ppt" +
            // "|Office Files|*.doc;*.xls;*.ppt" +
            // "|All Files|*.*";
            this.OpenFile.ShowDialog();
            string[] data;
            data = File.Read
        }
    }
}
