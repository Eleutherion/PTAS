using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace PTAS
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            frmMain.OnPassTestNumber += FrmMain_OnPassTestNumber;
        }

        private void FrmMain_OnPassTestNumber(string TestNumber)
        {
            TestData = TestNumber;

            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);

            dsReport ds = new dsReport();

            string test = "SELECT * FROM tblTest WHERE TestNumber = @testnumber";
            string excitation = "SELECT * FROM tblExcitation WHERE TestNumber = @testnumber";
            string ipf = "SELECT * FROM tblIPF WHERE TestNumber = @testnumber";
            string bushing = "SELECT * FROM tblBushing WHERE TestNumber = @testnumber";
            string ttr = "SELECT * FROM tblTTR WHERE TestNumber = @testnumber";
            string winding = "SELECT * FROM tblWinding WHERE TestNumber = @testnumber";
            string dielectric = "SELECT * FROM tblDielectric WHERE TestNumber = @testnumber";
            string oilpf = "SELECT * FROM tblOilPF WHERE TestNumber = @testnumber";

            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(test, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", TestData);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds.Tables["Test"]);
                    }
                }
                using (SqlCommand cmd = new SqlCommand(excitation, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", TestData);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds.Tables["Excitation"]);
                    }
                }
                using (SqlCommand cmd = new SqlCommand(ipf, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", TestData);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds.Tables["IPF"]);
                    }
                }
                using (SqlCommand cmd = new SqlCommand(bushing, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", TestData);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds.Tables["Bushing"]);
                    }
                }
                using (SqlCommand cmd = new SqlCommand(ttr, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", TestData);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds.Tables["TTR"]);
                    }
                }
                using (SqlCommand cmd = new SqlCommand(winding, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", TestData);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds.Tables["Winding"]);
                    }
                }
                using (SqlCommand cmd = new SqlCommand(dielectric, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", TestData);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds.Tables["Dielectric"]);
                    }
                }
                using (SqlCommand cmd = new SqlCommand(oilpf, con))
                {
                    cmd.Parameters.AddWithValue("@testnumber", TestData);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds.Tables["OilPF"]);
                    }
                }
                con.Close();
            }

            CrystalReport11.SetDataSource(ds);
            crystalReportViewer1.ReportSource = CrystalReport11;
            crystalReportViewer1.Refresh();

            frmMain.OnPassTestNumber -= FrmMain_OnPassTestNumber;
        }

        string TestData;
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dtbPTAS.mdf;Integrated Security=True";
        
    }
}
