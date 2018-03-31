using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PTAS
{
    public partial class frmWinding : Form
    {
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dtbPTAS.mdf;Integrated Security=True";
        string TestData;

        public frmWinding()
        {
            InitializeComponent();
            //frmMain.OnDataChanged += FrmMain_OnDataChanged;
            //frmMain.OnPassTestNumber += FrmMain_OnPassTestNumber;
        }

        //private void FrmMain_OnPassTestNumber(string TestNumber)
        //{
        //    TestData = TestNumber;
        //    frmMain.OnPassTestNumber -= FrmMain_OnPassTestNumber;
        //}

        //private void FrmMain_OnDataChanged(string TestNumber)
        //{
        //    string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
        //    string path = (System.IO.Path.GetDirectoryName(executable));
        //    AppDomain.CurrentDomain.SetData("Data Directory", path);

        //    string query = "SELECT COUNT (*) FROM tblWinding WHERE TestNumber = @testnumber";
        //    using (SqlConnection con = new SqlConnection(constring))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            cmd.Parameters.AddWithValue("@testnumber", TestNumber);
        //            con.Open();
        //            int record = Convert.ToInt32(cmd.ExecuteScalar());

        //            if (record == 1)
        //            {
        //                string query2 = "SELECT * FROM tblWinding WHERE TestNumber = @testnumber";
        //                using (SqlCommand cmd2 = new SqlCommand(query2, con))
        //                {
        //                    cmd2.Parameters.AddWithValue("@testnumber", TestNumber);
        //                    SqlDataReader dr = cmd2.ExecuteReader();

        //                    while (dr.Read())
        //                    {
        //                        testNumberTextBox.Text = (dr["TestNumber"].ToString());
        //                        windPrimATextBox.Text = (dr["windPrimA"].ToString());
        //                        windPrimBTextBox.Text = (dr["windPrimB"].ToString());
        //                        windPrimCTextBox.Text = (dr["windPrimC"].ToString());
        //                        windSecATextBox.Text = (dr["windSecA"].ToString());
        //                        windSecBTextBox.Text = (dr["windSecB"].ToString());
        //                        windSecCTextBox.Text = (dr["windSecC"].ToString());
        //                        windTertATextBox.Text = (dr["windTertA"].ToString());
        //                        windTertBTextBox.Text = (dr["windTertB"].ToString());
        //                        windTertCTextBox.Text = (dr["windTertC"].ToString());
        //                    }
        //                }
        //            }
        //            con.Close();
        //        }
        //    }
        //    //frmMain.OnDataChanged -= FrmMain_OnDataChanged;
        //}

        private void frmWinding_Load(object sender, EventArgs e)
        {
            this.tblWindingTableAdapter.Fill(this.dtbPTASDataSet.tblWinding);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tblWindingBindingSource.AddNew();
            testNumberTextBox.Text = TestData;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "INSERT INTO tblWinding (TestNumber, windPrimA, windPrimB, windPrimC, windSecA, windSecB, windSecC, windTertA, windTertB, windTertC) " +
                "VALUES (@testnumber, @prima, @primb, @primc, @seca, @secb, @secc, @terta, @tertb, @tertc)";

            DataSet ds = dtbPTASDataSet;

            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);
                        cmd.Parameters.AddWithValue("@prima", windPrimATextBox.Text);
                        cmd.Parameters.AddWithValue("@primb", windPrimBTextBox.Text);
                        cmd.Parameters.AddWithValue("@primc", windPrimCTextBox.Text);
                        cmd.Parameters.AddWithValue("@seca", windSecATextBox.Text);
                        cmd.Parameters.AddWithValue("@secb", windSecBTextBox.Text);
                        cmd.Parameters.AddWithValue("@secc", windSecCTextBox.Text);
                        cmd.Parameters.AddWithValue("@terta", windTertATextBox.Text);
                        cmd.Parameters.AddWithValue("@tertb", windTertBTextBox.Text);
                        cmd.Parameters.AddWithValue("@tertc", windTertCTextBox.Text);

                        con.Open();

                        try
                        {
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record saved.");

                            ds.Clear();
                            tblWindingTableAdapter.Fill(dtbPTASDataSet.tblWinding);
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        con.Close();
                    }
                }
            }
            else
                this.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "DELETE FROM tblWinding WHERE TestNumber = @testnumber";
            DataSet ds = dtbPTASDataSet;

            DialogResult dr = MessageBox.Show("Do you wish to delete this record? This action cannot be undone.", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);
                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record deleted.");

                            ds.Clear();
                            tblWindingTableAdapter.Fill(dtbPTASDataSet.tblWinding);
                        }
                        catch
                        {
                            MessageBox.Show("An error has occurred.");
                        }
                        con.Close();
                    }
                }
            }
            else
                Focus();
        }

        private void btnAssess_Click(object sender, EventArgs e)
        {
            float highave, lowave, tertave;
            float[] high = new float[3];
            float[] low = new float[3];
            float[] tert = new float[3];

            float[] highdiff = new float[3];
            float[] lowdiff = new float[3];
            float[] tertdiff = new float[3];

            var hv = grpHV.Controls.OfType<TextBox>().ToArray();
            var lv = grpLV.Controls.OfType<TextBox>().ToArray();
            var tv = grpTV.Controls.OfType<TextBox>().ToArray();

            for(int i = 0; i < 3; i++)
            {
                float.TryParse(hv[i].Text, out high[i]);
                float.TryParse(lv[i].Text, out low[i]);
                float.TryParse(tv[i].Text, out tert[i]);
            }

            float sumhigh = 0; float sumlow = 0; float sumtert = 0;
            for(int i =0; i < 3; i++)
            {
                sumhigh += high[i];
                sumlow += low[i];
                sumtert += tert[i];
            }

            highave = sumhigh / hv.Length;
            lowave = sumlow / lv.Length;
            tertave = sumtert / tv.Length;

            for(int i = 0; i < 3; i++)
            {
                highdiff[i] = ((high[i] - highave) / highave) * 100;
                lowdiff[i] = ((low[i] - lowave) / lowave) * 100;
                tertdiff[i] = ((tert[i] - tertave) / tertave) * 100;
            }

            if (Array.TrueForAll(highdiff, v => v <= 2)) txtAssessHigh.Text = "PASSED";
            else txtAssessHigh.Text = "FAILED";

            if (Array.TrueForAll(lowdiff, v => v <= 2)) txtAssessLow.Text = "PASSED";
            else txtAssessLow.Text = "FAILED";

            if (!string.IsNullOrEmpty(tv[0].Text))
            {
                if (Array.TrueForAll(tertdiff, v => v <= 2)) txtAssessTert.Text = "PASSED";
                else txtAssessTert.Text = "FAILED";
            }
        }
    }
}
