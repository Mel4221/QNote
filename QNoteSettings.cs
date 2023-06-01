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
    public partial class QNoteSettings : Form
    {
        public QNoteSettings()
        {
            InitializeComponent();
        }

        private void SaveSetting_Click(object sender, EventArgs e)
        {
            this.Close();
            new QNote().Show(); 
        }

        private void CancellSetting_Click(object sender, EventArgs e)
        {
            this.Close();
            new QNote().Show();
        }
    }
}
