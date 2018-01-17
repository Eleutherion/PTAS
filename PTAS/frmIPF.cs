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
    public partial class frmIPF : Form
    {
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dtbPTAS.mdf;Integrated Security=True";
        string TestData;

        public frmIPF()
        {
            InitializeComponent();
            frmMain.OnDataChanged += FrmMain_OnDataChanged;
            frmMain.OnPassTestNumber += FrmMain_OnPassTestNumber;
        }

        private void FrmMain_OnPassTestNumber(string TestNumber)
        {
            TestData = TestNumber;
        }

        private void FrmMain_OnDataChanged(string TestNumber)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "SELECT COUNT (*) FROM tblIPF WHERE TestNumber = @testnumber";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", TestNumber);
                    con.Open();
                    int record = Convert.ToInt32(cmd.ExecuteScalar());

                    if (record == 1)
                    {
                        string query2 = "SELECT * FROM tblIPF WHERE TestNumber = @testnumber";
                        using (SqlCommand cmd2 = new SqlCommand(query2, con))
                        {
                            cmd2.Parameters.AddWithValue("@testnumber", TestNumber);
                            SqlDataReader dr = cmd2.ExecuteReader();

                            while (dr.Read())
                            {
                                testNumberTextBox.Text = (dr["TestNumber"].ToString());
                                ipfMCHCHLTextBox.Text = (dr["ipfMCHCHL"].ToString());
                                ipfMCHTextBox.Text = (dr["ipfMCH"].ToString());
                                ipfMCHLUTextBox.Text = (dr["ipfMCHLU"].ToString());
                                ipfMCHLTextBox.Text = (dr["ipfMCHL"].ToString());
                                ipfMCLCHLTextBox.Text = (dr["ipfMCLCHL"].ToString());
                                ipfMCLTextBox.Text = (dr["ipfMCL"].ToString());
                                ipfMCHLUlvTextBox.Text = (dr["ipfMCHLUlv"].ToString());
                                ipfMCHLlvTextBox.Text = (dr["ipfMCHLlv"].ToString());
                                ipfCFTextBox.Text = (dr["ipfCF"].ToString());
                                ipfCCHCHLTextBox.Text = (dr["ipfCCHCHL"].ToString());
                                ipfCCHTextBox.Text = (dr["ipfCCH"].ToString());
                                ipfCCHLUTextBox.Text = (dr["ipfCCHLU"].ToString());
                                ipfCCHLTextBox.Text = (dr["ipfCCHL"].ToString());
                                ipfCCLCHLTextBox.Text = (dr["ipfCCLCHL"].ToString());
                                ipfCCLTextBox.Text = (dr["ipfCCL"].ToString());
                                ipfCCHLUlvTextBox.Text = (dr["ipfCCHLUlv"].ToString());
                                ipfCCHLlvTextBox.Text = (dr["ipfCCHLlv"].ToString());
                                ipfACHCHLTextBox.Text = (dr["ipfACHCHL"].ToString());
                                ipfACHTextBox.Text = (dr["ipfACH"].ToString());
                                ipfACHLUTextBox.Text = (dr["ipfACHLU"].ToString());
                                ipfACHLTextBox.Text = (dr["ipfACHL"].ToString());
                                ipfACLCHLTextBox.Text = (dr["ipfACLCHL"].ToString());
                                ipfACLTextBox.Text = (dr["ipfACL"].ToString());
                                ipfACHLUlvTextBox.Text = (dr["ipfACHLUlv"].ToString());
                                ipfACHLlvTextBox.Text = (dr["ipfACHLlv"].ToString());
                                testVoltageTextBox.Text = (dr["TestVoltage"].ToString());
                            }
                        }
                    }
                    con.Close();
                }
            }
        }

        private void frmIPF_Load(object sender, EventArgs e)
        {
            this.tblIPFTableAdapter.Fill(this.dtbPTASDataSet.tblIPF);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);
            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);

            string query = "INSERT INTO tblIPF (TestNumber, ipfMCHCHL, ipfMCH, ipfMCHLU, ipfMCHL, ipfMCLCHL, ipfMCL, ipfMCHLUlv, ipfMCHLlv, ipfCf, " +
                "ipfCCHCHL, ipfCCH, ipfCCHLU, ipfCCHL, ipfCCLCHL, ipfCCL, ipfCCHLUlv, ipfCCHLlv, ipfACHCHL, ipfACH, ipfACHLU, ipfACHL, ipfACLCHL, ipfACL, ipfACHLUlv, ipfACHLlv, TestVoltage)" +
                "VALUES (@testnumber, @mchchl, @mch, @mchlu, @mchl, @mclchl, @mcl, @mchlulv, @mchllv, @cf, @cchchl, @cch, @cchlu, @cchl, @cclchl, @ccl, @cchlulv, @cchllv, " +
                "@achchl, @ach, @achlu, @achl, @aclchl, @acl, @achlulv, @achllv, @testvoltage)";

            DataSet ds = dtbPTASDataSet;

            if (dr == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);
                        cmd.Parameters.AddWithValue("@mchchl", ipfMCHCHLTextBox.Text);
                        cmd.Parameters.AddWithValue("@mch", ipfMCHTextBox.Text);
                        cmd.Parameters.AddWithValue("@mchlu", ipfMCHLUTextBox.Text);
                        cmd.Parameters.AddWithValue("@mclchl", ipfMCLCHLTextBox.Text);
                        cmd.Parameters.AddWithValue("@mcl", ipfMCLTextBox.Text);
                        cmd.Parameters.AddWithValue("@mchlulv", ipfMCHLUlvTextBox.Text);
                        cmd.Parameters.AddWithValue("@mchllv", ipfMCHLlvTextBox.Text);
                        cmd.Parameters.AddWithValue("@cf", ipfCFTextBox.Text);
                        cmd.Parameters.AddWithValue("@cchchl", ipfCCHCHLTextBox.Text);
                        cmd.Parameters.AddWithValue("@cch", ipfCCHTextBox.Text);
                        cmd.Parameters.AddWithValue("@cchlu", ipfCCHLUTextBox.Text);
                        cmd.Parameters.AddWithValue("@cchl", ipfCCHLTextBox.Text);
                        cmd.Parameters.AddWithValue("@cclchl", ipfCCLCHLTextBox.Text);
                        cmd.Parameters.AddWithValue("@ccl", ipfCCLTextBox.Text);
                        cmd.Parameters.AddWithValue("@cchlulv", ipfCCHLUlvTextBox.Text);
                        cmd.Parameters.AddWithValue("@cchllv", ipfCCHLlvTextBox.Text);
                        cmd.Parameters.AddWithValue("@achchl", ipfACHCHLTextBox.Text);
                        cmd.Parameters.AddWithValue("@ach", ipfACHTextBox.Text);
                        cmd.Parameters.AddWithValue("@achlu", ipfACHLUTextBox.Text);
                        cmd.Parameters.AddWithValue("@achl", ipfACHLTextBox.Text);
                        cmd.Parameters.AddWithValue("@aclchl", ipfACLCHLTextBox.Text);
                        cmd.Parameters.AddWithValue("@acl", ipfACLTextBox.Text);
                        cmd.Parameters.AddWithValue("@achlulv", ipfACHLUlvTextBox.Text);
                        cmd.Parameters.AddWithValue("@achllv", ipfACHLlvTextBox.Text);
                        cmd.Parameters.AddWithValue("@testvoltage", testVoltageTextBox.Text);

                        con.Open();

                        try
                        {
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record saved.");

                            ds.Clear();
                            tblIPFTableAdapter.Fill(dtbPTASDataSet.tblIPF);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tblIPFBindingSource.AddNew();
            testNumberTextBox.Text = TestData;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "DELETE FROM tblIPF WHERE TestNumber = @testnumber";
            DataSet ds = dtbPTASDataSet;

            DialogResult dr = MessageBox.Show("Do you wish to delete this record? This action cannot be undone.", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);
                            con.Open();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record deleted.");

                            ds.Clear();
                            tblIPFTableAdapter.Fill(dtbPTASDataSet.tblIPF);
                        }
                        catch
                        {
                            MessageBox.Show("An error has occurred.");
                        }
                    }
                    con.Close();
                }
            }
            else
                this.Focus();
        }

        

        private void ipfCFTextBox_TextChanged(object sender, EventArgs e)
        {
            float cf = float.Parse(ipfCFTextBox.Text);

            float[] measured = new float[8];

            if (ipfMCHCHLTextBox.Text != "")
            {
                measured[0] = float.Parse(ipfMCHCHLTextBox.Text);
                float f = (measured[0] * cf);
                float truncated = (float)(Math.Truncate((double)f * 100.0) / 100.0);
                float rounded = (float)(Math.Round((double)f, 2));
                ipfCCHCHLTextBox.Text = rounded.ToString();
            }

            if (ipfMCHTextBox.Text != "")
            {
                measured[1] = float.Parse(ipfMCHTextBox.Text);
                float f = (measured[1] * cf);
                float truncated = (float)(Math.Truncate((double)f * 100.0) / 100.0);
                float rounded = (float)(Math.Round((double)f, 2));
                ipfCCHTextBox.Text = rounded.ToString();
            }

            if (ipfMCHLUTextBox.Text != "")
            {
                measured[2] = float.Parse(ipfMCHLUTextBox.Text);
                float f = (measured[2] * cf);
                float truncated = (float)(Math.Truncate((double)f * 100.0) / 100.0);
                float rounded = (float)(Math.Round((double)f, 2));
                ipfCCHLUTextBox.Text = rounded.ToString();
            }

            if (ipfMCHLTextBox.Text != "")
            {
                measured[3] = float.Parse(ipfMCHLTextBox.Text);
                float f = (measured[3] * cf);
                float truncated = (float)(Math.Truncate((double)f * 100.0) / 100.0);
                float rounded = (float)(Math.Round((double)f, 2));
                ipfCCHLTextBox.Text = rounded.ToString();
            }

            if (ipfMCLCHLTextBox.Text != "")
            {
                measured[4] = float.Parse(ipfMCLCHLTextBox.Text);
                float f = (measured[4] * cf);
                float truncated = (float)(Math.Truncate((double)f * 100.0) / 100.0);
                float rounded = (float)(Math.Round((double)f, 2));
                ipfCCLCHLTextBox.Text = rounded.ToString();
            }

            if (ipfMCLTextBox.Text != "")
            {
                measured[5] = float.Parse(ipfMCLTextBox.Text);
                float f = (measured[5] * cf);
                float truncated = (float)(Math.Truncate((double)f * 100.0) / 100.0);
                float rounded = (float)(Math.Round((double)f, 2));
                ipfCCLTextBox.Text = rounded.ToString();
            }

            if (ipfMCHLUlvTextBox.Text != "")
            {
                measured[6] = float.Parse(ipfMCHLUlvTextBox.Text);
                float f = (measured[6] * cf);
                float truncated = (float)(Math.Truncate((double)f * 100.0) / 100.0);
                float rounded = (float)(Math.Round((double)f, 2));
                ipfCCHLUlvTextBox.Text = rounded.ToString();
            }

            if (ipfMCHLlvTextBox.Text != "")
            {
                measured[7] = float.Parse(ipfMCHLlvTextBox.Text);
                float f = (measured[7] * cf);
                float truncated = (float)(Math.Truncate((double)f * 100.0) / 100.0);
                float rounded = (float)(Math.Round((double)f, 2));
                ipfCCHLlvTextBox.Text = rounded.ToString();
            }
        }
    }

}
