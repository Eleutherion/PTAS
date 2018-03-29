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
    public partial class frmBushing : Form
    {
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dtbPTAS.mdf;Integrated Security=True";
        string TestData;

        public frmBushing()
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

            frmBushing f = new frmBushing();

            var t = f.Controls.OfType<TextBox>().ToArray();

            string query = "SELECT COUNT (*) FROM tblBushing WHERE TestNumber = @testnumber";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", TestNumber);
                    con.Open();
                    int record = Convert.ToInt32(cmd.ExecuteScalar());

                    if (record == 1)
                    {
                        string query2 = "SELECT * FROM tblBushing WHERE TestNumber = @testnumber";
                        using (SqlCommand cmd2 = new SqlCommand(query2, con))
                        {
                            cmd2.Parameters.AddWithValue("@testnumber", TestNumber);
                            SqlDataReader dr = cmd2.ExecuteReader();

                            while (dr.Read())
                            {
                                testNumberTextBox.Text = (dr["TestNumber"].ToString());
                                nameH1TextBox.Text = (dr["nameH1"].ToString());
                                nameH2TextBox.Text = (dr["nameH2"].ToString());
                                nameH3TextBox.Text = (dr["nameH3"].ToString());
                                nameH0X0TextBox.Text = (dr["nameH0X0"].ToString());
                                nameX1TextBox.Text = (dr["nameX1"].ToString());
                                nameX2TextBox.Text = (dr["nameX2"].ToString());
                                nameX3TextBox.Text = (dr["nameX3"].ToString());
                                pfC1H1TextBox.Text = (dr["pfC1H1"].ToString());
                                pfC1H2TextBox.Text = (dr["pfC1H2"].ToString());
                                pfC1H3TextBox.Text = (dr["pfC1H3"].ToString());
                                pfC1H0X0TextBox.Text = (dr["pfC1H0X0"].ToString());
                                pfC1X1TextBox.Text = (dr["pfC1X1"].ToString());
                                pfC1X2TextBox.Text = (dr["pfC1X2"].ToString());
                                pfC1X3TextBox.Text = (dr["pfC1X3"].ToString());
                                pfC2H1TextBox.Text = (dr["pfC2H1"].ToString());
                                pfC2H2TextBox.Text = (dr["pfC2H2"].ToString());
                                pfC2H3TextBox.Text = (dr["pfC2H3"].ToString());
                                pfC2H0X0TextBox.Text = (dr["pfC2H0X0"].ToString());
                                pfC2X1TextBox.Text = (dr["pfC2X1"].ToString());
                                pfC2X2TextBox.Text = (dr["pfC2X2"].ToString());
                                pfC2X2TextBox.Text = (dr["pfC2X3"].ToString());
                                capC1H1TextBox.Text = (dr["capC1H1"].ToString());
                                capC1H2TextBox.Text = (dr["capC1H2"].ToString());
                                capC1H3TextBox.Text = (dr["capC1H3"].ToString());
                                capC1H0X0TextBox.Text = (dr["capC1H0X0"].ToString());
                                capC1X1TextBox.Text = (dr["capC1X1"].ToString());
                                capC1X2TextBox.Text = (dr["capC1X2"].ToString());
                                capC1X3TextBox.Text = (dr["capC1X3"].ToString());
                                capC2H1TextBox.Text = (dr["capC2H1"].ToString());
                                capC2H2TextBox.Text = (dr["capC2H2"].ToString());
                                capC2H3TextBox.Text = (dr["capC2H3"].ToString());
                                capC2H0X0TextBox.Text = (dr["capC2H0X0"].ToString());
                                capC2X1TextBox.Text = (dr["capC2X1"].ToString());
                                capC2X2TextBox.Text = (dr["capC2X2"].ToString());
                                capC2X2TextBox.Text = (dr["capC2X3"].ToString());
                                pfnameH1TextBox.Text = (dr["pfnameH1"].ToString());
                                pfnameH2TextBox.Text = (dr["pfnameH2"].ToString());
                                pfnameH3TextBox.Text = (dr["pfnameH3"].ToString());
                                pfnameH0X0TextBox.Text = (dr["pfnameH0X0"].ToString());
                                pfnameX1TextBox.Text = (dr["pfnameX1"].ToString());
                                pfnameX2TextBox.Text = (dr["pfnameX2"].ToString());
                                pfnameX3TextBox.Text = (dr["pfnameX3"].ToString());
                                txtAssessH1.Text = (dr["AssessH1"].ToString());
                                txtAssessH2.Text = (dr["AssessH2"].ToString());
                                txtAssessH3.Text = (dr["AssessH3"].ToString());
                                txtAssessH0X0.Text = (dr["AssessH0X0"].ToString());
                                txtAssessX1.Text = (dr["AssessX1"].ToString());
                                txtAssessX2.Text = (dr["AssessX2"].ToString());
                                txtAssessX3.Text = (dr["AssessX3"].ToString());
                            }
                        }
                    }
                    //else
                    //{
                    //    for(int i = 0; i<50; i++)
                    //    {
                    //        t[i].Clear();
                    //    }
                    //}
                    con.Close();
                }
            }
            //frmMain.OnDataChanged -= FrmMain_OnDataChanged;
        }

        private void frmBushing_Load(object sender, EventArgs e)
        {
            this.tblBushingTableAdapter.Fill(this.dtbPTASDataSet.tblBushing);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "DELETE FROM tblBushing WHERE TestNumber = @testnumber";
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
                            tblBushingTableAdapter.Fill(dtbPTASDataSet.tblBushing);
                        }
                        catch
                        {
                            MessageBox.Show("An error has occurred.");
                        }
                    }
                    con.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //string path = (System.IO.Path.GetDirectoryName(executable));
            //AppDomain.CurrentDomain.SetData("Data Directory", path);

            //DataSet ds = dtbPTASDataSet;

            //string query = "INSERT INTO tblBushing (TestNumber, nameH1, nameH2, nameH3, nameH0X0, nameX1, nameX2, nameX3, " +
            //    "pfC1H1, pfC1H2, pfC1H3, pfC1H0X0, pfC1X1, pfC1X2, pfC1X3, pfC2H1, pfC2H2, pfC2H3, pfC2H0X0, pfC2X1, pfC2X2, pfC2X3, " +
            //    "capC1H1, capC1H2, capC1H3, capC1H0X0, capC1X1, capC1X2, capC1X3, capC2H1, capC2H2, capC2H3, capC2H0X0, capC2X1, capC2X2, capC2X3) " +
            //    "VALUES (@testnumber, @nameH1, @nameH2, @nameH3, @nameH0X0, @nameX1, @nameX2, @nameX3, @pfC1H1, @pfC1H2, @pfC1H3, @pfC1H0X0, @pfC1X1, @pfC1X2, @pfC1X3, " +
            //    "@pfC2H1, @pfC2H2, @pfC2H3, @pfC2H0X0, @pfC2X1, @pfC2X2, @pfC2X3, @capC1H1, @capC1H2, @capC1H3, @capC1H0X0, @capC1X1, @capC1X2, @capC1X3, " +
            //    "@capC2H1, @capC2H2, @capC2H3, @capC2H0X0, @capC2X1, @capC2X2, @capC2X3)";

            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                Validate();
                tblBushingBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dtbPTASDataSet);
            }
            else Focus();
        }

        string xf;

        private void btnAssess_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "SELECT tblTest.testXformer AS xf FROM tblTest WHERE TestNumber = @testnumber";
            string query2 = "SELECT COUNT tblTest.testXformer AS xf, tblBushing.* FROM tblBushing " +
                "LEFT OUTER JOIN tblTest ON tblBushing.TestNumber = tblTest.TestNumber " +
                "WHERE xf = @xf";
            string query3 = "SELECT TOP 1 tblTest.testXformer AS xf, tblBushing.* FROM tblBushing " +
                "LEFT OUTER JOIN tblTest ON tblBushing.TestNumber = tblTest.TestNumber " +
                "WHERE tblBushing.TestNumber < @testnumber ORDER BY tblBushing.TestNumber DESC ";
            
            var ncc1 = grpName.Controls.OfType<TextBox>().OrderBy(v => v.TabIndex).ToArray();
            var npfc1 = grpNamepf.Controls.OfType<TextBox>().OrderBy(v => v.TabIndex).ToArray();
            var ncc2 = grpNameC2.Controls.OfType<TextBox>().OrderBy(v => v.TabIndex).ToArray();
            var npfc2 = grpNameC2pf.Controls.OfType<TextBox>().OrderBy(v => v.TabIndex).ToArray();
            var c1pf = grpC1pf.Controls.OfType<TextBox>().OrderBy(v => v.TabIndex).ToArray();
            var c2pf = grpC2pf.Controls.OfType<TextBox>().OrderBy(v => v.TabIndex).ToArray();
            var c1cap = grpC1Cap.Controls.OfType<TextBox>().OrderBy(v => v.TabIndex).ToArray();
            var c2cap = grpC2Cap.Controls.OfType<TextBox>().OrderBy(v => v.TabIndex).ToArray();
            var assess = grpAssess.Controls.OfType<TextBox>().OrderBy(v => v.TabIndex).ToArray();

            float[] ncap = new float[7];
            float[] npower = new float[7];
            float[] ncap2 = new float[7];
            float[] npower2 = new float[7];
            float[] c1power = new float[7];
            float[] c2power = new float[7];
            float[] c1c = new float[7];
            float[] c2c = new float[7];

            float[] diffpfc1 = new float[7];
            float[] devpfc1 = new float[7];
            float[] diffcapc1 = new float[7];
            float[] devcapc1 = new float[7];
            float[] diffpfc2 = new float[7];
            float[] devpfc2 = new float[7];
            float[] diffcapc2 = new float[7];
            float[] devcapc2 = new float[7];
            float[] prevc1cap = new float[7];
            float[] prevc2cap = new float[7];
            float[] prevc1pf = new float[7];
            float[] prevc2pf = new float[7];

            int[] capc1 = new int[7];
            int[] capc2 = new int[7];
            int[] pfc1 = new int[7];
            int[] pfc2 = new int[7];

            using (SqlConnection con = new SqlConnection(constring))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    xf = dr["xf"].ToString();
                }
                dr.Close();

                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@xf", xf);

                int record = Convert.ToInt32(cmd.ExecuteScalar());

                if(record > 1)
                {
                    using(SqlCommand cmd3 = new SqlCommand(query3, con))
                    {
                        cmd3.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);

                        SqlDataReader dr2 = cmd3.ExecuteReader();
                        dr2.Read();
                        while (dr2.Read())
                        {
                            float.TryParse(dr2["capC1H1"].ToString(), out prevc1cap[0]);
                            float.TryParse(dr2["capC1H2"].ToString(), out prevc1cap[1]);
                            float.TryParse(dr2["capC1H3"].ToString(), out prevc1cap[2]);
                            float.TryParse(dr2["capC1H0X0"].ToString(), out prevc1cap[3]);
                            float.TryParse(dr2["capC1X1"].ToString(), out prevc1cap[4]);
                            float.TryParse(dr2["capC1X2"].ToString(), out prevc1cap[5]);
                            float.TryParse(dr2["capC1X3"].ToString(), out prevc1cap[6]);
                            float.TryParse(dr2["capC2H1"].ToString(), out prevc2cap[0]);
                            float.TryParse(dr2["capC2H2"].ToString(), out prevc2cap[1]);
                            float.TryParse(dr2["capC2H3"].ToString(), out prevc2cap[2]);
                            float.TryParse(dr2["capC2H0X0"].ToString(), out prevc2cap[3]);
                            float.TryParse(dr2["capC2X1"].ToString(), out prevc2cap[4]);
                            float.TryParse(dr2["capC2X2"].ToString(), out prevc2cap[5]);
                            float.TryParse(dr2["capC2X3"].ToString(), out prevc2cap[6]);
                            float.TryParse(dr2["pfC1H1"].ToString(), out prevc1pf[0]);
                            float.TryParse(dr2["pfC1H2"].ToString(), out prevc1pf[1]);
                            float.TryParse(dr2["pfC1H3"].ToString(), out prevc1pf[2]);
                            float.TryParse(dr2["pfC1H0X0"].ToString(), out prevc1pf[3]);
                            float.TryParse(dr2["pfC1X1"].ToString(), out prevc1pf[4]);
                            float.TryParse(dr2["pfC1X2"].ToString(), out prevc1pf[5]);
                            float.TryParse(dr2["pfC1X3"].ToString(), out prevc1pf[6]);
                            float.TryParse(dr2["pfC2H1"].ToString(), out prevc2pf[0]);
                            float.TryParse(dr2["pfC2H2"].ToString(), out prevc2pf[1]);
                            float.TryParse(dr2["pfC2H3"].ToString(), out prevc2pf[2]);
                            float.TryParse(dr2["pfC2H0X0"].ToString(), out prevc2pf[3]);
                            float.TryParse(dr2["pfC2X1"].ToString(), out prevc2pf[4]);
                            float.TryParse(dr2["pfC2X2"].ToString(), out prevc2pf[5]);
                            float.TryParse(dr2["pfC2X3"].ToString(), out prevc2pf[6]);
                        }
                    }
                }
                con.Close();
            }

            for (int i = 0; i < 7; i++)
            {
                float.TryParse(ncc1[i].Text, out ncap[i]);
                float.TryParse(npfc1[i].Text, out npower[i]);
                float.TryParse(ncc2[i].Text, out ncap2[i]);
                float.TryParse(npfc2[i].Text, out npower2[i]);
                float.TryParse(c1pf[i].Text, out c1power[i]);
                float.TryParse(c2pf[i].Text, out c2power[i]);
                float.TryParse(c1cap[i].Text, out c1c[i]);
                float.TryParse(c2cap[i].Text, out c2c[i]);

                //FOR C1 CAPACITANCE
                if (!string.IsNullOrWhiteSpace(ncc1[i].Text))
                {
                    diffcapc1[i] = c1c[i] - ncap[i];
                    if (diffcapc1[i] == 327) capc1[i] = 0;
                    else capc1[i] = 1;
                }
                else
                {
                    devcapc1[i] = ((c1c[i] - prevc1cap[i]) / prevc1cap[i]) * 100;
                    if (devcapc1[i] <= 8) capc1[i] = 0;
                    else if (devcapc1[i] > 8 && devcapc1[i] <= 10) capc1[i] = 1;
                    else capc1[i] = 3;
                }

                //FOR C1 POWER FACTOR
                if (!string.IsNullOrWhiteSpace(npfc1[i].Text))
                {
                    diffpfc1[i] = c1power[i] - npower[i];
                    if (diffpfc1[i] <= 0.25) pfc1[i] = 0;
                    else pfc1[i] = 1;
                }
                else
                {
                    devpfc1[i] = ((c1power[i] - prevc1pf[i]) / prevc1pf[i]) * 100;
                    if (npower[i] <= 0.5)
                    {
                        if (devpfc1[i] <= 50) pfc1[i] = 0;
                        else pfc1[i] = 2;
                    }
                    else pfc1[i] = 3;
                }

                //if (!string.IsNullOrWhiteSpace(ncc2[i].Text))
                //{

                //}
                //else devcapc2[i] = ((c2c[i] - prevc2cap[i]) / prevc2cap[i]) * 100;

                //if (!string.IsNullOrWhiteSpace(npfc2[i].Text)) diffpfc2[i] = c2power[i] - npower2[i];
                //else devpfc2[i] = ((c2power[i] - prevc2pf[i]) / prevc2pf[i]) * 100;

                //FOR C2 POWER FACTOR
                if (npower2[i] <= 1) pfc2[i] = 1;
                else if (npower2[i] > 1 && npower2[i] <= 2) pfc2[i] = 2;
                else pfc2[i] = 4;

                if (ncap[i] != 0 || ncap2[i] != 0)
                {
                    if (capc1[i] == 0 && pfc1[i] == 0 && pfc2[i] == 0) assess[i].Text = "PASSED";
                    else if (capc1[i] == 1 || pfc1[i] == 1 || pfc2[i] == 1) assess[i].Text = "INVESTIGATE";
                    else if (capc1[i] == 2 || pfc1[i] == 2 || pfc2[i] == 2) assess[i].Text = "MONITOR";
                    else assess[i].Text = "FAILED";
                }
                else assess[i].Text = "";
            }
        }
    }
}
