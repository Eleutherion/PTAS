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
    public partial class frmOilBD : Form
    {
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dtbPTAS.mdf;Integrated Security=True";
        string TestData;

        public frmOilBD()
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

            string query = "SELECT COUNT (*) FROM tblDielectric WHERE TestNumber = @testnumber";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", TestNumber);
                    con.Open();
                    int record = Convert.ToInt32(cmd.ExecuteScalar());

                    if (record == 1)
                    {
                        string query2 = "SELECT * FROM tblDielectric WHERE TestNumber = @testnumber";
                        using (SqlCommand cmd2 = new SqlCommand(query2, con))
                        {
                            cmd2.Parameters.AddWithValue("@testnumber", TestNumber);
                            SqlDataReader dr = cmd2.ExecuteReader();

                            while (dr.Read())
                            {
                                testNumberTextBox.Text = (dr["TestNumber"].ToString());
                                main1TextBox.Text = (dr["main1"].ToString());
                                main2TextBox.Text = (dr["main2"].ToString());
                                main3TextBox.Text = (dr["main3"].ToString());
                                main4TextBox.Text = (dr["main4"].ToString());
                                main5TextBox.Text = (dr["main5"].ToString());
                                mainAveTextBox.Text = (dr["mainAve"].ToString());
                                oltc1TextBox.Text = (dr["oltc1"].ToString());
                                oltc2TextBox.Text = (dr["oltc2"].ToString());
                                oltc3TextBox.Text = (dr["oltc3"].ToString());
                                oltc4TextBox.Text = (dr["oltc4"].ToString());
                                oltc5TextBox.Text = (dr["oltc5"].ToString());
                                oltcAveTextBox.Text = (dr["oltcAve"].ToString());
                            }
                        }
                    }
                    con.Close();
                }
            }
        }

        private void frmOilBD_Load(object sender, EventArgs e)
        {
            this.tblDielectricTableAdapter.Fill(this.dtbPTASDataSet.tblDielectric);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tblDielectricBindingSource.AddNew();
            testNumberTextBox.Text = TestData;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "INSERT INTO tblDielectric (TestNumber, main1, main2, main3, main4, main5, mainAve, oltc1, oltc2, oltc3, oltc4, oltc5, oltcAve) " +
                "VALUES (@testnumber, @main1, @main2, @main3, @main4, @main5, @mainAve, @oltc1, @oltc2, @oltc3, @oltc4, @oltc5, @oltcAve)";

            DataSet ds = dtbPTASDataSet;

            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);
                        cmd.Parameters.AddWithValue("@main1", main1TextBox.Text);
                        cmd.Parameters.AddWithValue("@main2", main2TextBox.Text);
                        cmd.Parameters.AddWithValue("@main3", main3TextBox.Text);
                        cmd.Parameters.AddWithValue("@main4", main4TextBox.Text);
                        cmd.Parameters.AddWithValue("@main5", main5TextBox.Text);
                        cmd.Parameters.AddWithValue("@mainAve", mainAveTextBox.Text);
                        cmd.Parameters.AddWithValue("@oltc1", oltc1TextBox.Text);
                        cmd.Parameters.AddWithValue("@oltc2", oltc2TextBox.Text);
                        cmd.Parameters.AddWithValue("@oltc3", oltc3TextBox.Text);
                        cmd.Parameters.AddWithValue("@oltc4", oltc4TextBox.Text);
                        cmd.Parameters.AddWithValue("@oltc5", oltc5TextBox.Text);
                        cmd.Parameters.AddWithValue("@oltcAve", oltcAveTextBox.Text);

                        con.Open();

                        try
                        {
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record saved.");

                            ds.Clear();
                            tblDielectricTableAdapter.Fill(dtbPTASDataSet.tblDielectric);
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

            string query = "DELETE FROM tblDielectric WHERE TestNumber = @testnumber";
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

        private void main5TextBox_TextChanged(object sender, EventArgs e)
        {
            float[] main = new float[5];

            main[0] = float.Parse(main1TextBox.Text);
            main[1] = float.Parse(main2TextBox.Text);
            main[2] = float.Parse(main3TextBox.Text);
            main[3] = float.Parse(main4TextBox.Text);
            main[4] = float.Parse(main5TextBox.Text);

            float average = (float)((main[0] + main[1] + main[2] + main[3] + main[4]) / 5);

            mainAveTextBox.Text = average.ToString();
        }

        private void oltc5TextBox_TextChanged(object sender, EventArgs e)
        {
            float[] oltc = new float[5];

            float.TryParse(oltc1TextBox.Text, out oltc[0]);
            float.TryParse(oltc2TextBox.Text, out oltc[1]);
            float.TryParse(oltc3TextBox.Text, out oltc[2]);
            float.TryParse(oltc4TextBox.Text, out oltc[3]);
            float.TryParse(oltc5TextBox.Text, out oltc[4]);

            float average = (float)((oltc[0] + oltc[1] + oltc[2] + oltc[3] + oltc[4]) / 5);

            oltcAveTextBox.Text = average.ToString();
        }
    }
}
