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
using System.Threading;

namespace PTAS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            Splasher.Status = "Loading Files...";
            Thread.Sleep(2000);

            Splasher.Status = "Loading Crystal Report Module...";
            Thread.Sleep(2000);

            Splasher.Status = "Connecting to Database...";
            Thread.Sleep(2000);

            Splasher.Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            Activate();
        }

        private int _failedAttempts = 0;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dtbPTAS.mdf;Integrated Security=True");
            con.Open();
            
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Please fill out the username and/or password.");

            else
            {
                using(SqlCommand cmd = new SqlCommand ("SELECT * FROM tblSecurity WHERE username = @username AND password = @password", con))
                {
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read() == false)
                        {
                            _failedAttempts++;

                            if (_failedAttempts == 3)
                            {
                                MessageBox.Show("You have reached the maximum number of attempts. Program closing.");
                                Application.Exit();
                            }
                            else
                                MessageBox.Show("Incorrect username and/or password. Please try again.");

                        }

                        else
                        {
                            MessageBox.Show("Login successful.");
                            con.Close();

                            frmMain form = new frmMain();
                            form.Show();
                            Hide();
                        }
                    }
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }
    }
}
