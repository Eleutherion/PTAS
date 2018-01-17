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
    public partial class frmMain : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dtbPTAS.mdf;Integrated Security=True");
        public frmMain()
        {
            InitializeComponent();
            refreshdata();
        }

        public void refreshdata()
        {
            using(SqlCommand cmd = new SqlCommand("SELECT * FROM tblSubstation", con))
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

        public void refreshstate(string subID)
        {
            using(SqlCommand cmd = new SqlCommand("SELECT xfID FROM tblTransformer WHERE xfSubID = @subID", con))
            {
                cmd.Parameters.AddWithValue("@subID", cboSub.SelectedValue.ToString());
                using(SqlDataAdapter sda = new SqlDataAdapter(cmd))
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

        private TabPage tabExcite = new TabPage();
        private TabPage tabIPF = new TabPage();
        private TabPage tabBushing = new TabPage();
        private TabPage tabTTR = new TabPage();
        private TabPage tabDCWR = new TabPage();
        private TabPage tabDielectric = new TabPage();
        private TabPage tabOilPF = new TabPage();

        private void chkExcite_CheckStateChanged(object sender, EventArgs e)
        {
            frmExcitation form = new frmExcitation
            {
                TopLevel = false
            };

            if (chkExcite.Checked)
            {
                tabExcite.Text = "Excitation Current";
                tbcTest.TabPages.Add(tabExcite);
                tabExcite.Show();

                form.Parent = tabExcite;
                form.Show();
            }
            else
            {
                tbcTest.SelectedIndex = 0;
                tabExcite.Hide();
                tbcTest.TabPages.Remove(tabExcite);
                form.Dispose();
            }
        }

        private void chkIPF_CheckStateChanged(object sender, EventArgs e)
        {
            frmIPF form = new frmIPF
            {
                TopLevel = false
            };

            if (chkIPF.Checked)
            {
                tabIPF.Text = "Insulation Power Factor";
                tbcTest.TabPages.Add(tabIPF);
                tabIPF.Show();

                form.Parent = tabIPF;
                form.Show();
            }
            else
            {
                if (tbcTest.SelectedIndex != 0)
                {
                    tbcTest.SelectedIndex = 0;
                }
                tabIPF.Hide();
                tbcTest.TabPages.Remove(tabIPF);
                form.Dispose();
            }
        }

        private void chkBushing_CheckStateChanged(object sender, EventArgs e)
        {
            frmBushing form = new frmBushing
            {
                TopLevel = false
            };

            if (chkBushing.Checked)
            {
                tabBushing.Text = "Bushing C1/C2";
                tbcTest.TabPages.Add(tabBushing);
                tabBushing.Show();

                form.Parent = tabBushing;
                form.Show();
            }
            else
            {
                if(tbcTest.SelectedIndex != 0)
                {
                    tbcTest.SelectedIndex = 0;
                }
                tabBushing.Hide();
                tbcTest.TabPages.Remove(tabBushing);
                form.Dispose();
            }
        }

        private void chkTTR_CheckStateChanged(object sender, EventArgs e)
        {
            frmTTR form = new frmTTR
            {
                TopLevel = false
            };

            if (chkTTR.Checked)
            {
                tabTTR.Text = "Transformer Turns Ratio";
                tbcTest.TabPages.Add(tabTTR);
                tabTTR.Show();

                form.Parent = tabTTR;
                form.Show();
            }
            else
            {
                if (tbcTest.SelectedIndex != 0)
                {
                    tbcTest.SelectedIndex = 0;
                }
                tabTTR.Hide();
                tbcTest.TabPages.Remove(tabTTR);
                form.Dispose();
            }
        }

        private void chkDCWR_CheckStateChanged(object sender, EventArgs e)
        {
            frmWinding form = new frmWinding
            {
                TopLevel = false
            };

            if (chkDCWR.Checked)
            {
                tabDCWR.Text = "DC Winding Resistance";
                tbcTest.TabPages.Add(tabDCWR);
                tabDCWR.Show();

                form.Parent = tabDCWR;
                form.Show();
            }
            else
            {
                if (tbcTest.SelectedIndex != 0)
                {
                    tbcTest.SelectedIndex = 0;
                }
                tabDCWR.Hide();
                tbcTest.TabPages.Remove(tabDCWR);
                form.Dispose();
            }
        }

        private void chkDielectric_CheckStateChanged(object sender, EventArgs e)
        {
            frmOilBD form = new frmOilBD
            {
                TopLevel = false
            };

            if (chkDielectric.Checked)
            {
                tabDielectric.Text = "Oil Dielectric Strength";
                tbcTest.TabPages.Add(tabDielectric);
                tabDielectric.Show();

                form.Parent = tabDielectric;
                form.Show();
            }
            else
            {
                if (tbcTest.SelectedIndex != 0)
                {
                    tbcTest.SelectedIndex = 0;
                }
                tabDielectric.Hide();
                tbcTest.TabPages.Remove(tabDielectric);
                form.Dispose();
            }
        }

        private void chkOilPF_CheckStateChanged(object sender, EventArgs e)
        {
            frmOilPF form = new frmOilPF
            {
                TopLevel = false
            };

            if (chkOilPF.Checked)
            {
                tabOilPF.Text = "Oil Power Factor";
                tbcTest.TabPages.Add(tabOilPF);
                tabOilPF.Show();

                form.Parent = tabOilPF;
                form.Show();
            }
            else
            {
                if (tbcTest.SelectedIndex != 0)
                {
                    tbcTest.SelectedIndex = 0;
                }
                tabOilPF.Hide();
                tbcTest.TabPages.Remove(tabOilPF);
                form.Dispose();
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
            this.tblTestTableAdapter.Fill(this.dtbPTASDataSet.tblTest);
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
                //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dtbPTAS.mdf;Integrated Security=True");
                //string query = "INSERT INTO tblTest (TestNumber, testDate, testEngr, testWeather, testAmbient, testOil, testPrimWT, testSecWT, testTertWT, testXformer, " +
                //        "testSub, testExcite, testIPF, testBushing, testTTR, testDCWR, testOilBD, testOilPF)" +
                //        "VALUES (@testnumber, @testdate, @testengr, @testweather, @testambient, @testoil, @testprim, @testsec, @testtert, @testxf, @testsub, " +
                //        "@testexcite, @testIPF, @testbushing, @testTTR, @testDCWR, @testoilBD, @testoilPF)";
                //DataSet ds = dtbPTASDataSet;
                //using (SqlCommand cmd = new SqlCommand(query, con))
                //{
                //    cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);
                //    cmd.Parameters.AddWithValue("@testdate", testDateDateTimePicker.Value);
                //    cmd.Parameters.AddWithValue("@testengr", testEngrTextBox.Text);
                //    cmd.Parameters.AddWithValue("@testweather", testWeatherTextBox.Text);
                //    cmd.Parameters.AddWithValue("@testambient", testAmbientTextBox.Text);
                //    cmd.Parameters.AddWithValue("@testoil", testOilTextBox.Text);
                //    cmd.Parameters.AddWithValue("@testprim", testPrimWTTextBox.Text);
                //    cmd.Parameters.AddWithValue("@testsec", testSecWTTextBox.Text);
                //    cmd.Parameters.AddWithValue("@testtert", testTertWTTextBox.Text);
                //    cmd.Parameters.AddWithValue("@testxf", cboXf.SelectedValue);
                //    cmd.Parameters.AddWithValue("@testsub", cboSub.SelectedValue);
                //    cmd.Parameters.AddWithValue("@testexcite", chkExcite.Checked);
                //    cmd.Parameters.AddWithValue("@testIPF", chkIPF.Checked);
                //    cmd.Parameters.AddWithValue("@testbushing", chkBushing.Checked);
                //    cmd.Parameters.AddWithValue("@testTTR", chkTTR.Checked);
                //    cmd.Parameters.AddWithValue("@testDCWR", chkDCWR.Checked);
                //    cmd.Parameters.AddWithValue("@testoilBD", chkDielectric.Checked);
                //    cmd.Parameters.AddWithValue("@testoilPF", chkOilPF.Checked);

                //    con.Open();

                //    try
                //    {
                //        cmd.ExecuteNonQuery();

                //        MessageBox.Show("Record saved.");

                //        ds.Clear();
                //        this.tblTestTableAdapter.Fill(this.dtbPTASDataSet.tblTest);
                //        OnPassTestNumber(testNumberTextBox.Text);
                //        con.Close();
                //    }
                //    catch (SqlException ex)
                //    {
                //        MessageBox.Show(ex.ToString());
                //    }
                //}
                //DataSet ds = dtbPTASDataSet;

                this.Validate();
                this.tblTestBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(dtbPTASDataSet);
                
                MessageBox.Show("Record saved.");

                //ds.Clear();
                //this.tblTestTableAdapter.Fill(this.dtbPTASDataSet.tblTest);
                OnPassTestNumber(testNumberTextBox.Text);
            }

            else
                this.Focus();
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
            this.tblTestBindingSource.AddNew();
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
                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dtbPTAS.mdf;Integrated Security=True"))
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM tblTest WHERE TestNumber = @testnumber", con))
                    {
                        cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Record deleted.");

                        ds.Clear();
                        this.tblTestTableAdapter.Fill(this.dtbPTASDataSet.tblTest);
                    }
                }
                catch
                {
                    MessageBox.Show("An error has occurred. Please make sure any associated tests are deleted.");
                }
                con.Close();
            }
            else
                this.Focus();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.tblTestBindingSource.MoveNext();
            OnDataChanged(testNumberTextBox.Text);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.tblTestBindingSource.MovePrevious();
            OnDataChanged(testNumberTextBox.Text);
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
    }

    

}
