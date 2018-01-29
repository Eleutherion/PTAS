﻿using System;
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
        float kv;

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
        
        private void btnCompute_Click(object sender, EventArgs e)
        {
            float cf = float.Parse(ipfCFTextBox.Text);

            float[] measured = new float[8];
            float[] capacitance = new float[8];

            var tm = grpPFM.Controls.
                     OfType<TextBox>().
                     OrderBy(t => t.TabIndex).
                     ToArray();

            var cap = grpCap.Controls.
                      OfType<TextBox>().
                      ToArray();
            
            float[] f = new float[8];
            float[] truncated = new float[8];
            float[] round = new float[8];

            for (int i = 0; i < 8; i++)
            {
                if (!string.IsNullOrEmpty(tm[i].Text))
                {
                    measured[i] = float.Parse(tm[i].Text);

                    f[i] = measured[i] * cf;
                    truncated[i] = (float)Math.Round(f[i], 2);
                }

                if (!string.IsNullOrEmpty(cap[i].Text))
                {
                    capacitance[i] = float.Parse(cap[i].Text);
                }
            }
            
            if(truncated[0] != 0)
                ipfCCHCHLTextBox.Text = truncated[0].ToString();
            if(truncated[1] != 0)
                ipfCCHTextBox.Text = truncated[1].ToString();
            if (truncated[2] != 0)
                ipfCCHLUTextBox.Text = truncated[2].ToString();
            if (truncated[3] != 0)
                ipfCCHLTextBox.Text = truncated[3].ToString();
            if (truncated[4] != 0)
                ipfCCLCHLTextBox.Text = truncated[4].ToString();
            if (truncated[5] != 0)
                ipfCCLTextBox.Text = truncated[5].ToString();
            if (truncated[6] != 0)
                ipfCCHLUlvTextBox.Text = truncated[6].ToString();
            if (truncated[7] != 0)
                ipfCCHLlvTextBox.Text = truncated[7].ToString();
        }

        private void btnAssess_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            var tc = grpPFC.Controls.
                     OfType<TextBox>().
                     OrderBy(t => t.TabIndex).
                     ToArray();

            float[] corrected = new float[8];
            float[] previous = new float[8];
            float[] previouscap = new float[8];

            float[] compare = new float[8];

            string xf;
            
            string query = "SELECT tblTest.TestNumber, tblTransformer.xfID, tblTransformer.xfPrimVolt FROM tblTest LEFT OUTER JOIN tblTransformer ON tblTest.testXformer = tblTransformer.xfID " +
                "WHERE tblTest.TestNumber = @testnumber";
            string query2 = "SELECT TOP 1 tblTest.testXformer, tblIPF.* FROM tblIPF LEFT OUTER JOIN tblTest ON tblIPF.TestNumber = tblTest.TestNumber " +
                "ORDER BY tblIPF.TestNumber DESC WHERE tblIPF.TestNumber = @testnumber";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);

                    con.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        xf = (dr["tblTransformer.xfID"].ToString());
                        kv = float.Parse(dr["tblTransformer.xfPrimVolt"].ToString());
                    }
                    
                    using(SqlCommand cmd2 = new SqlCommand(query2, con))
                    {
                        cmd2.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);

                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        while (dr2.Read())
                        {
                            previous[0] = float.Parse(dr["ipfCCHCHL"].ToString());
                            previous[1] = float.Parse(dr["ipfCCH"].ToString());
                            previous[2] = float.Parse(dr["ipfCCHLU"].ToString());
                            previous[3] = float.Parse(dr["ipfCCHL"].ToString());
                            previous[4] = float.Parse(dr["ipfCCLCHL"].ToString());
                            previous[5] = float.Parse(dr["ipfCCL"].ToString());
                            previous[6] = float.Parse(dr["ipfCCHLUlv"].ToString());
                            previous[7] = float.Parse(dr["ipfCCHLlv"].ToString());
                            previouscap[0] = float.Parse(dr["ipfACHCHL"].ToString());
                            previouscap[1] = float.Parse(dr["ipfACH"].ToString());
                            previouscap[2] = float.Parse(dr["ipfACHLU"].ToString());
                            previouscap[3] = float.Parse(dr["ipfACHL"].ToString());
                            previouscap[4] = float.Parse(dr["ipfACLCHL"].ToString());
                            previouscap[5] = float.Parse(dr["ipfACL"].ToString());
                            previouscap[6] = float.Parse(dr["ipfACHLUlv"].ToString());
                            previouscap[7] = float.Parse(dr["ipfACHLlv"].ToString());
                        }
                        con.Close();
                    }
                }
            }

            for(int i = 0; i < 8; i++)
            {
                corrected[i] = float.Parse(tc[i].Text);
            }

            if(kv <= 230000)
            {
                if (Array.TrueForAll(corrected, v => v <= 0.5))
                {
                    //txtAssess.Text = "PASSED";
                    for (int i = 0; i < 8; i++)
                    {
                        if (previous[i] != 0 || corrected[i] != 0)
                        {
                            compare[i] = ((corrected[i] - previous[i]) / corrected[i]) * 100;
                        }

                        else compare[i] = 0;
                    }

                    if (Array.TrueForAll(compare, v => v <= 20))
                    {
                        txtAssess.Text = "PASSED";
                    }

                    else txtAssess.Text = "INVESTIGATE. RESULT HIGHER THAN PREVIOUS";
                }
                else if (Array.TrueForAll(corrected, v => v > 1))
                {
                    txtAssess.Text = "FAILED";
                }
                else
                {
                    txtAssess.Text = "INVESTIGATE";
                }
            }

            else
            {
                if (Array.TrueForAll(corrected, v => v <= 0.4))
                {
                    //txtAssess.Text = "PASSED";
                    for (int i = 0; i < 8; i++)
                    {
                        if (previous[i] != 0 || corrected[i] != 0)
                        {
                            compare[i] = ((corrected[i] - previous[i]) / corrected[i]) * 100;
                        }

                        else compare[i] = 0;
                    }

                    if (Array.TrueForAll(compare, v => v <= 20))
                    {
                        txtAssess.Text = "PASSED";
                    }

                    else txtAssess.Text = "INVESTIGATE. RESULT HIGHER THAN PREVIOUS";
                }
                else if (Array.TrueForAll(corrected, v => v > 1))
                {
                    txtAssess.Text = "FAILED";
                }
                else
                {
                    txtAssess.Text = "INVESTIGATE";
                }
            }
        }
    }

}