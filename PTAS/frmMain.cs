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
    public partial class frmMain : Form
    {
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dtbPTAS.mdf;Integrated Security=True";


        public frmMain()
        {
            InitializeComponent();
            refreshdata();
            refreshstandard();

            frmLogin f = new frmLogin();
            f.Dispose();
        }

        public void refreshdata()
        {
            using(SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblSubstation", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        cboSub.DataSource = dt;
                        cboSub.DisplayMember = "subName";
                        cboSub.ValueMember = "subID";
                        cboSub.SelectedIndex = -1;
                        cboSub.Text = "Select substation";
                    }
                }
            }
        }

        public void refreshstate(string subID)
        {
            using(SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT xfID FROM tblTransformer WHERE xfSubID = @subID", con))
                {
                    cmd.Parameters.AddWithValue("@subID", cboSub.SelectedValue.ToString());
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        cboXf.DataSource = dt;
                        cboXf.DisplayMember = "xfID";
                        cboXf.ValueMember = "xfID";
                        cboXf.SelectedIndex = -1;
                        cboXf.Text = "Select transformer";
                    }
                }
            }
        }

        public void refreshstandard()
        {
            using(SqlConnection con = new SqlConnection(constring))
            {
                using(SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblStandards", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    standardComboBox.DataSource = dt;
                    standardComboBox.DisplayMember = "standards";
                    standardComboBox.ValueMember = "standards";
                    standardComboBox.SelectedIndex = -1;
                    standardComboBox.Text = "Select Standard";
                }
            }
        }

        public void refreshstatus(string standardID)
        {
            using(SqlConnection con = new SqlConnection(constring))
            {
                using(SqlCommand cmd = new SqlCommand("SELECT status FROM tblStatus WHERE standards = @standards", con))
                {
                    cmd.Parameters.AddWithValue("@standards", standardID);
                    using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        statusComboBox.DataSource = dt;
                        statusComboBox.DisplayMember = "status";
                        statusComboBox.ValueMember = "status";
                        statusComboBox.SelectedIndex = -1;
                        statusComboBox.Text = "Select status";
                    }
                    
                }
            }
        }

        private void transformerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXformer form = new frmXformer();
            form.Show();
            this.Hide();
        }

        private void substationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubstation form = new frmSubstation();
            form.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to log out?", "Log out", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                frmLogin form = new frmLogin();
                form.Show();
                this.Hide();
                this.Dispose();
            }

            else
                this.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                Application.Exit();
            else
                this.Focus();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtbPTASDataSet.tblOilPF' table. You can move, or remove it, as needed.
            this.tblOilPFTableAdapter.Fill(this.dtbPTASDataSet.tblOilPF);
            // TODO: This line of code loads data into the 'dtbPTASDataSet.tblStandards' table. You can move, or remove it, as needed.
            this.tblStandardsTableAdapter.Fill(this.dtbPTASDataSet.tblStandards);
            // TODO: This line of code loads data into the 'dtbPTASDataSet.tblDielectric' table. You can move, or remove it, as needed.
            this.tblDielectricTableAdapter.Fill(this.dtbPTASDataSet.tblDielectric);
            // TODO: This line of code loads data into the 'dtbPTASDataSet.tblWinding' table. You can move, or remove it, as needed.
            this.tblWindingTableAdapter.Fill(this.dtbPTASDataSet.tblWinding);
            // TODO: This line of code loads data into the 'dtbPTASDataSet.tblTTR' table. You can move, or remove it, as needed.
            this.tblTTRTableAdapter.Fill(this.dtbPTASDataSet.tblTTR);
            // TODO: This line of code loads data into the 'dtbPTASDataSet.tblIPF' table. You can move, or remove it, as needed.
            this.tblIPFTableAdapter.Fill(this.dtbPTASDataSet.tblIPF);
            // TODO: This line of code loads data into the 'dtbPTASDataSet.tblBushing' table. You can move, or remove it, as needed.
            this.tblBushingTableAdapter.Fill(this.dtbPTASDataSet.tblBushing);
            // TODO: This line of code loads data into the 'dtbPTASDataSet.tblExcitation' table. You can move, or remove it, as needed.
            this.tblExcitationTableAdapter.Fill(this.dtbPTASDataSet.tblExcitation);
            this.tblSubstationTableAdapter.Fill(this.dtbPTASDataSet.tblSubstation);
            this.tblTransformerTableAdapter.Fill(this.dtbPTASDataSet.tblTransformer);
            this.tblTestTableAdapter.Fill(this.dtbPTASDataSet.tblTest);

            frmExcitation excite = new frmExcitation
            {
                TopLevel = false
            };

            frmIPF ipf = new frmIPF
            {
                TopLevel = false
            };

            frmBushing bushing = new frmBushing
            {
                TopLevel = false
            };

            frmTTR ttr = new frmTTR
            {
                TopLevel = false
            };

            frmWinding winding = new frmWinding
            {
                TopLevel = false
            };

            frmOilBD oilbd = new frmOilBD
            {
                TopLevel = false
            };

            frmOilPF oilpf = new frmOilPF
            {
                TopLevel = false
            };

            //tabExcite2.Text = "Excitation Current";
            //tbcTest.TabPages.Add(tabExcite2);
            //tabExcite2.Show();

            //excite.Parent = tabExcite2;
            //excite.Show();

            //tabExcite.Text = "Excitation Current";
            //tbcTest.TabPages.Add(tabExcite);
            //tabExcite.Show();
            //excite.Parent = tabExcite;
            //excite.Show();

            //tabIPF.Text = "Insulation Power Factor";
            //tbcTest.TabPages.Add(tabIPF);

            //excite.Parent = tabExcite;
            //excite.Show();

            //ipf.Parent = tabIPF;
            //ipf.Show();

            //bushing.Parent = tabBushing;
            //bushing.Show();

            //ttr.Parent = tabTTR;
            //ttr.Show();

            //winding.Parent = tabWinding;
            //winding.Show();

            //oilbd.Parent = tabOilBD;
            //oilbd.Show();

            //oilpf.Parent = tabOilPF;
            //oilpf.Show();
        }

        private void cboSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboSub.Text))
            {
                string subID = cboSub.SelectedValue.ToString();
                refreshstate(subID);
            }
            
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
                tblTestBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dtbPTASDataSet);
                
                MessageBox.Show("Record saved.");

                OnPassTestNumber(testNumberTextBox.Text);
            }

            else
                Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            chkExcite.Checked = false;
            chkIPF.Checked = false;
            chkBushing.Checked = false;
            chkTTR.Checked = false;
            chkDCWR.Checked = false;
            chkDielectric.Checked = false;
            chkOilPF.Checked = false;
            tblTestBindingSource.AddNew();
            chkExcite.Checked = false;
            chkIPF.Checked = false;
            chkBushing.Checked = false;
            chkTTR.Checked = false;
            chkDCWR.Checked = false;
            chkDielectric.Checked = false;
            chkOilPF.Checked = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            DataSet ds = dtbPTASDataSet;

            tbcTest.SelectedIndex = 0;

            DialogResult dr = MessageBox.Show("Do you wish to delete this record? Please make sure any associated tests are deleted.", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(constring))
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM tblTest WHERE TestNumber = @testnumber", con))
                    {
                        cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Record deleted.");

                        ds.Clear();
                        this.tblTestTableAdapter.Fill(this.dtbPTASDataSet.tblTest);
                        con.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("An error has occurred. Please make sure any associated tests are deleted.");
                }
            }
            else
                Focus();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tblTestBindingSource.MoveNext();
            tblExcitationTableAdapter.FillByTestNumber(dtbPTASDataSet.tblExcitation, Convert.ToDecimal(testNumberTextBox.Text));
            tblBushingTableAdapter.FillByTestNumber(dtbPTASDataSet.tblBushing, Convert.ToDecimal(testNumberTextBox.Text));
            tblIPFTableAdapter.FillByTestNumber(dtbPTASDataSet.tblIPF, Convert.ToDecimal(testNumberTextBox.Text));
            tblTTRTableAdapter.FillByTestNumber(dtbPTASDataSet.tblTTR, Convert.ToDecimal(testNumberTextBox.Text));
            tblWindingTableAdapter.FillByTestNumber(dtbPTASDataSet.tblWinding, Convert.ToDecimal(testNumberTextBox.Text));
            tblDielectricTableAdapter.FillByTestNumber(dtbPTASDataSet.tblDielectric, Convert.ToDecimal(testNumberTextBox.Text));
            tblOilPFTableAdapter.FillByTestNumber(dtbPTASDataSet.tblOilPF, Convert.ToDecimal(testNumberTextBox.Text));
            //OnDataChanged(testNumberTextBox.Text);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tblTestBindingSource.MovePrevious();
            tblExcitationTableAdapter.FillByTestNumber(dtbPTASDataSet.tblExcitation, Convert.ToDecimal(testNumberTextBox.Text));
            tblBushingTableAdapter.FillByTestNumber(dtbPTASDataSet.tblBushing, Convert.ToDecimal(testNumberTextBox.Text));
            tblIPFTableAdapter.FillByTestNumber(dtbPTASDataSet.tblIPF, Convert.ToDecimal(testNumberTextBox.Text));
            tblTTRTableAdapter.FillByTestNumber(dtbPTASDataSet.tblTTR, Convert.ToDecimal(testNumberTextBox.Text));
            tblWindingTableAdapter.FillByTestNumber(dtbPTASDataSet.tblWinding, Convert.ToDecimal(testNumberTextBox.Text));
            tblDielectricTableAdapter.FillByTestNumber(dtbPTASDataSet.tblDielectric, Convert.ToDecimal(testNumberTextBox.Text));
            tblOilPFTableAdapter.FillByTestNumber(dtbPTASDataSet.tblOilPF, Convert.ToDecimal(testNumberTextBox.Text));
            //OnDataChanged(testNumberTextBox.Text);
        }

        public delegate void DataChanged(string TestNumber);
        public delegate void PassTestNumber(string TestNumber);

        public static event DataChanged OnDataChanged;
        public static event PassTestNumber OnPassTestNumber;

        frmExcitation f1 = new frmExcitation();

        private void registerAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegister f = new frmRegister();
            f.Show();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tblTestBindingSource.MoveFirst();
            //OnDataChanged(testNumberTextBox.Text);
            tblExcitationTableAdapter.FillByTestNumber(dtbPTASDataSet.tblExcitation, Convert.ToDecimal(testNumberTextBox.Text));
            tblBushingTableAdapter.FillByTestNumber(dtbPTASDataSet.tblBushing, Convert.ToDecimal(testNumberTextBox.Text));
            tblIPFTableAdapter.FillByTestNumber(dtbPTASDataSet.tblIPF, Convert.ToDecimal(testNumberTextBox.Text));
            tblTTRTableAdapter.FillByTestNumber(dtbPTASDataSet.tblTTR, Convert.ToDecimal(testNumberTextBox.Text));
            tblWindingTableAdapter.FillByTestNumber(dtbPTASDataSet.tblWinding, Convert.ToDecimal(testNumberTextBox.Text));
            tblDielectricTableAdapter.FillByTestNumber(dtbPTASDataSet.tblDielectric, Convert.ToDecimal(testNumberTextBox.Text));
            tblOilPFTableAdapter.FillByTestNumber(dtbPTASDataSet.tblOilPF, Convert.ToDecimal(testNumberTextBox.Text));
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tblTestBindingSource.MoveLast();
            //OnDataChanged(testNumberTextBox.Text);
            tblExcitationTableAdapter.FillByTestNumber(dtbPTASDataSet.tblExcitation, Convert.ToDecimal(testNumberTextBox.Text));
            tblBushingTableAdapter.FillByTestNumber(dtbPTASDataSet.tblBushing, Convert.ToDecimal(testNumberTextBox.Text));
            tblIPFTableAdapter.FillByTestNumber(dtbPTASDataSet.tblIPF, Convert.ToDecimal(testNumberTextBox.Text));
            tblTTRTableAdapter.FillByTestNumber(dtbPTASDataSet.tblTTR, Convert.ToDecimal(testNumberTextBox.Text));
            tblWindingTableAdapter.FillByTestNumber(dtbPTASDataSet.tblWinding, Convert.ToDecimal(testNumberTextBox.Text));
            tblDielectricTableAdapter.FillByTestNumber(dtbPTASDataSet.tblDielectric, Convert.ToDecimal(testNumberTextBox.Text));
            tblOilPFTableAdapter.FillByTestNumber(dtbPTASDataSet.tblOilPF, Convert.ToDecimal(testNumberTextBox.Text));
        }

        private void viewGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGraph f = new frmGraph();

            f.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport f = new frmReport();
            f.Show();

            OnPassTestNumber(testNumberTextBox.Text);
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 f = new AboutBox1();
            f.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to exit?", "Exit?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int record = Convert.ToInt32(tblTestTableAdapter.CountAvailable(Convert.ToDecimal(txtSearch.Text)));
            if (record == 1)
            {
                //tblTestTableAdapter.FillByTestNumber(dtbPTASDataSet.tblTest, Convert.ToDecimal(txtSearch.Text));
                int item = tblTestBindingSource.Find("TestNumber", txtSearch.Text);
                tblTestBindingSource.Position = item;

                tblExcitationTableAdapter.FillByTestNumber(dtbPTASDataSet.tblExcitation, Convert.ToDecimal(testNumberTextBox.Text));
                tblBushingTableAdapter.FillByTestNumber(dtbPTASDataSet.tblBushing, Convert.ToDecimal(testNumberTextBox.Text));
                tblIPFTableAdapter.FillByTestNumber(dtbPTASDataSet.tblIPF, Convert.ToDecimal(testNumberTextBox.Text));
                tblTTRTableAdapter.FillByTestNumber(dtbPTASDataSet.tblTTR, Convert.ToDecimal(testNumberTextBox.Text));
                tblWindingTableAdapter.FillByTestNumber(dtbPTASDataSet.tblWinding, Convert.ToDecimal(testNumberTextBox.Text));
                tblDielectricTableAdapter.FillByTestNumber(dtbPTASDataSet.tblDielectric, Convert.ToDecimal(testNumberTextBox.Text));
                tblOilPFTableAdapter.FillByTestNumber(dtbPTASDataSet.tblOilPF, Convert.ToDecimal(testNumberTextBox.Text));

                MessageBox.Show("Results found and loaded.");
            }
            else MessageBox.Show("No results found.");
        }

        private void btnComputeExc_Click(object sender, EventArgs e)
        {
            float[] exc = new float[3];

            var textboxes = groupBox1.Controls.
                            OfType<TextBox>().
                            OrderByDescending(v => v.Text).
                            ToArray();

            for (int i = 0; i < 3; i++)
            {
                exc[i] = float.Parse(textboxes[i].Text);
            }

            float difference = Math.Abs(exc[0] - exc[1]);
            float result = (float)Math.Round((difference / exc[1]) * 100, 2);

            txtDeviation.Text = result.ToString();

            exc = null;
        }

        private void btnAssessExc_Click(object sender, EventArgs e)
        {
            float[] exc = new float[3];
            var textboxes = groupBox1.Controls.
                            OfType<TextBox>().
                            OrderByDescending(v => v.Text).
                            ToArray();

            for (int i = 0; i < 3; i++)
            {
                exc[i] = float.Parse(textboxes[i].Text);
            }
            float result = (float)Math.Round((Math.Abs(exc[0] - exc[1]) / exc[1]) * 100, 2);

            txtDeviation.Text = result.ToString();

            if (exc[0] <= 50 && exc[1] <= 50)
            {
                if (result <= 10)
                {
                    txtAssess.Text = "PASSED";
                }
                else
                {
                    txtAssess.Text = "FAILED";
                }
            }

            else
            {
                if (result <= 5)
                {
                    txtAssess.Text = "PASSED";
                }
                else
                {
                    txtAssess.Text = "FAILED";
                }
            }
            exc = null;
            textboxes = null;
        }

        private void btnAddExc_Click(object sender, EventArgs e)
        {
            tblExcitationBindingSource.AddNew();
            txtTestNumberExc.Text = testNumberTextBox.Text;
        }

        private void btnSaveExc_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Validate();
                tblExcitationBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dtbPTASDataSet);

                MessageBox.Show("Record saved.");
            }
            else Focus();
        }

        private void btnDeleteExc_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "DELETE FROM tblExcitation WHERE TestNumber = @testnumber";
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
                            tblExcitationTableAdapter.Fill(dtbPTASDataSet.tblExcitation);
                        }
                        catch
                        {
                            MessageBox.Show("An error has occurred.");
                        }
                    }
                    con.Close();
                }
            }
            else Focus();
        }

        private void btnAddBushing_Click(object sender, EventArgs e)
        {
            tblBushingBindingSource.AddNew();
            txtTestNumberBushing.Text = testNumberTextBox.Text;
        }

        private void btnSaveBushing_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                Validate();
                tblBushingBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dtbPTASDataSet);
            }
            else Focus();
        }

        private void btnAssessBushing_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);
            
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
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@xf", cboXf.SelectedValue.ToString());

                int record = Convert.ToInt32(cmd2.ExecuteScalar());

                if (record > 1)
                {
                    using (SqlCommand cmd3 = new SqlCommand(query3, con))
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

        private void btnDeleteBushing_Click(object sender, EventArgs e)
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

        private void btnAddIPF_Click(object sender, EventArgs e)
        {
            tblIPFBindingSource.AddNew();
            txtTestNumberIPF.Text = testNumberTextBox.Text;
        }

        private void btnSaveIPF_Click(object sender, EventArgs e)
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

        private void btnDeleteIPF_Click(object sender, EventArgs e)
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

        private void btnComputeIPF_Click(object sender, EventArgs e)
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

            if (truncated[0] != 0)
                ipfCCHCHLTextBox.Text = truncated[0].ToString();
            if (truncated[1] != 0)
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

        private void btnAssessIPF_Click(object sender, EventArgs e)
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
            float kv = 0;

            string query = "SELECT tblTest.TestNumber AS TestNumber, tblTransformer.xfID AS xfID, tblTransformer.xfPrimVolt AS xfPrimVolt FROM tblTest LEFT OUTER JOIN tblTransformer ON tblTest.testXformer = tblTransformer.xfID " +
                "WHERE tblTest.TestNumber = @testnumber";
            string query2 = "SELECT TOP 1 tblTest.testXformer, tblIPF.* FROM tblIPF LEFT OUTER JOIN tblTest ON tblIPF.TestNumber = tblTest.TestNumber " +
                "WHERE tblIPF.TestNumber < @testnumber ORDER BY tblIPF.TestNumber DESC";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
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

            for (int i = 0; i < 8; i++)
            {
                corrected[i] = float.Parse(tc[i].Text);
            }

            if (kv <= 230000)
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

            corrected = null;
            previous = null;
            previouscap = null;
            compare = null;
            tc = null;
        }

        private void btnAddTTR_Click(object sender, EventArgs e)
        {
            tblTTRBindingSource.AddNew();
            txtTestNumberTTR.Text = testNumberTextBox.Text;
        }

        private void btnSaveTTR_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Validate();
                tblTTRBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dtbPTASDataSet);

                MessageBox.Show("Record saved.");
            }
            else
                Focus();
        }

        private void btnDeleteTTR_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "DELETE FROM tblTTR WHERE TestNumber = @testnumber";
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
                            tblTTRTableAdapter.Fill(dtbPTASDataSet.tblTTR);
                        }
                        catch
                        {
                            MessageBox.Show("An error has occurred.");
                        }
                    }
                    con.Close();
                }
            }
            else Focus();
        }
        
        float[] compute = new float[6];
        float[] measure = new float[6];
        float[] previous = new float[6];

        private void btnComputeTTR_Click(object sender, EventArgs e)
        {
            float LVRatio = 0;
            float TVRatio = 0;
            string primary = "";
            string secondary = "";
            string auto = "";
            float secfactor;
            float tertfactor;
            int clock;

            string query = "SELECT * FROM tblTransformer WHERE xfID = @xfID";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@xfID", cboXf.SelectedValue.ToString());

                    con.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        primary = (dr["xfPrimW"].ToString());
                        secondary = (dr["xfSecW"].ToString());
                        auto = (dr["xfAuto"].ToString());
                        clock = Convert.ToInt32(dr["xfSecClock"].ToString());
                    }
                    con.Close();
                }
            }

            if (auto == "a")
            {
                secfactor = 1;
                switch (primary)
                {
                    case "YN" when secondary == "d ":
                        tertfactor = (float)(1 / 1.732);
                        break;
                    case "D " when secondary == "yn":
                        tertfactor = (float)1.732;
                        break;
                    default:
                        tertfactor = 1;
                        break;
                }
            }

            else
            {
                switch (primary)
                {
                    case "YN" when secondary == "d ":
                        secfactor = (float)(1 / 1.732);
                        break;
                    case "D " when secondary == "yn":
                        secfactor = (float)1.732;
                        break;
                    default:
                        secfactor = 1;
                        break;
                }
            }
            
            float hv = float.Parse(ttrHVTextBox.Text);
            float lv = float.Parse(ttrLVTextBox.Text);
            float.TryParse(ttrTVTextBox.Text, out float tv);

            LVRatio = hv / lv;
            ttrRHVLVTextBox.Text = LVRatio.ToString();
            if (tv != 0)
            {
                TVRatio = hv / tv;
                ttrRHVTVTextBox.Text = TVRatio.ToString();
            }

            var measured = grpMeasured.Controls.
                           OfType<TextBox>().
                           OrderBy(v => v.TabIndex).
                           ToArray();

            var error = grpError.Controls.
                        OfType<TextBox>().
                        OrderBy(v => v.TabIndex).
                        ToArray();

            if (Array.TrueForAll(measured, v => string.IsNullOrWhiteSpace(v.Text)))
                MessageBox.Show("Please input a value in the textbox(es) in 'measured' group box.");
            else
            {
                for (int i = 0; i < 6; i++)
                {
                    float.TryParse(measured[i].Text, out measure[i]);
                    float ratio;
                    if (i < 3) ratio = LVRatio;
                    else ratio = TVRatio;

                    compute[i] = (float)Math.Round(Math.Abs(((measure[i] - ratio) / ratio) * 100), 2);
                    if (string.IsNullOrWhiteSpace(measured[i].Text))
                        error[i].Text = compute[i].ToString();
                }
            }
        }

        private void btnAssessTTR_Click(object sender, EventArgs e)
        {
            if (Array.TrueForAll(compute, v => v <= 0.5))
            {
                string query = "SELECT testXformer FROM tblTest WHERE TestNumber = @testnumber";
                string query2 = "SELECT TOP 1 tblTest.testXformer, tblTTR.* FROM tblTTR LEFT OUTER JOIN" +
                    "tblTest ON tblTTR.TestNumber = tblTest.TestNumber ORDER BY tblTTR.TestNumber DESC" +
                    "WHERE tblTTR.TestNumber < @testnumber";

                float[] diff = new float[6];

                string xf;

                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);

                        con.Open();

                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            xf = (dr["tblTest.testXformer"].ToString());
                        }

                        using (SqlCommand cmd2 = new SqlCommand(query2, con))
                        {
                            cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);

                            SqlDataReader dr2 = cmd2.ExecuteReader();
                            while (dr2.Read())
                            {
                                float.TryParse(dr2["ttrAHVLVe"].ToString(), out previous[0]);
                                float.TryParse(dr2["ttrBHVLVe"].ToString(), out previous[1]);
                                float.TryParse(dr2["ttrCHVLVe"].ToString(), out previous[2]);
                                float.TryParse(dr2["ttrAHVTVe"].ToString(), out previous[3]);
                                float.TryParse(dr2["ttrBHVTVe"].ToString(), out previous[4]);
                                float.TryParse(dr2["ttrCHVTVe"].ToString(), out previous[5]);
                            }
                        }
                    }
                    con.Close();
                }

                for (int i = 0; i < 6; i++)
                {
                    diff[i] = (float)Math.Round(Math.Abs(((previous[i] - compute[i]) / previous[i]) * 100),2);
                }

                if (Array.TrueForAll(diff, v => v <= 0.5)) txtAssess.Text = "PASSED";
                else txtAssess.Text = "INVESTIGATE WINDING";
            }
            else txtAssess.Text = "FAILED";
        }

        private void btnAddWinding_Click(object sender, EventArgs e)
        {
            tblWindingBindingSource.AddNew();
            txtTestNumberWinding.Text = testNumberTextBox.Text;
        }

        private void btnSaveWinding_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Validate();
                tblTTRBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dtbPTASDataSet);

                MessageBox.Show("Record saved.");
            }
            else Focus();
        }

        private void btnDeleteWinding_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "DELETE FROM tblWinding WHERE TestNumber = @testnumber";
            dtbPTASDataSet ds = new dtbPTASDataSet();

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

        private void btnAssessWinding_Click(object sender, EventArgs e)
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

            for (int i = 0; i < 3; i++)
            {
                float.TryParse(hv[i].Text, out high[i]);
                float.TryParse(lv[i].Text, out low[i]);
                float.TryParse(tv[i].Text, out tert[i]);
            }

            float sumhigh = 0; float sumlow = 0; float sumtert = 0;
            for (int i = 0; i < 3; i++)
            {
                sumhigh += high[i];
                sumlow += low[i];
                sumtert += tert[i];
            }

            highave = sumhigh / hv.Length;
            lowave = sumlow / lv.Length;
            tertave = sumtert / tv.Length;

            for (int i = 0; i < 3; i++)
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

            high = null;
            low = null;
            tert = null;
            highdiff = null;
            lowdiff = null;
            tertdiff = null;
            hv = null;
            lv = null;
            tv = null;
        }

        private void standardComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(standardComboBox.Text))
            {
                string standardID = standardComboBox.SelectedValue.ToString();
                refreshstatus(standardID);
            }
        }

        private void btnAddDielectric_Click(object sender, EventArgs e)
        {
            tblDielectricBindingSource.AddNew();
            txtTestNumberDielectric.Text = testNumberTextBox.Text;
        }

        private void btnSaveDielectric_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {

                Validate();
                tblDielectricBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dtbPTASDataSet);
            }
            else
                Focus();
        }

        private void btnDeleteDielectric_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "DELETE FROM tblDielectric WHERE TestNumber = @testnumber";
            DataSet ds = dtbPTASDataSet;

            DialogResult dr = MessageBox.Show("Do you wish to delete this record? This action cannot be undone.",
                "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                            tblDielectricTableAdapter.Fill(dtbPTASDataSet.tblDielectric);
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
                this.Focus();
        }

        private void btnComputeDielectric_Click(object sender, EventArgs e)
        {
            float[] main = new float[5];
            float[] oltc = new float[5];

            var textmain = grpMain.Controls.
                           OfType<TextBox>().
                           ToArray();

            var textoltc = grpOLTC.Controls.
                           OfType<TextBox>().
                           ToArray();

            for (int i = 0; i < 5; i++)
            {
                if (!string.IsNullOrWhiteSpace(textmain[i].Text))
                {
                    main[i] = float.Parse(textmain[i].Text);
                }

                if (!string.IsNullOrWhiteSpace(textoltc[i].Text))
                {
                    oltc[i] = float.Parse(textoltc[i].Text);
                }
            }

            mainAveTextBox.Text = ((main.Sum()) / main.Count()).ToString();
            oltcAveTextBox.Text = ((oltc.Sum()) / oltc.Count()).ToString();
        }

        private void btnAssessDielectric_Click(object sender, EventArgs e)
        {
            float main = 0;
            float oltc = 0;

            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            float kv;
            string query = "SELECT xfPrimVolt FROM tblTransformer WHERE xfID = @xfID";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@xfID", cboXf.SelectedValue.ToString());

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        kv = float.Parse(dr["xfPrimVolt"].ToString());
                    }
                    con.Close();
                }
            }

            if (!string.IsNullOrEmpty(mainAveTextBox.Text))
                float.TryParse(mainAveTextBox.Text, out main);
            if (!string.IsNullOrEmpty(oltcAveTextBox.Text))
                float.TryParse(oltcAveTextBox.Text, out oltc);

            if (standardComboBox.SelectedValue.ToString() == "ASTM D1816")
            {
                if (statusComboBox.SelectedValue.ToString() == "AGED")
                {

                }
            }

            else
            {
                if (main < 26)
                {
                    txtMainAssess.Text = "FAILED";
                }
                else
                {
                    txtMainAssess.Text = "PASSED";
                }
            }
        }

        private void btnAddOilPF_Click(object sender, EventArgs e)
        {
            tblOilPFBindingSource.AddNew();
            txtTestNumberOilPF.Text = testNumberTextBox.Text;
        }

        private void btnSaveOilPF_Click(object sender, EventArgs e)
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

        private void btnDeleteOilPF_Click(object sender, EventArgs e)
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

        private void btnAssessOilPF_Click(object sender, EventArgs e)
        {
            string main = "";
            string oltc = "";

            string query = "SELECT TOP 1 tblOilPF.*, tblTest.testXformer FROM tblOilPF LEFT OUTER JOIN tblTest ON " +
                "tblOilPF.TestNumber = tblTest.TestNumber WHERE TestNumber < @testnumber AND testXformer = @transformer ORDER BY TestNumber DESC";

            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd2 = new SqlCommand(query, con))
                {
                    cmd2.Parameters.AddWithValue("@testnumber", txtTestNumberOilPF.Text);
                    cmd2.Parameters.AddWithValue("@transformer", cboXf.SelectedValue.ToString());

                    SqlDataReader dr2 = cmd2.ExecuteReader();

                    while (dr2.Read())
                    {
                        main = (dr2["pfMain"].ToString());
                        oltc = (dr2["pfOLTC"].ToString());
                    }
                }
                con.Close();
            }

            if (pfMainTextBox.Text != "")
            {
                float pfmain = float.Parse(pfMainTextBox.Text);

                //if (pfmain < 0)
                //    txtAssessMain.Text = "FAILED";
                if (pfmain >= 0 && pfmain <= 0.5)
                {
                    float.TryParse(main, out float prevmain);
                    float maindiff = ((pfmain - prevmain) / pfmain) * 100;

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

            if (pfOLTCTextBox.Text != "")
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
