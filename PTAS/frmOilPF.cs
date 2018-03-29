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
    public partial class frmOilPF : Form
    {
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dtbPTAS.mdf;Integrated Security=True";
        string TestData;

        public frmOilPF()
        {
            InitializeComponent();
            frmMain.OnDataChanged += FrmMain_OnDataChanged;
            frmMain.OnPassTestNumber += FrmMain_OnPassTestNumber;
        }

        private void FrmMain_OnPassTestNumber(string TestNumber)
        {
            TestData = TestNumber;
            frmMain.OnPassTestNumber -= FrmMain_OnPassTestNumber;
        }

        private void FrmMain_OnDataChanged(string TestNumber)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "SELECT COUNT (*) FROM tblOilPF WHERE TestNumber = @testnumber";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", TestNumber);
                    con.Open();
                    int record = Convert.ToInt32(cmd.ExecuteScalar());

                    if (record == 1)
                    {
                        string query2 = "SELECT * FROM tblOilPF WHERE TestNumber = @testnumber";
                        using (SqlCommand cmd2 = new SqlCommand(query2, con))
                        {
                            cmd2.Parameters.AddWithValue("@testnumber", TestNumber);
                            SqlDataReader dr = cmd2.ExecuteReader();

                            while (dr.Read())
                            {
                                testNumberTextBox.Text = (dr["TestNumber"].ToString());
                                pfMainTextBox.Text = (dr["pfMain"].ToString());
                                pfOLTCTextBox.Text = (dr["pfOLTC"].ToString());
                            }
                        }
                    }
                    con.Close();
                }
            }
            //frmMain.OnDataChanged -= FrmMain_OnDataChanged;
        }

        private void frmOilPF_Load(object sender, EventArgs e)
        {
            this.tblOilPFTableAdapter.Fill(this.dtbPTASDataSet.tblOilPF);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tblOilPFBindingSource.AddNew();
            testNumberTextBox.Text = TestData;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Validate();
                tblOilPFBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dtbPTASDataSet);
            }
            else
                this.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "DELETE FROM tblOilPF WHERE TestNumber = @testnumber";
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
                            tblOilPFTableAdapter.Fill(dtbPTASDataSet.tblOilPF);
                        }
                        catch
                        {
                            MessageBox.Show("An error occurred.");
                        }
                        con.Close();
                    }
                }
            }
            else
                this.Focus();
        }

        string main; string oltc; string transformer;

        private void btnAssess_Click(object sender, EventArgs e)
        {
            //if(pfMainTextBox.Text != "")
            //{
            //    float.TryParse(pfMainTextBox.Text, out float pfmain);

            //    if (pfmain < 0)
            //    {
            //        txtAssessMain.Text = "FAILED";
            //    }

            //    else if (pfmain > 0 && pfmain < 0.5)
            //    {
            //        txtAssessMain.Text = "PASSED";
            //    }
            //    else if (pfmain > 0.5 && pfmain < 1)
            //    {
            //        txtAssessMain.Text = "INVESTIGATE";
            //    }
            //    else
            //        txtAssessMain.Text = "FAILED";
            //}

            string query = "SELECT TOP 1 tblOilPF.*, tblTest.testXformer FROM tblOilPF LEFT OUTER JOIN tblTest ON " +
                "tblOilPF.TestNumber = tblTest.TestNumber WHERE TestNumber < @testnumber AND testXformer = @transformer ORDER BY TestNumber DESC";
            string query2 = "SELECT * FROM tblTest WHERE TestNumber = @testnumber";

            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query2, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);
                    con.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        transformer = (dr["testXformer"].ToString());
                    }

                    using(SqlCommand cmd2 = new SqlCommand(query, con))
                    {
                        cmd2.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);
                        cmd2.Parameters.AddWithValue("@transformer", transformer);

                        SqlDataReader dr2 = cmd2.ExecuteReader();

                        while (dr2.Read())
                        {
                            main = (dr2["pfMain"].ToString());
                            oltc = (dr2["pfOLTC"].ToString());
                        }
                    }
                    con.Close();
                }
            }

            if(pfMainTextBox.Text != "")
            {
                float pfmain = float.Parse(pfMainTextBox.Text);

                //if (pfmain < 0)
                //    txtAssessMain.Text = "FAILED";
                if (pfmain >= 0 && pfmain <= 0.5)
                {
                    float.TryParse(main, out float prevmain);
                    float maindiff = ((pfmain - prevmain) / pfmain)*100;

                    if (maindiff < 5)
                        txtAssessMain.Text = "PASSED";
                    else
                        txtAssessMain.Text = "INVESTIGATE OIL";
                }
                    
                else if (pfmain > 0.5 && pfmain <= 1)
                    txtAssessMain.Text = "INVESTIGATE OIL";
                else
                    txtAssessMain.Text = "FAILED. CONSIDER REPLACING OIL";
            }

            if(pfOLTCTextBox.Text != "")
            {
                float pfoltc = float.Parse(pfOLTCTextBox.Text);

                if (pfoltc >= 0 && pfoltc <= 0.5)
                {
                    float.TryParse(oltc, out float prevoltc);
                    float oltcdiff = ((pfoltc - prevoltc) / pfoltc) * 100;

                    if (oltcdiff < 5)
                        txtAssessOLTC.Text = "PASSED";
                    else
                        txtAssessOLTC.Text = "INVESTIGATE OIL";
                }
                else if (pfoltc > 0.5 && pfoltc <= 1)
                    txtAssessOLTC.Text = "INVESTIGATE OIL";
                else
                    txtAssessOLTC.Text = "FAILED. CONSIDER REPLACING OIL";
            }
        }
    }
}
