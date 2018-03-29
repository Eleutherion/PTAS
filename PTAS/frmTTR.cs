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

        float[] measure = new float[6];
        float[] compute = new float[6];

        float[] previous = new float[6];

        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dtbPTAS.mdf;Integrated Security=True";
        string TestData;

        public frmTTR()
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
            //frmMain.OnDataChanged -= FrmMain_OnDataChanged;
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
                tblTTRBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dtbPTASDataSet);

                MessageBox.Show("Record saved.");
            }
            else
                Focus();
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
            else Focus();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(ttrHVTextBox.Text) && !string.IsNullOrWhiteSpace(ttrLVTextBox.Text))
            {
                float hv = float.Parse(ttrHVTextBox.Text);
                float lv = float.Parse(ttrLVTextBox.Text);
                float.TryParse(ttrTVTextBox.Text, out float tv);

                LVRatio = hv / lv;
                if (tv != 0)
                    TVRatio = hv / tv;

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
                    for(int i = 0; i < 6; i++)
                    {
                        float.TryParse(measured[i].Text, out measure[i]);
                        float ratio;
                        if (i < 3) ratio = LVRatio;
                        else ratio = TVRatio;

                        compute[i] = Truncate(Math.Abs(((measure[i] - ratio) / ratio) * 100), 2);
                        if (string.IsNullOrWhiteSpace(measured[i].Text))
                            error[i].Text = compute[i].ToString();
                    }
                }
                //if (Array.TrueForAll(compute, v => v <= 0.5))
                //{
                //    string query = "SELECT testXformer FROM tblTest WHERE TestNumber = @testnumber";
                //    string query2 = "SELECT TOP 1 tblTest.testXformer, tblTTR.* FROM tblTTR LEFT OUTER JOIN" +
                //        "tblTest ON tblTTR.TestNumber = tblTest.TestNumber ORDER BY tblTTR.TestNumber DESC" +
                //        "WHERE tblTTR.TestNumber < @testnumber";

                //    using (SqlConnection con = new SqlConnection(constring))
                //    {
                //        using (SqlCommand cmd = new SqlCommand(query, con))
                //        {
                //            cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);

                //            con.Open();

                //            SqlDataReader dr = cmd.ExecuteReader();
                //            while (dr.Read())
                //            {
                //                xf = (dr["tblTest.testXformer"].ToString());
                //            }

                //            using (SqlCommand cmd2 = new SqlCommand(query2, con))
                //            {
                //                cmd.Parameters.AddWithValue("@testnumber", testNumberTextBox.Text);

                //                SqlDataReader dr2 = cmd2.ExecuteReader();
                //                while (dr2.Read())
                //                {
                //                    float.TryParse(dr2["ttrAHVLVe"].ToString(), out previous[0]);
                //                    float.TryParse(dr2["ttrBHVLVe"].ToString(), out previous[1]);
                //                    float.TryParse(dr2["ttrCHVLVe"].ToString(), out previous[2]);
                //                    float.TryParse(dr2["ttrAHVTVe"].ToString(), out previous[3]);
                //                    float.TryParse(dr2["ttrBHVTVe"].ToString(), out previous[4]);
                //                    float.TryParse(dr2["ttrCHVTVe"].ToString(), out previous[5]);
                //                }
                //            }
                //        }
                //        con.Close();
                //    }

                //    for (int i = 0; i < 6; i++)
                //    {
                //        diff[i] = Truncate(Math.Abs(((previous[i] - compute[i]) / previous[i]) * 100), 2);
                //    }

                //    if (Array.TrueForAll(diff, v => v <= 0.5)) txtAssess.Text = "PASSED";
                //    else txtAssess.Text = "INVESTIGATE WINDING";
                //}
                //else txtAssess.Text = "FAILED";
            }
        }

        private void btnAssess_Click(object sender, EventArgs e)
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
                    diff[i] = Truncate(Math.Abs(((previous[i] - compute[i]) / previous[i]) * 100), 2);
                }

                if (Array.TrueForAll(diff, v => v <= 0.5)) txtAssess.Text = "PASSED";
                else txtAssess.Text = "INVESTIGATE WINDING";
            }
            else txtAssess.Text = "FAILED";
        }

        public static float Truncate(float value, int digits)
        {
            double mult = Math.Pow(10.0, digits);
            double result = Math.Truncate(mult * value) / mult;
            return (float)result;
        }
    }
}
