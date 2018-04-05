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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("Data Directory", path);
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dtbPTAS.mdf;Integrated Security=True";
            string query = "INSERT INTO tblSecurity (username, password) VALUES (@username, @password)";

            if (txtUsername.Text == "" || txtPassword.Text == "" || txtConfirm.Text == "")
                MessageBox.Show("All fields required.");
            else
            {
                if (txtPassword.Text == txtConfirm.Text)
                {
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                            con.Open();

                            try
                            {
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Registered.");

                                con.Close();
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                }
                else if (txtPassword.Text != txtConfirm.Text)
                    MessageBox.Show("Passwords do not match.", "Confirm password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Close();
        }

        private void frmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain f = new frmMain();
            f.Focus();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            AcceptButton = btnRegister;
        }
    }
}
