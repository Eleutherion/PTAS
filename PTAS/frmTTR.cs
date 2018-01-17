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
    public partial class frmTTR : Form
    {
        private static float LVRatio;
        private static float TVRatio;

        private string primary;
        private string secondary;
        private string auto;

        private float m, n;
        private int clock;

        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dtbPTAS.mdf;Integrated Security=True";
        string TestData;

        public frmTTR()
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

            string query = "SELECT COUNT (*) FROM tblTTR WHERE TestNumber = @testnumber";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", TestNumber);
                    con.Open();
                    int record = Convert.ToInt32(cmd.ExecuteScalar());

                    if (record == 1)
                    {
                        string query2 = "SELECT * FROM tblTTR WHERE TestNumber = @testnumber";
                        using (SqlCommand cmd2 = new SqlCommand(query2, con))
                        {
                            cmd2.Parameters.AddWithValue("@testnumber", TestNumber);
                            SqlDataReader dr = cmd2.ExecuteReader();

                            while (dr.Read())
                            {
                                testNumberTextBox.Text = (dr["TestNumber"].ToString());
                                ttrTapTextBox.Text = (dr["ttrTap"].ToString());
                                ttrHVTextBox.Text = (dr["ttrHV"].ToString());
                                ttrLVTextBox.Text = (dr["ttrLV"].ToString());
                                ttrTVTextBox.Text = (dr["ttrTV"].ToString());
                                ttrRHVLVTextBox.Text = (dr["ttrRHVLV"].ToString());
                                ttrRHVTVTextBox.Text = (dr["ttrRHVTV"].ToString());
                                ttrAHVLVTextBox.Text = (dr["ttrAHVLV"].ToString());
                                ttrBHVLVTextBox.Text = (dr["ttrBHVLV"].ToString());
                                ttrCHVLVTextBox.Text = (dr["ttrCHVLV"].ToString());
                                ttrAHVTVTextBox.Text = (dr["ttrAHVTV"].ToString());
                                ttrBHVTVTextBox.Text = (dr["ttrBHVTV"].ToString());
                                ttrCHVTVTextBox.Text = (dr["ttrCHVTV"].ToString());
                                ttrAHVLVeTextBox.Text = (dr["ttrAHVLVe"].ToString());
                                ttrBHVLVeTextBox.Text = (dr["ttrBHVLVe"].ToString());
                                ttrCHVLVeTextBox.Text = (dr["ttrCHVLVe"].ToString());
                                ttrAHVTVeTextBox.Text = (dr["ttrAHVTVe"].ToString());
                                ttrBHVTVeTextBox.Text = (dr["ttrBHVTVe"].ToString());
                                ttrCHVTVeTextBox.Text = (dr["ttrCHVTVe"].ToString());
                            }
                        }
                    }
                    con.Close();
                }
            }
        }

        private void frmTTR_Load(object sender, EventArgs e)
        {
            this.tblTTRTableAdapter.Fill(this.dtbPTASDataSet.tblTTR);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tblTTRBindingSource.AddNew();
            testNumberTextBox.Text = TestData;

            string query = "SELECT tblTest.TestNumber, tblTest.testXformer, tblTransformer.* FROM tblTest INNER JOIN tblTransformer ON tblTest.testXformer = tblTransformer.xfID WHERE tblTest.TestNumber = @testnumber";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);

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
                m = 1;
                switch (primary)
                {
                    case "YN" when secondary == "d ":
                        n = (float)(1 / 1.732);
                        break;
                    case "D " when secondary == "yn":
                        n = (float)1.732;
                        break;
                    default:
                        n = 1;
                        break;
                }
            }
                
            else
            {
                switch (primary)
                {
                    case "YN" when secondary == "d ":
                        m = (float)(1 / 1.732);
                        break;
                    case "D " when secondary == "yn":
                        m = (float)1.732;
                        break;
                    default:
                        m = 1;
                        break;
                }
            }
            textBox5.Text = m.ToString();
            textBox6.Text = n.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string query = "INSERT INTO tblTTR (TestNumber, ttrTap, ttrHV, ttrLV, ttrTV, ttrRHVLV, ttrRHVTV, " +
                "ttrAHVLV, ttrBHVLV, ttrCHVLV, ttrAHVTV, ttrBHVTV, ttrCHVTV, ttrAHVLVe, ttrBHVLVe, ttrCHVLVe, ttrAHVTVe, ttrBHVTVe, ttrCHVTVe)" +
                "VALUES (@TestNumber, @ttrTap, @ttrHV, @ttrLV, @ttrTV, @ttrRHVLV, @ttrRHVTV, " +
                "@ttrAHVLV, @ttrBHVLV, @ttrCHVLV, @ttrAHVTV, @ttrBHVTV, @ttrCHVTV, @ttrAHVLVe, @ttrBHVLVe, @ttrCHVLVe, @ttrAHVTVe, @ttrBHVTVe, @ttrCHVTVe)";

            DataSet ds = dtbPTASDataSet;

            DialogResult dr = MessageBox.Show("Do you wish to save?", "Save", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@TestNumber", testNumberTextBox.Text);
                        cmd.Parameters.AddWithValue("@ttrTap", ttrTapTextBox.Text);
                        cmd.Parameters.AddWithValue("@ttrHV", ttrHVTextBox.Text);
                        cmd.Parameters.AddWithValue("@ttrLV", ttrLVTextBox.Text);
                        cmd.Parameters.AddWithValue("@ttrTV", ttrTVTextBox.Text);
                        cmd.Parameters.AddWithValue("@ttrAHVLV", ttrAHVLVTextBox.Text);
                        cmd.Parameters.AddWithValue("@ttrBHVLV", ttrBHVLVTextBox.Text);
                        cmd.Parameters.AddWithValue("@ttrCHVLV", ttrCHVLVTextBox.Text);
                        cmd.Parameters.AddWithValue("@ttrAHVTV", ttrAHVTVTextBox.Text);
                        cmd.Parameters.AddWithValue("@ttrBHVTV", ttrBHVTVTextBox.Text);
                        cmd.Parameters.AddWithValue("@ttrCHVTV", ttrCHVTVTextBox.Text);
                        cmd.Parameters.AddWithValue("@ttrAHVLVe", ttrAHVLVeTextBox.Text);
                        cmd.Parameters.AddWithValue("@ttrBHVLVe", ttrBHVLVeTextBox.Text);
                        cmd.Parameters.AddWithValue("@ttrCHVLVe", ttrCHVLVeTextBox.Text);
                        cmd.Parameters.AddWithValue("@ttrAHVTVe", ttrAHVTVeTextBox.Text);
                        cmd.Parameters.AddWithValue("@ttrBHVTVe", ttrBHVTVeTextBox.Text);
                        cmd.Parameters.AddWithValue("@ttrCHVTVe", ttrCHVTVeTextBox.Text);

                        con.Open();

                        try
                        {
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record saved.");

                            ds.Clear();
                            tblTTRTableAdapter.Fill(dtbPTASDataSet.tblTTR);
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
            else
                this.Focus();
        }
        
        private void ttrLVTextBox_TextChanged(object sender, EventArgs e)
        {
            float hv = float.Parse(ttrHVTextBox.Text);
            float lv = float.Parse(ttrLVTextBox.Text);

            LVRatio = (float)((hv / lv) * 1.732);

            string query = "SELECT tblTest.TestNumber, tblTest.testXformer, tblTransformer.* FROM tblTest INNER JOIN tblTransformer ON tblTest.testXformer = tblTransformer.xfID WHERE tblTest.TestNumber = @testnumber";

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);

                    con.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        textBox1.Text = (dr["xfPrimW"].ToString());
                        textBox3.Text = (dr["xfSecW"].ToString());
                        textBox2.Text = (dr["xfAuto"].ToString());
                        textBox4.Text = (dr["xfSecClock"].ToString());
                    }
                    con.Close();
                }
            }

            if (textBox2.Text == "a")
                m = 1;
            else
            {
                switch (textBox1.Text)
                {
                    case "YN" when textBox3.Text == "d ":
                        m = (float)(1 / 1.732);
                        break;
                    case "D " when textBox3.Text == "yn":
                        m = (float)1.732;
                        break;
                    default:
                        m = 1;
                        break;
                }
            }

            textBox5.Text = m.ToString();

            float truncated = (float)(Math.Truncate((double)LVRatio * 100.0) / 100.0);
            float rounded = (float)(Math.Round((double)LVRatio, 4));
            ttrRHVLVTextBox.Text = rounded.ToString();
        }

        private void ttrTVTextBox_TextChanged(object sender, EventArgs e)
        {
            float hv = float.Parse(ttrHVTextBox.Text);
            float.TryParse(ttrTVTextBox.Text, out float tv);

            TVRatio = hv / tv;

            float truncated = (float)(Math.Truncate((double)TVRatio * 100.0) / 100.0);
            float rounded = (float)(Math.Round((double)TVRatio, 4));
            ttrRHVTVTextBox.Text = rounded.ToString();
        }

        private void ttrAHVLVTextBox_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(ttrAHVLVTextBox.Text, out float lva);

            float RatioLVA = ((lva - LVRatio) / LVRatio) * 100;

            float truncated = (float)(Math.Truncate((double)RatioLVA * 100.0) / 100.0);
            float rounded = (float)(Math.Round((double)RatioLVA, 2));
            ttrAHVLVeTextBox.Text = rounded.ToString();
        }

        private void ttrBHVLVTextBox_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(ttrBHVLVTextBox.Text, out float lvb);

            float RatioLVB = ((lvb - LVRatio) / LVRatio) * 100;

            float truncated = (float)(Math.Truncate((double)RatioLVB * 100.0) / 100.0);
            float rounded = (float)(Math.Round((double)RatioLVB, 2));
            ttrBHVLVeTextBox.Text = rounded.ToString();
        }

        private void ttrCHVLVTextBox_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(ttrCHVLVTextBox.Text, out float lvc);

            float RatioLVC = ((lvc - LVRatio) / LVRatio) * 100;

            float truncated = (float)(Math.Truncate((double)RatioLVC * 100.0) / 100.0);
            float rounded = (float)(Math.Round((double)RatioLVC, 2));
            ttrCHVLVeTextBox.Text = rounded.ToString();
        }

        private void ttrAHVTVTextBox_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(ttrAHVTVTextBox.Text, out float tva);

            float RatioTVA = ((tva - TVRatio) / TVRatio) * 100;

            float truncated = (float)(Math.Truncate((double)RatioTVA * 100.0) / 100.0);
            float rounded = (float)(Math.Round((double)RatioTVA, 2));
            ttrAHVTVeTextBox.Text = rounded.ToString();
        }

        private void ttrBHVTVTextBox_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(ttrBHVTVTextBox.Text, out float tvb);

            float RatioTVB = ((tvb - TVRatio) / TVRatio) * 100;

            float truncated = (float)(Math.Truncate((double)RatioTVB * 100.0) / 100.0);
            float rounded = (float)(Math.Round((double)RatioTVB, 2));
            ttrBHVTVeTextBox.Text = rounded.ToString();
        }

        private void ttrCHVTVTextBox_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(ttrCHVTVTextBox.Text, out float tvc);

            float RatioTVC = ((tvc - TVRatio) / TVRatio) * 100;

            float truncated = (float)(Math.Truncate((double)RatioTVC * 100.0) / 100.0);
            float rounded = (float)(Math.Round((double)RatioTVC, 2));
            ttrCHVTVeTextBox.Text = rounded.ToString();
        }
    }
}
