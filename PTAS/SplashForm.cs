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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private string _StatusInfo;

        public string StatusInfo
        {
            set
            {
                _StatusInfo = value;
                ChangeStatusText();
            }
            get
            {
                return _StatusInfo;
            }
        }
        
        public void ChangeStatusText()
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(ChangeStatusText));
                    return;
                }

                lStatusInfo.Text = _StatusInfo;
            }
            catch(Exception e)
            {
                string hash = e.GetHashCode().ToString();
                MessageBox.Show("Exception occured: " + hash);
            }
        }
    }
}
