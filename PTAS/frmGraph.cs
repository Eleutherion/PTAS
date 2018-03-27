using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PTAS
{
    public partial class frmGraph : Form
    {
        public frmGraph()
        {
            InitializeComponent();
            refreshdata();
        }

        private void frmGraph_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtbPTASDataSet.tblParamList' table. You can move, or remove it, as needed.
            this.tblParamListTableAdapter.Fill(this.dtbPTASDataSet.tblParamList);
            // TODO: This line of code loads data into the 'dtbPTASDataSet.tblTestList' table. You can move, or remove it, as needed.
            this.tblTestListTableAdapter.Fill(this.dtbPTASDataSet.tblTestList);
            // TODO: This line of code loads data into the 'dtbPTASDataSet.tblTransformer' table. You can move, or remove it, as needed.
            this.tblTransformerTableAdapter.Fill(this.dtbPTASDataSet.tblTransformer);

        }

        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dtbPTAS.mdf;Integrated Security=True";

        public void refreshdata()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblTestList", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        cboTest.DataSource = dt;
                        cboTest.DisplayMember = "TestName";
                        cboTest.ValueMember = "TestValue";
                        cboTest.SelectedIndex = -1;
                        cboTest.Text = "Select test";
                    }
                }
                con.Close();
            }
        }

        public void refreshstate(string TestValue)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            using(SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblParamList WHERE TestName = @TestName", con))
                {
                    cmd.Parameters.AddWithValue("@TestName", cboTest.Text.ToString());
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        cboParam.DataSource = dt;
                        cboParam.DisplayMember = "ParameterName";
                        cboParam.ValueMember = "ParameterValue";
                        cboParam.SelectedIndex = -1;
                        cboParam.Text = "Select parameter";
                    }
                }
            }
        }

        private void cboTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboTest.Text))
            {
                string TestValue = cboTest.Text.ToString();
                refreshstate(TestValue);
            }
        }

        

        private void btnLoad_Click(object sender, EventArgs e)
        {
            chtTrend.Series["Series1"].Points.Clear();

            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            string test = cboTest.SelectedValue.ToString();
            string parameter = cboParam.SelectedValue.ToString();

            string scalar = "SELECT COUNT (*) FROM "+test+" LEFT OUTER JOIN tblTest ON "+test+".TestNumber = tblTest.TestNumber " +
                "WHERE tblTest.testXformer = @xf";

            string values = "SELECT " + test + "." + parameter + " AS "+parameter+", tblTest.testXformer, tblTest.testDate AS Date FROM " + test + " LEFT OUTER JOIN " +
                "tblTest ON " + test + ".TestNumber = tblTest.TestNumber WHERE tblTest.testXformer = @xf";

            int count = 0;

            List<float> trend = new List<float>();
            List<DateTime> datetime = new List<DateTime>();
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand(scalar, con))
                {
                    cmd.Parameters.AddWithValue("@xf", cboXf.Text.ToString());

                    con.Open();

                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
                using (SqlCommand cmd2 = new SqlCommand(values, con))
                {
                    cmd2.Parameters.AddWithValue("@xf", cboXf.Text.ToString());

                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "parameters");

                    foreach (DataRow row in ds.Tables["parameters"].Rows)
                    {
                        trend.Add(row[parameter].Equals(DBNull.Value) ? 0 : float.Parse(row[parameter].ToString()));
                        datetime.Add(Convert.ToDateTime(row["Date"].ToString()));
                    }
                }
                con.Close();
            }

            for (int i = 0; i < count; i++)
            {
                chtTrend.Series["Series1"].Points.AddXY(datetime[i],trend[i]);
            }
        }
    }
}
