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
    public partial class frmExcitation : Form
    {
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dtbPTAS.mdf;Integrated Security=True";
        string TestData;

        public frmExcitation()
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

            string query = "SELECT COUNT (*) FROM tblExcitation WHERE TestNumber = @testnumber";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", TestNumber);
                    con.Open();
                    int record = Convert.ToInt32(cmd.ExecuteScalar());

                    if(record == 1)
                    {
                        string query2 = "SELECT * FROM tblExcitation WHERE TestNumber = @testnumber";
                        using(SqlCommand cmd2 = new SqlCommand(query2, con))
                        {
                            cmd2.Parameters.AddWithValue("@testnumber", TestNumber);
                            SqlDataReader dr = cmd2.ExecuteReader();

                            while (dr.Read())
                            {
                                testNumberTextBox.Text = (dr["TestNumber"].ToString());
                                testVoltageTextBox.Text = (dr["TestVoltage"].ToString());
                                excHVATextBox.Text = (dr["excHVA"].ToString());
                                excHVBTextBox.Text = (dr["excHVB"].ToString());
                                excHVCTextBox.Text = (dr["excHVC"].ToString());
                            }
                        }
                    }
                    con.Close();
                }
            }
        }

        private void frmExcitation_Load(object sender, EventArgs e)
        {
            tblExcitationTableAdapter.Fill(dtbPTASDataSet.tblExcitation);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);
            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string query = "INSERT INTO tblExcitation (TestNumber, excHVA, excHVB, excHVC, TestVoltage) VALUES " +
                    "(@testnumber, @hva, @hvb, @hvc, @testvoltage)";
                DataSet ds = dtbPTASDataSet;
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);
                        cmd.Parameters.AddWithValue("@hva", excHVATextBox.Text);
                        cmd.Parameters.AddWithValue("@hvb", excHVBTextBox.Text);
                        cmd.Parameters.AddWithValue("@hvc", excHVCTextBox.Text);
                        cmd.Parameters.AddWithValue("@testvoltage", testVoltageTextBox.Text);

                        con.Open();

                        try
                        {
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record saved.");

                            ds.Clear();
                            this.tblExcitationTableAdapter.Fill(dtbPTASDataSet.tblExcitation);
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        con.Close();
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tblExcitationBindingSource.AddNew();
            testNumberTextBox.Text = TestData;
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
            else
                this.Focus();
        }

        private void btnAssess_Click(object sender, EventArgs e)
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
            float result = (difference / exc[1]) * 100;

            if(exc[0] <= 50 && exc[1] <= 50)
            {
                if(result <= 10)
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
                if(result <= 5)
                {
                    txtAssess.Text = "PASSED";
                }
                else
                {
                    txtAssess.Text = "FAILED";
                }
            }
        }
    }
}
