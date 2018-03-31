using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PTAS
{
    public partial class frmXformer : Form
    {
        public frmXformer()
        {
            InitializeComponent();
        }

        private void frmXformer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtbPTASDataSet.tblSubstation' table. You can move, or remove it, as needed.
            this.tblSubstationTableAdapter.Fill(this.dtbPTASDataSet.tblSubstation);
            // TODO: This line of code loads data into the 'dtbPTASDataSet.tblTransformer' table. You can move, or remove it, as needed.
            this.tblTransformerTableAdapter.Fill(this.dtbPTASDataSet.tblTransformer);

        }
        
        private void frmXformer_FormClosed(object sender, FormClosedEventArgs e)
        {
            //frmMain form = new frmMain();
            //form.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tblTransformerBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Validate();
                tblTransformerBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dtbPTASDataSet);
                
                MessageBox.Show("Record saved.");
            }
            else
                Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to delete this record?", "Delete record", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                tblTransformerBindingSource.RemoveCurrent();
                MessageBox.Show("Record deleted.");
            }
                
            else
                Focus();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tblTransformerBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tblTransformerBindingSource.MoveNext();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.Show();
            Close();
        }

        private void frmXformer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}
