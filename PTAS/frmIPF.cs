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
        float kv;

        public frmIPF()
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

        //    frmIPF f = new frmIPF();

        //    //var t = f.Controls.OfType<TextBox>().ToArray();

        //    var tm = grpPFM.Controls.
        //             OfType<TextBox>().
        //             OrderBy(t => t.TabIndex).
        //             ToArray();

        //    var cap = grpCap.Controls.
        //              OfType<TextBox>().
        //              ToArray();

        //    var tc = grpPFC.Controls.
        //             OfType<TextBox>().
        //             OrderBy(v => v.TabIndex).
        //             ToArray();

        //    string query = "SELECT COUNT (*) FROM tblIPF WHERE TestNumber = @testnumber";
        //    using (SqlConnection con = new SqlConnection(constring))
        //    {
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            cmd.Parameters.AddWithValue("@testnumber", TestNumber);
        //            con.Open();
        //            int record = Convert.ToInt32(cmd.ExecuteScalar());

        //            if (record == 1)
        //            {
        //                string query2 = "SELECT * FROM tblIPF WHERE TestNumber = @testnumber";
        //                using (SqlCommand cmd2 = new SqlCommand(query2, con))
        //                {
        //                    cmd2.Parameters.AddWithValue("@testnumber", TestNumber);
        //                    SqlDataReader dr = cmd2.ExecuteReader();

        //                    while (dr.Read())
        //                    {
        //                        testNumberTextBox.Text = (dr["TestNumber"].ToString());
        //                        ipfMCHCHLTextBox.Text = (dr["ipfMCHCHL"].ToString());
        //                        ipfMCHTextBox.Text = (dr["ipfMCH"].ToString());
        //                        ipfMCHLUTextBox.Text = (dr["ipfMCHLU"].ToString());
        //                        ipfMCHLTextBox.Text = (dr["ipfMCHL"].ToString());
        //                        ipfMCLCHLTextBox.Text = (dr["ipfMCLCHL"].ToString());
        //                        ipfMCLTextBox.Text = (dr["ipfMCL"].ToString());
        //                        ipfMCHLUlvTextBox.Text = (dr["ipfMCHLUlv"].ToString());
        //                        ipfMCHLlvTextBox.Text = (dr["ipfMCHLlv"].ToString());
        //                        ipfCFTextBox.Text = (dr["ipfCF"].ToString());
        //                        ipfCCHCHLTextBox.Text = (dr["ipfCCHCHL"].ToString());
        //                        ipfCCHTextBox.Text = (dr["ipfCCH"].ToString());
        //                        ipfCCHLUTextBox.Text = (dr["ipfCCHLU"].ToString());
        //                        ipfCCHLTextBox.Text = (dr["ipfCCHL"].ToString());
        //                        ipfCCLCHLTextBox.Text = (dr["ipfCCLCHL"].ToString());
        //                        ipfCCLTextBox.Text = (dr["ipfCCL"].ToString());
        //                        ipfCCHLUlvTextBox.Text = (dr["ipfCCHLUlv"].ToString());
        //                        ipfCCHLlvTextBox.Text = (dr["ipfCCHLlv"].ToString());
        //                        ipfACHCHLTextBox.Text = (dr["ipfACHCHL"].ToString());
        //                        ipfACHTextBox.Text = (dr["ipfACH"].ToString());
        //                        ipfACHLUTextBox.Text = (dr["ipfACHLU"].ToString());
        //                        ipfACHLTextBox.Text = (dr["ipfACHL"].ToString());
        //                        ipfACLCHLTextBox.Text = (dr["ipfACLCHL"].ToString());
        //                        ipfACLTextBox.Text = (dr["ipfACL"].ToString());
        //                        ipfACHLUlvTextBox.Text = (dr["ipfACHLUlv"].ToString());
        //                        ipfACHLlvTextBox.Text = (dr["ipfACHLlv"].ToString());
        //                        testVoltageTextBox.Text = (dr["TestVoltage"].ToString());
        //                        txtAssess.Text = (dr["ipfAssess"].ToString());
        //                    }
        //                }
        //            }
        //            //else
        //            //{
        //            //    testNumberTextBox.Clear();
        //            //    testVoltageTextBox.Clear();
        //            //    ipfCFTextBox.Clear();
        //            //    txtAssess.Clear();
        //            //    //for(int i = 0; i < 4; i++)
        //            //    //{
        //            //    //    //t[i].Clear();
        //            //    //    tm[i].Text = "";
        //            //    //    tc[i].Text = "";
        //            //    //    cap[i].Text = "";
        //            //    //}
        //            //}
        //            con.Close();
        //        }
        //    }
        //    //frmMain.OnDataChanged -= FrmMain_OnDataChanged;
        //}

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

            if (dr == DialogResult.Yes)
            {
                
                Validate();
                tblIPFBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dtbPTASDataSet);

                MessageBox.Show("Record saved.");
            }
            else
                Focus();
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
                Focus();
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
            
            string query = "SELECT tblTest.TestNumber AS TestNumber, tblTransformer.xfID AS xfID, tblTransformer.xfPrimVolt AS xfPrimVolt FROM tblTest LEFT OUTER JOIN tblTransformer ON tblTest.testXformer = tblTransformer.xfID " +
                "WHERE tblTest.TestNumber = @testnumber";
            string query2 = "SELECT TOP 1 tblTest.testXformer, tblIPF.* FROM tblIPF LEFT OUTER JOIN tblTest ON tblIPF.TestNumber = tblTest.TestNumber " +
                "WHERE tblIPF.TestNumber < @testnumber ORDER BY tblIPF.TestNumber DESC";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);

                    con.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        xf = (dr["xfID"].ToString());
                        kv = float.Parse(dr["xfPrimVolt"].ToString());
                    }
                    dr.Close();

                    using (SqlCommand cmd2 = new SqlCommand(query2, con))
                    {
                        cmd2.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);

                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        dr2.Read();
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
                        dr.Close();
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
                    txtAssess.Text = "PASSED";
                }
                else if (Array.TrueForAll(corrected, v => v > 1))
                {
                    txtAssess.Text = "FAILED";
                }
                else
                {
                    int[] check = new int[8];
                    for(int i = 0; i < 8; i++)
                    {
                        if(corrected[i] > 0.5)
                        {
                            if (previous[i] <= 0.5) txtAssess.Text = "INVESTIGATE";
                            else txtAssess.Text = "MONITOR";
                        }
                    }
                }
            }

            else
            {
                if (Array.TrueForAll(corrected, v => v <= 0.4))
                {
                    txtAssess.Text = "PASSED";
                }
                else if (Array.TrueForAll(corrected, v => v > 1))
                {
                    txtAssess.Text = "FAILED";
                }
                else
                {
                    int[] check = new int[8];
                    for (int i = 0; i < 8; i++)
                    {
                        if (corrected[i] > 0.5)
                        {
                            if (previous[i] <= 0.5) txtAssess.Text = "INVESTIGATE";
                            else txtAssess.Text = "MONITOR";
                        }
                    }
                }
            }
        }
    }

}
