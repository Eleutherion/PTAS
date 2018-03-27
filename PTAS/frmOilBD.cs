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

            frmOilBD f = new frmOilBD();

            var t = f.Controls.OfType<TextBox>().ToArray();

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
                    //else
                    //{
                    //    for(int i = 0; i < 15; i++)
                    //    {
                    //        t[i].Clear();
                    //    }
                    //}
                    //con.Close();
                }
            }
        }

        private void frmOilBD_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dtbPTASDataSet.tblStatus' table. You can move, or remove it, as needed.
            //this.tblStatusTableAdapter.Fill(this.dtbPTASDataSet.tblStatus);
            //// TODO: This line of code loads data into the 'dtbPTASDataSet.tblStandards' table. You can move, or remove it, as needed.
            //this.tblStandardsTableAdapter.Fill(this.dtbPTASDataSet.tblStandards);
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

            //string query = "INSERT INTO tblDielectric (TestNumber, main1, main2, main3, main4, main5, mainAve, oltc1, oltc2, oltc3, oltc4, oltc5, oltcAve) " +
            //    "VALUES (@testnumber, @main1, @main2, @main3, @main4, @main5, @mainAve, @oltc1, @oltc2, @oltc3, @oltc4, @oltc5, @oltcAve)";

            //DataSet ds = dtbPTASDataSet;

            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //using (SqlConnection con = new SqlConnection(constring))
                //{
                //    using (SqlCommand cmd = new SqlCommand(query, con))
                //    {
                //        cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);
                //        cmd.Parameters.AddWithValue("@main1", main1TextBox.Text);
                //        cmd.Parameters.AddWithValue("@main2", main2TextBox.Text);
                //        cmd.Parameters.AddWithValue("@main3", main3TextBox.Text);
                //        cmd.Parameters.AddWithValue("@main4", main4TextBox.Text);
                //        cmd.Parameters.AddWithValue("@main5", main5TextBox.Text);
                //        cmd.Parameters.AddWithValue("@mainAve", mainAveTextBox.Text);
                //        cmd.Parameters.AddWithValue("@oltc1", oltc1TextBox.Text);
                //        cmd.Parameters.AddWithValue("@oltc2", oltc2TextBox.Text);
                //        cmd.Parameters.AddWithValue("@oltc3", oltc3TextBox.Text);
                //        cmd.Parameters.AddWithValue("@oltc4", oltc4TextBox.Text);
                //        cmd.Parameters.AddWithValue("@oltc5", oltc5TextBox.Text);
                //        cmd.Parameters.AddWithValue("@oltcAve", oltcAveTextBox.Text);

                //        con.Open();

                //        try
                //        {
                //            cmd.ExecuteNonQuery();

                //            MessageBox.Show("Record saved.");

                //            ds.Clear();
                //            tblDielectricTableAdapter.Fill(dtbPTASDataSet.tblDielectric);
                //        }
                //        catch (SqlException ex)
                //        {
                //            MessageBox.Show(ex.ToString());
                //        }
                //        con.Close();
                //    }
                //}
                Validate();
                tblDielectricBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dtbPTASDataSet);
            }
            else
                Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
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

        float main;
        float oltc;

        private void btnAssess_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            
            float kv;
            string query = "SELECT tblTransformer.xfID, tblTransformer.xfPrimVolt FROM tblDielectric LEFT OUTER JOIN tblTest ON tblDielectric.TestNumber = tblTest.TestNumber " +
                "LEFT OUTER JOIN tblTransformer ON tblTest.testXformer = tblTransformer.xfID WHERE tblDielectric.TestNumber = @testnumber";
            
            using(SqlConnection con = new SqlConnection(constring))
            {
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);
                    
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        kv = float.Parse(dr["tblTransformer.xfPrimVolt"].ToString());
                    }
                    con.Close();
                }
            }

            if (!string.IsNullOrEmpty(mainAveTextBox.Text))
                float.TryParse(mainAveTextBox.Text, out main);
            if (!string.IsNullOrEmpty(oltcAveTextBox.Text))
                float.TryParse(oltcAveTextBox.Text, out oltc);

            if(standardComboBox.SelectedValue.ToString() == "ASTM D1816")
            {
                if(statusComboBox.SelectedValue.ToString() == "AGED")
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

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float[] main = new float[5];
            float[] oltc = new float[5];

            var textmain = grpMain.Controls.
                           OfType<TextBox>().
                           ToArray();

            var textoltc = grpOLTC.Controls.
                           OfType<TextBox>().
                           ToArray();

            for(int i = 0; i < 5; i++)
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
    }
}
