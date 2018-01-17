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

        private void FrmMain_OnPassTestNumber(string TestNumber) => TestData = TestNumber;

        private void FrmMain_OnDataChanged(string TestNumber)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

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
                            }
                        }
                    }
                    con.Close();
                }
            }
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
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            DataSet ds = dtbPTASDataSet;

            string query = "INSERT INTO tblBushing (TestNumber, nameH1, nameH2, nameH3, nameH0X0, nameX1, nameX2, nameX3, " +
                "pfC1H1, pfC1H2, pfC1H3, pfC1H0X0, pfC1X1, pfC1X2, pfC1X3, pfC2H1, pfC2H2, pfC2H3, pfC2H0X0, pfC2X1, pfC2X2, pfC2X3, " +
                "capC1H1, capC1H2, capC1H3, capC1H0X0, capC1X1, capC1X2, capC1X3, capC2H1, capC2H2, capC2H3, capC2H0X0, capC2X1, capC2X2, capC2X3) " +
                "VALUES (@testnumber, @nameH1, @nameH2, @nameH3, @nameH0X0, @nameX1, @nameX2, @nameX3, @pfC1H1, @pfC1H2, @pfC1H3, @pfC1H0X0, @pfC1X1, @pfC1X2, @pfC1X3, " +
                "@pfC2H1, @pfC2H2, @pfC2H3, @pfC2H0X0, @pfC2X1, @pfC2X2, @pfC2X3, @capC1H1, @capC1H2, @capC1H3, @capC1H0X0, @capC1X1, @capC1X2, @capC1X3, " +
                "@capC2H1, @capC2H2, @capC2H3, @capC2H0X0, @capC2X1, @capC2X2, @capC2X3)";

            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);

            if(dr == DialogResult.Yes)
            {
                using(SqlConnection con = new SqlConnection(constring))
                {
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);
                        cmd.Parameters.AddWithValue("@nameH1", nameH1TextBox.Text);
                        cmd.Parameters.AddWithValue("@nameH2", nameH2TextBox.Text);
                        cmd.Parameters.AddWithValue("@nameH3", nameH3TextBox.Text);
                        cmd.Parameters.AddWithValue("@nameH0X0", nameH0X0TextBox.Text);
                        cmd.Parameters.AddWithValue("@nameX1", nameX1TextBox.Text);
                        cmd.Parameters.AddWithValue("@nameX2", nameX2TextBox.Text);
                        cmd.Parameters.AddWithValue("@nameX3", nameX3TextBox.Text);
                        cmd.Parameters.AddWithValue("@pfC1H1", pfC1H1TextBox.Text);
                        cmd.Parameters.AddWithValue("@pfC1H2", pfC1H2TextBox.Text);
                        cmd.Parameters.AddWithValue("@pfC1H3", pfC1H3TextBox.Text);
                        cmd.Parameters.AddWithValue("@pfC1H0X0", pfC1H0X0TextBox.Text);
                        cmd.Parameters.AddWithValue("@pfC1X1", pfC1X1TextBox.Text);
                        cmd.Parameters.AddWithValue("@pfC1X2", pfC1X2TextBox.Text);
                        cmd.Parameters.AddWithValue("@pfC1X3", pfC1X3TextBox.Text);
                        cmd.Parameters.AddWithValue("@pfC2H1", pfC2H1TextBox.Text);
                        cmd.Parameters.AddWithValue("@pfC2H2", pfC2H2TextBox.Text);
                        cmd.Parameters.AddWithValue("@pfC2H3", pfC2H3TextBox.Text);
                        cmd.Parameters.AddWithValue("@pfC2H0X0", pfC2H0X0TextBox.Text);
                        cmd.Parameters.AddWithValue("@pfC2X1", pfC2X1TextBox.Text);
                        cmd.Parameters.AddWithValue("@pfC2X2", pfC2X2TextBox.Text);
                        cmd.Parameters.AddWithValue("@pfC2X3", pfC2X3TextBox.Text);
                        cmd.Parameters.AddWithValue("@capC1H1", capC1H1TextBox.Text);
                        cmd.Parameters.AddWithValue("@capC1H2", capC1H2TextBox.Text);
                        cmd.Parameters.AddWithValue("@capC1H3", capC1H3TextBox.Text);
                        cmd.Parameters.AddWithValue("@capC1H0X0", capC1H0X0TextBox.Text);
                        cmd.Parameters.AddWithValue("@capC1X1", capC1X1TextBox.Text);
                        cmd.Parameters.AddWithValue("@capC1X2", capC1X2TextBox.Text);
                        cmd.Parameters.AddWithValue("@capC1X3", capC1X3TextBox.Text);
                        cmd.Parameters.AddWithValue("@capC2H1", capC2H1TextBox.Text);
                        cmd.Parameters.AddWithValue("@capC2H2", capC2H2TextBox.Text);
                        cmd.Parameters.AddWithValue("@capC2H3", capC2H3TextBox.Text);
                        cmd.Parameters.AddWithValue("@capC2H0X0", capC2H0X0TextBox.Text);
                        cmd.Parameters.AddWithValue("@capC2X1", capC2X1TextBox.Text);
                        cmd.Parameters.AddWithValue("@capC2X2", capC2X2TextBox.Text);
                        cmd.Parameters.AddWithValue("@capC2X3", capC2X3TextBox.Text);

                        con.Open();

                        try
                        {
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record saved.");

                            ds.Clear();
                            tblBushingTableAdapter.Fill(dtbPTASDataSet.tblBushing);
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
    }
}
