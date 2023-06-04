using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
