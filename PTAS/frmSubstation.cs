﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PTAS
{
    public partial class frmSubstation : Form
    {
        public frmSubstation()
        {
            InitializeComponent();
        }

        private void frmSubstation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtbPTASDataSet.tblSubstation' table. You can move, or remove it, as needed.
            this.tblSubstationTableAdapter.Fill(this.dtbPTASDataSet.tblSubstation);
        }

        private void frmSubstation_FormClosed(object sender, FormClosedEventArgs e)
        {
            //frmMain form = new frmMain();
            //form.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.tblSubstationBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Validate();
                tblSubstationBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dtbPTASDataSet);

                MessageBox.Show("Record saved.");
            }
            else
                this.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to delete this record?", "Delete record", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                tblSubstationBindingSource.RemoveCurrent();
                MessageBox.Show("Record deleted.");
            }
            else
                this.Focus();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.Show();
            Close();
        }

        private void frmSubstation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tblSubstationBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tblSubstationBindingSource.MoveNext();
        }
    }
}
