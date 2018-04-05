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
            refreshstandard();

            frmLogin f = new frmLogin();
            f.Dispose();
        }

        public void refreshstandard()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblStandards", con))
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
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT status FROM tblStatus WHERE standards = @standards", con))
                {
                    cmd.Parameters.AddWithValue("@standards", standardID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Validate();
                    tblTestBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(dtbPTASDataSet);

                    MessageBox.Show("Record saved.");

                    tblTestTableAdapter.Fill(dtbPTASDataSet.tblTest);

                    btnAdd.Enabled = true;
                    btnPrev.Enabled = true;
                    btnNext.Enabled = true;
                    btnFirst.Enabled = true;
                    btnLast.Enabled = true;
                }
                catch(NoNullAllowedException)
                {
                    MessageBox.Show("Fill the required fields.", "NoNullAllowedException", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("Duplicate records.", "ConstraintException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
                Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //chkExcite.Checked = false;
            //chkIPF.Checked = false;
            //chkBushing.Checked = false;
            //chkTTR.Checked = false;
            //chkDCWR.Checked = false;
            //chkDielectric.Checked = false;
            //chkOilPF.Checked = false;
            tblTestBindingSource.AddNew();
            btnAdd.Enabled = false;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
            btnFirst.Enabled = false;
            btnLast.Enabled = false;
            //chkExcite.Checked = false;
            //chkIPF.Checked = false;
            //chkBushing.Checked = false;
            //chkTTR.Checked = false;
            //chkDCWR.Checked = false;
            //chkDielectric.Checked = false;
            //chkOilPF.Checked = false;
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

                        //ds.Clear();
                        tblTestTableAdapter.Fill(dtbPTASDataSet.tblTest);
                        con.Close();

                        btnAdd.Enabled = true;
                        btnPrev.Enabled = true;
                        btnNext.Enabled = true;
                        btnFirst.Enabled = true;
                        btnLast.Enabled = true;
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
        }

        public delegate void PassTestNumber(string TestNumber);

        public static event PassTestNumber OnPassTestNumber;

        private void registerAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegister f = new frmRegister();
            f.Show();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tblTestBindingSource.MoveFirst();

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
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int record = Convert.ToInt32(tblTestTableAdapter.CountAvailable(Convert.ToDecimal(txtSearch.Text)));
                if (record == 1)
                {
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
            catch(FormatException)
            {
                MessageBox.Show("Search box is not filled up.");
            }
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
            textboxes = null;
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

            Array.Sort(exc, new Comparison<float>((i1, i2) => i2.CompareTo(i1)));

            label117.Text = exc[0].ToString();
            label118.Text = exc[1].ToString();
            label119.Text = exc[2].ToString();

            float result = (float)Math.Round((Math.Abs(exc[0] - exc[1]) / exc[1]) * 100, 2);

            txtDeviation.Text = result.ToString();

            if (exc[0] <= 50 && exc[1] <= 50)
            {
                if (result <= 10)
                {
                    txtAssessExc.Text = "PASSED";
                }
                else
                {
                    txtAssessExc.Text = "FAILED";
                }
            }

            else
            {
                if (result <= 5)
                {
                    txtAssessExc.Text = "PASSED";
                }
                else
                {
                    txtAssessExc.Text = "FAILED";
                }
            }
            exc = null;
            textboxes = null;
        }

        private void btnAddExc_Click(object sender, EventArgs e)
        {
            tblExcitationBindingSource.AddNew();
            txtTestNumberExc.Text = testNumberTextBox.Text;

            btnAddExc.Enabled = false;
        }

        private void btnSaveExc_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Validate();
                    tblExcitationBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(dtbPTASDataSet);

                    MessageBox.Show("Record saved.");
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("Duplicate records.", "ConstraintException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (NoNullAllowedException)
                {
                    MessageBox.Show("No Test Number detected. Please make sure the test number is inputted through the add button.", 
                        "NoNullAllowedException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else Focus();

            btnAddExc.Enabled = true;
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
                        con.Open();
                        try
                        {
                            cmd.Parameters.AddWithValue("@testnumber", txtTestNumberExc.Text);
                            
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record deleted.");

                            tblExcitationTableAdapter.FillByTestNumber(dtbPTASDataSet.tblExcitation, Convert.ToDecimal(testNumberTextBox.Text));
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

            btnAddBushing.Enabled = false;
        }

        private void btnSaveBushing_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    Validate();
                    tblBushingBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(dtbPTASDataSet);

                    MessageBox.Show("Record saved.");
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("Duplicate records.", "ConstraintException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (NoNullAllowedException)
                {
                    MessageBox.Show("No Test Number detected. Please make sure the test number is inputted through the add button.",
                        "NoNullAllowedException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else Focus();

            btnAddBushing.Enabled = true;
        }

        private void btnAssessBushing_Click(object sender, EventArgs e)
        {
            int[] c1pf = GetC1pfAssess();
            int[] c1cap = GetC1CapAssess();
            int[] c2pf = GetC2pfAssess();

            int[] h1 = new int[3] { c1pf[0], c1cap[0], c2pf[0] };
            int[] h2 = new int[3] { c1pf[1], c1cap[1], c2pf[1] };
            int[] h3 = new int[3] { c1pf[2], c1cap[2], c2pf[2] };
            int[] h0x0 = new int[3] { c1pf[3], c1cap[3], c2pf[3] };
            int[] x1 = new int[3] { c1pf[4], c1cap[4], c2pf[4] };
            int[] x2 = new int[3] { c1pf[5], c1cap[5], c2pf[5] };
            int[] x3 = new int[3] { c1pf[6], c1cap[6], c2pf[6] };

            var assess = grpAssess.Controls.OfType<TextBox>().OrderBy(v => v.TabIndex).ToArray();

            if (Array.TrueForAll(h1, v => v == 0)) assess[0].Text = "";
            else if (Array.Exists(h1, v => v == 4)) assess[0].Text = "FAILED";
            else if (Array.Exists(h1, v => v == 3)) assess[0].Text = "MONITOR BUSHING";
            else if (Array.Exists(h1, v => v == 2)) assess[0].Text = "INVESTIGATE";
            else assess[0].Text = "PASSED";

            if (Array.TrueForAll(h2, v => v == 0)) assess[1].Text = "";
            else if (Array.Exists(h2, v => v == 4)) assess[1].Text = "FAILED";
            else if (Array.Exists(h2, v => v == 3)) assess[1].Text = "MONITOR BUSHING";
            else if (Array.Exists(h2, v => v == 2)) assess[1].Text = "INVESTIGATE";
            else assess[1].Text = "PASSED";

            if (Array.TrueForAll(h3, v => v == 0)) assess[2].Text = "";
            else if (Array.Exists(h3, v => v == 4)) assess[2].Text = "FAILED";
            else if (Array.Exists(h3, v => v == 3)) assess[2].Text = "MONITOR BUSHING";
            else if (Array.Exists(h3, v => v == 2)) assess[2].Text = "INVESTIGATE";
            else assess[2].Text = "PASSED";

            if (Array.TrueForAll(h0x0, v => v == 0)) assess[3].Text = "";
            else if (Array.Exists(h0x0, v => v == 4)) assess[3].Text = "FAILED";
            else if (Array.Exists(h0x0, v => v == 3)) assess[3].Text = "MONITOR BUSHING";
            else if (Array.Exists(h0x0, v => v == 2)) assess[3].Text = "INVESTIGATE";
            else assess[3].Text = "PASSED";

            if (Array.TrueForAll(x1, v => v == 0)) assess[4].Text = "";
            else if (Array.Exists(x1, v => v == 4)) assess[4].Text = "FAILED";
            else if (Array.Exists(x1, v => v == 3)) assess[4].Text = "MONITOR BUSHING";
            else if (Array.Exists(x1, v => v == 2)) assess[4].Text = "INVESTIGATE";
            else assess[4].Text = "PASSED";

            if (Array.TrueForAll(x2, v => v == 0)) assess[5].Text = "";
            else if (Array.Exists(x2, v => v == 4)) assess[5].Text = "FAILED";
            else if (Array.Exists(x2, v => v == 3)) assess[5].Text = "MONITOR BUSHING";
            else if (Array.Exists(x2, v => v == 2)) assess[5].Text = "INVESTIGATE";
            else assess[5].Text = "PASSED";

            if (Array.TrueForAll(x3, v => v == 0)) assess[6].Text = "";
            else if (Array.Exists(x3, v => v == 4)) assess[6].Text = "FAILED";
            else if (Array.Exists(x3, v => v == 3)) assess[6].Text = "MONITOR BUSHING";
            else if (Array.Exists(x3, v => v == 2)) assess[6].Text = "INVESTIGATE";
            else assess[6].Text = "PASSED";

            c1pf = null;
            c2pf = null;
            c1cap = null;
            h1 = null;
            h2 = null;
            h3 = null;
            h0x0 = null;
            x1 = null;
            x2 = null;
            x3 = null;
        }

        private void btnDeleteBushing_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "DELETE FROM tblBushing WHERE TestNumber = @testnumber";

            DialogResult dr = MessageBox.Show("Do you wish to delete this record? This action cannot be undone.", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        try
                        {
                            cmd.Parameters.AddWithValue("@testnumber", txtTestNumberBushing.Text);
                            
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record deleted.");

                            tblBushingTableAdapter.FillByTestNumber(dtbPTASDataSet.tblBushing, Convert.ToDecimal(testNumberTextBox.Text));
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

            btnAddIPF.Enabled = false;
        }

        private void btnSaveIPF_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);
            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {

                try
                {
                    Validate();
                    tblIPFBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(dtbPTASDataSet);

                    MessageBox.Show("Record saved.");
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("Duplicate records.", "ConstraintException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (NoNullAllowedException)
                {
                    MessageBox.Show("No Test Number detected. Please make sure the test number is inputted through the add button.",
                        "NoNullAllowedException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                Focus();

            btnAddIPF.Enabled = true;
        }

        private void btnDeleteIPF_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "DELETE FROM tblIPF WHERE TestNumber = @testnumber";

            DialogResult dr = MessageBox.Show("Do you wish to delete this record? This action cannot be undone.", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        try
                        {
                            cmd.Parameters.AddWithValue("@testnumber", txtTestNumberIPF.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record deleted.");
                            
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

            measured = null;
            capacitance = null;
            tm = null;
            cap = null;
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
                    cmd.Parameters.AddWithValue("@testnumber", txtTestNumberIPF.Text);

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
                        cmd2.Parameters.AddWithValue("@testnumber", txtTestNumberIPF.Text);

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
                float.TryParse(tc[i].Text, out corrected[i]);
            }

            if (kv <= 230000)
            {
                if (Array.TrueForAll(corrected, v => v <= 0.5))
                {
                    txtAssessIPF.Text = "PASSED";
                }
                else if (Array.TrueForAll(corrected, v => v > 1))
                {
                    txtAssessIPF.Text = "FAILED";
                }
                else
                {
                    int[] check = new int[8];
                    for (int i = 0; i < 8; i++)
                    {
                        if (corrected[i] > 0.5)
                        {
                            if (previous[i] <= 0.5) txtAssessIPF.Text = "INVESTIGATE";
                            else txtAssessIPF.Text = "MONITOR";
                        }
                    }
                }
            }

            else
            {
                if (Array.TrueForAll(corrected, v => v <= 0.4))
                {
                    txtAssessIPF.Text = "PASSED";
                }
                else if (Array.TrueForAll(corrected, v => v > 1))
                {
                    txtAssessIPF.Text = "FAILED";
                }
                else
                {
                    int[] check = new int[8];
                    for (int i = 0; i < 8; i++)
                    {
                        if (corrected[i] > 0.5)
                        {
                            if (previous[i] <= 0.5) txtAssessIPF.Text = "INVESTIGATE";
                            else txtAssessIPF.Text = "MONITOR";
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

            btnAddTTR.Enabled = false;
        }

        private void btnSaveTTR_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Validate();
                    tblTTRBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(dtbPTASDataSet);

                    MessageBox.Show("Record saved.");
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("Duplicate records.", "ConstraintException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (NoNullAllowedException)
                {
                    MessageBox.Show("No Test Number detected. Please make sure the test number is inputted through the add button.",
                        "NoNullAllowedException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                Focus();

            btnAddTTR.Enabled = true;
        }

        private void btnDeleteTTR_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "DELETE FROM tblTTR WHERE TestNumber = @testnumber";

            DialogResult dr = MessageBox.Show("Do you wish to delete this record? This action cannot be undone.", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@testnumber", txtTestNumberTTR.Text);
                        con.Open();

                        try
                        {
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record deleted.");
                            tblTTRTableAdapter.FillByTestNumber(dtbPTASDataSet.tblTTR, Convert.ToDecimal(testNumberTextBox.Text));
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



        private void btnComputeTTR_Click(object sender, EventArgs e)
        {
            float[] compute = new float[6];
            float[] measure = new float[6];
            float[] previous = new float[6];

            float LVRatio = 0;
            float TVRatio = 0;
            string primary = "";
            string secondary = "";
            string auto = "";
            float secfactor = 0;
            float tertfactor = 0;
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
                        tertfactor = (float)(1.732);
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

            LVRatio = (float)Math.Round((hv / lv) * secfactor, 4);
            ttrRHVLVTextBox.Text = LVRatio.ToString();
            if (tv != 0)
            {
                TVRatio = (float)Math.Round((hv / tv) * tertfactor, 4);
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

            //var measured = grpMeasured.Controls.OfType<TextBox>().OrderBy(v => v.TabIndex).ToArray();
            //var error = grpError.Controls.OfType<TextBox>().OrderBy(v => v.TabIndex).ToArray();

            if (Array.TrueForAll(measured, v => string.IsNullOrWhiteSpace(v.Text)))
                MessageBox.Show("Please input a value in the textbox(es) in 'measured' group box.");
            else
            {
                //float.TryParse(ttrAHVLVTextBox.Text, out measure[0]);
                //float.TryParse(ttrBHVLVTextBox.Text, out measure[1]);
                //float.TryParse(ttrCHVLVTextBox.Text, out measure[3]);
                //float.TryParse(ttrAHVTVTextBox.Text, out measure[4]);
                //float.TryParse(ttrBHVTVTextBox.Text, out measure[5]);
                //float.TryParse(ttrCHVTVTextBox.Text, out measure[0]);
                for (int i = 0; i < 6; i++)
                {
                    float.TryParse(measured[i].Text, out measure[i]);
                    float ratio;
                    if (i < 3) ratio = LVRatio;
                    else ratio = TVRatio;

                    compute[i] = (float)Math.Round(Math.Abs(((measure[i] - ratio) / ratio) * 100), 2);
                    if (!string.IsNullOrWhiteSpace(measured[i].Text)) error[i].Text = compute[i].ToString();
                }
            }

            btnAssessTTR.Enabled = true;
        }

        private void btnAssessTTR_Click(object sender, EventArgs e)
        {
            float[] compute = new float[6];
            float[] previous = new float[6];
            float[] present = new float[6];

            var error = grpError.Controls.
                        OfType<TextBox>().
                        OrderBy(v => v.TabIndex).
                        ToArray();

            var measured = grpMeasured.Controls.
                           OfType<TextBox>().
                           OrderBy(v => v.TabIndex).
                           ToArray();

            for (int i = 0; i < 6; i++)
            {
                float.TryParse(error[i].Text, out compute[i]);
                float.TryParse(measured[i].Text, out present[i]);
            }

            if (Array.TrueForAll(compute, v => v <= 0.5)) txtAssessTTR.Text = "PASSED";
            else
            {
                string query = "SELECT COUNT (*) FROM tblTTR LEFT OUTER JOIN tblTest ON tblTTR.TestNumber = tblTest.TestNumber " +
                    "WHERE testXformer = @xf";
                string query2 = "SELECT TOP 1 tblTest.testXformer, tblTTR.* FROM tblTTR LEFT OUTER JOIN " +
                    "tblTest ON tblTTR.TestNumber = tblTest.TestNumber " +
                    "WHERE tblTTR.TestNumber < @testnumber AND testXformer = @xf " +
                    "ORDER BY tblTTR.TestNumber DESC";

                float[] diff = new float[6];

                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@xf", cboXf.SelectedValue.ToString());
                        int record = Convert.ToInt32(cmd.ExecuteScalar());
                        if (record > 1)
                        {
                            using (SqlCommand cmd2 = new SqlCommand(query2, con))
                            {
                                cmd2.Parameters.AddWithValue("@testnumber", txtTestNumberTTR.Text);
                                cmd2.Parameters.AddWithValue("@xf", cboXf.SelectedValue.ToString());

                                SqlDataReader dr2 = cmd2.ExecuteReader();
                                while (dr2.Read())
                                {
                                    float.TryParse(dr2["ttrAHVLV"].ToString(), out previous[0]);
                                    float.TryParse(dr2["ttrBHVLV"].ToString(), out previous[1]);
                                    float.TryParse(dr2["ttrCHVLV"].ToString(), out previous[2]);
                                    float.TryParse(dr2["ttrAHVTV"].ToString(), out previous[3]);
                                    float.TryParse(dr2["ttrBHVTV"].ToString(), out previous[4]);
                                    float.TryParse(dr2["ttrCHVTV"].ToString(), out previous[5]);
                                }
                                for (int i = 0; i < 6; i++)
                                {
                                    diff[i] = (float)Math.Round(Math.Abs((previous[i] - present[i])), 2);
                                }
                            }
                        }
                    }
                    con.Close();
                }
                if (Array.TrueForAll(diff, v => v >= 0.5)) txtAssessTTR.Text = "INVESTIGATE WINDING";
                else txtAssessTTR.Text = "FAILED";

                btnAssessTTR.Enabled = false;

                compute = null;
                diff = null;
                previous = null;
                present = null;
                error = null;
                measured = null;
            }
        }

        private void btnAddWinding_Click(object sender, EventArgs e)
        {
            tblWindingBindingSource.AddNew();
            txtTestNumberWinding.Text = testNumberTextBox.Text;

            btnAddWinding.Enabled = false;
        }

        private void btnSaveWinding_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Validate();
                    tblTTRBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(dtbPTASDataSet);

                    MessageBox.Show("Record saved.");
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("Duplicate records.", "ConstraintException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (NoNullAllowedException)
                {
                    MessageBox.Show("No Test Number detected. Please make sure the test number is inputted through the add button.",
                        "NoNullAllowedException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else Focus();

            btnAddWinding.Enabled = true;
        }

        private void btnDeleteWinding_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "DELETE FROM tblWinding WHERE TestNumber = @testnumber";

            DialogResult dr = MessageBox.Show("Do you wish to delete this record? This action cannot be undone.", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@testnumber", txtTestNumberWinding.Text);
                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record deleted.");
                            tblWindingTableAdapter.FillByTestNumber(dtbPTASDataSet.tblWinding, Convert.ToDecimal(testNumberTextBox.Text));
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
            float[] high = new float[3];
            float[] low = new float[3];
            float[] tert = new float[3];

            float highdiff = 0; float lowdiff = 0; float tertdiff = 0;

            var hv = grpHV.Controls.OfType<TextBox>().OrderByDescending(v => v.TabIndex).ToArray();
            var lv = grpLV.Controls.OfType<TextBox>().OrderByDescending(v => v.TabIndex).ToArray();
            var tv = grpTV.Controls.OfType<TextBox>().OrderByDescending(v => v.TabIndex).ToArray();

            for (int i = 0; i < 3; i++)
            {
                float.TryParse(hv[i].Text, out high[i]);
                float.TryParse(lv[i].Text, out low[i]);
                float.TryParse(tv[i].Text, out tert[i]);
            }

            highdiff = ((high[0] - high[2]) / high[2]) * 100;
            lowdiff = ((low[0] - low[2]) / low[2]) * 100;
            tertdiff = ((tert[0] - tert[2]) / tert[2]) * 100;

            if (highdiff <= 1) txtAssessHigh.Text = "PASSED";
            else txtAssessHigh.Text = "FAILED";

            if (lowdiff <= 1) txtAssessLow.Text = "PASSED";
            else txtAssessLow.Text = "FAILED";

            if (Array.TrueForAll(tv, v => !string.IsNullOrEmpty(v.Text)))
            {
                if (tertdiff <= 1) txtAssessTert.Text = "PASSED";
                else txtAssessTert.Text = "FAILED";
            }
            else txtAssessTert.Text = "";

            high = null;
            low = null;
            tert = null;
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

            btnAddDielectric.Enabled = false;
        }

        private void btnSaveDielectric_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {

                try
                {
                    Validate();
                    tblDielectricBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(dtbPTASDataSet);

                    MessageBox.Show("Record saved.");
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("Duplicate records.", "ConstraintException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (NoNullAllowedException)
                {
                    MessageBox.Show("No Test Number detected. Please make sure the test number is inputted through the add button.",
                        "NoNullAllowedException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                Focus();

            btnAddDielectric.Enabled = true;
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
                        cmd.Parameters.AddWithValue("@testnumber", txtTestNumberDielectric.Text);
                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record deleted.");

                            tblDielectricTableAdapter.FillByTestNumber(dtbPTASDataSet.tblDielectric, Convert.ToDecimal(testNumberTextBox.Text));
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
            if(Array.TrueForAll(textoltc, v => v.Text != "")) oltcAveTextBox.Text = ((oltc.Sum()) / oltc.Count()).ToString();

            btnAssessDielectric.Enabled = true;
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
                MessageBox.Show("ASTM D1816 under construction. Use ASTM D877 instead.");
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
            btnAssessDielectric.Enabled = false;
        }

        private void btnAddOilPF_Click(object sender, EventArgs e)
        {
            tblOilPFBindingSource.AddNew();
            txtTestNumberOilPF.Text = testNumberTextBox.Text;

            btnAddOilPF.Enabled = false;
        }

        private void btnSaveOilPF_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Validate();
                    tblOilPFBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(dtbPTASDataSet);

                    MessageBox.Show("Record saved.");


                }
                catch (ConstraintException)
                {
                    MessageBox.Show("Duplicate records.", "ConstraintException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (NoNullAllowedException)
                {
                    MessageBox.Show("No Test Number detected. Please make sure the test number is inputted through the add button.",
                        "NoNullAllowedException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                Focus();

            btnAddOilPF.Enabled = true;
        }

        private void btnDeleteOilPF_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "DELETE FROM tblOilPF WHERE TestNumber = @testnumber";

            DialogResult dr = MessageBox.Show("Do you wish to delete this record? This action cannot be undone.", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@testnumber", txtTestNumberOilPF.Text);
                        con.Open();
                        try
                        {
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record deleted.");

                            tblOilPFTableAdapter.FillByTestNumber(dtbPTASDataSet.tblOilPF, Convert.ToDecimal(testNumberTextBox.Text));
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
                "tblOilPF.TestNumber = tblTest.TestNumber WHERE tblOilPF.TestNumber < @testnumber AND testXformer = @transformer ORDER BY TestNumber DESC";

            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
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

        private int[] GetC1pfAssess()
        {
            int[] C1pf = new int[7];

            var C1nameplate = grpNamepf.Controls.OfType<TextBox>().OrderBy(v => v.TabIndex).ToArray();
            var C1measured = grpC1pf.Controls.OfType<TextBox>().OrderBy(v => v.TabIndex).ToArray();

            float[] name = new float[7];
            float[] measured = new float[7];

            float[] error = new float[7];

            float[] diff = new float[7];

            float[] previous = new float[7];

            for (int i = 0; i < 7; i++)
            {
                float.TryParse(C1nameplate[i].Text, out name[i]);
                float.TryParse(C1measured[i].Text, out measured[i]);

                if (name[i] != 0 && measured[i] != 0)
                {
                    error[i] = (float)Math.Round((Math.Abs(name[i] - measured[i]) / name[i]) * 100, 4);

                    if (error[i] <= 0.25) C1pf[i] = 1;
                    else if (error[i] > 0.25 && error[i] <= 0.5)
                    {
                        previous = GetC1pfPrevious();
                        if (previous[i] != 0)
                        {
                            diff[i] = Math.Abs((previous[i] - measured[i]) / previous[i]) * 100;
                            if (diff[i] < 50) C1pf[i] = 2;
                            else C1pf[i] = 3;
                        }
                        else C1pf[i] = 0;
                    }
                    else C1pf[i] = 4;
                }

                else if (name[i] == 0 && measured[i] != 0)
                {
                    if (measured[i] > 0 && measured[i] <= 0.5) C1pf[i] = 1;
                    else if (measured[i] > 0.5 && measured[i] <= 1) C1pf[i] = 2;
                    else if (measured[i] < 0) C1pf[i] = 4;
                    else C1pf[i] = 3;
                }

                else C1pf[i] = 0;
            }

            return C1pf;

            //C1nameplate = null;
            //C1measured = null;
            //name = null;
            //measured = null;
            //diff = null;
        }

        private float[] GetC1pfPrevious()
        {
            float[] C1pfPrevious = new float[7];

            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "SELECT TOP 1 tblBushing.pfC1H1, tblBushing.pfC1H2, tblBushing.pfC1H3, " +
                "tblBushing.pfC1H0X0, tblBushing.pfC1X1, tblBushing.pfC1X2, tblBushing.pfC1X3 " +
                "FROM tblBushing LEFT OUTER JOIN tblTest ON tblBushing.TestNumber = tblTest.TestNumber " +
                "WHERE tblBushing.TestNumber < @testnumber AND testXformer = @xf ORDER BY tblBushing.TestNumber DESC";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", txtTestNumberBushing.Text);
                    cmd.Parameters.AddWithValue("@xf", cboXf.SelectedValue.ToString());

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        float.TryParse(dr["pfC1H1"].ToString(), out C1pfPrevious[0]);
                        float.TryParse(dr["pfC1H2"].ToString(), out C1pfPrevious[1]);
                        float.TryParse(dr["pfC1H3"].ToString(), out C1pfPrevious[2]);
                        float.TryParse(dr["pfC1H0X0"].ToString(), out C1pfPrevious[3]);
                        float.TryParse(dr["pfC1X1"].ToString(), out C1pfPrevious[4]);
                        float.TryParse(dr["pfC1X2"].ToString(), out C1pfPrevious[5]);
                        float.TryParse(dr["pfC1X3"].ToString(), out C1pfPrevious[6]);
                    }
                    con.Close();
                }
            }

            return C1pfPrevious;
        }

        private int[] GetC2pfAssess()
        {
            int[] C2pf = new int[7];

            var C2measured = grpC2pf.Controls.OfType<TextBox>().OrderBy(v => v.TabIndex).ToArray();

            float[] c2 = new float[7];

            for(int i =0; i < 7; i++)
            {
                float.TryParse(C2measured[i].Text, out c2[i]);
                if (c2[i] == 0) C2pf[i] = 0;
                else if (c2[i] > 0 && c2[i] <= 1) C2pf[i] = 1;
                else if (c2[i] > 1 && c2[i] <= 2) C2pf[i] = 2;
                else C2pf[i] = 4;
            }

            return C2pf;
        }

        private int[] GetC1CapAssess()
        {
            int[] C1cap = new int[7];

            var C1nameplate = grpName.Controls.OfType<TextBox>().OrderBy(v => v.TabIndex).ToArray();
            var C1measured = grpC1Cap.Controls.OfType<TextBox>().OrderBy(v => v.TabIndex).ToArray();

            float[] measured = new float[7];
            float[] nameplate = new float[7];
            float[] previous = new float[7];

            float[] diff = new float[7];

            previous = GetC1CapPrevious();

            for(int i = 0; i < 7; i++)
            {
                float.TryParse(C1nameplate[i].Text, out nameplate[i]);
                float.TryParse(C1measured[i].Text, out measured[i]);

                if (nameplate[i] != 0 && nameplate[i] > measured[i])
                {
                    diff[i] = ((nameplate[i] - measured[i]) / nameplate[i]) * 100;
                    if (diff[i] <= 8) C1cap[i] = 1;
                    else if (diff[i] > 8 && diff[i] <= 10) C1cap[i] = 2;
                    else C1cap[i] = 4;
                }

                else if (nameplate[i] == 0 && measured[i] != 0)
                {
                    if (previous[i] != 0)
                    {
                        diff[i] = Math.Abs((previous[i] - measured[i]) / previous[i]) * 100;
                        if (diff[i] <= 8) C1cap[i] = 1;
                        else if (diff[i] > 8 && diff[i] <= 10) C1cap[i] = 2;
                        else C1cap[i] = 4;
                    }
                    else C1cap[i] = 0;
                }

                else if (nameplate[i] != 0 && nameplate[i] < measured[i]) C1cap[i] = 4;
                else if (measured[i] == 0) C1cap[i] = 0;
            }

            return C1cap;
        }

        private float[] GetC1CapPrevious()
        {
            float[] C1capPrevious = new float[7];

            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "SELECT TOP 1 tblBushing.capC1H1, tblBushing.capC1H2, tblBushing.capC1H3, " +
                "tblBushing.capC1H0X0, tblBushing.capC1X1, tblBushing.capC1X2, tblBushing.capC1X3 " +
                "FROM tblBushing LEFT OUTER JOIN tblTest ON tblBushing.TestNumber = tblTest.TestNumber " +
                "WHERE tblBushing.TestNumber < @testnumber AND testXformer = @xf ORDER BY tblBushing.TestNumber DESC";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", txtTestNumberBushing.Text);
                    cmd.Parameters.AddWithValue("@xf", cboXf.SelectedValue.ToString());

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        float.TryParse(dr["capC1H1"].ToString(), out C1capPrevious[0]);
                        float.TryParse(dr["capC1H2"].ToString(), out C1capPrevious[1]);
                        float.TryParse(dr["capC1H3"].ToString(), out C1capPrevious[2]);
                        float.TryParse(dr["capC1H0X0"].ToString(), out C1capPrevious[3]);
                        float.TryParse(dr["capC1X1"].ToString(), out C1capPrevious[4]);
                        float.TryParse(dr["capC1X2"].ToString(), out C1capPrevious[5]);
                        float.TryParse(dr["capC1X3"].ToString(), out C1capPrevious[6]);
                    }
                    con.Close();
                }
            }

            return C1capPrevious;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "instruction.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void NumericKeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (textbox.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        //private void Validation(object sender, CancelEventArgs e)
        //{
        //    TextBox textbox = (TextBox)sender;
        //    ErrorProvider ep = new ErrorProvider();
        //    float f;
        //    if (!float.TryParse(textbox.Text, out f))
        //    {
        //        ep.SetError(textbox, "Numeric value required.");
        //        e.Cancel = true;
        //        return;
        //    }
        //    else ep.SetError(textbox, "");
        //}

        //private int[] GetC2CapAssess()
        //{

        //}
    }
}
