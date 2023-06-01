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
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            new QNoteSettings().Show();
        }
    }
}
