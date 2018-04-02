using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTAS
{
    public partial class frmMessage : Form
    {
        public frmMessage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();
            Close();
        }

        private void frmMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}
