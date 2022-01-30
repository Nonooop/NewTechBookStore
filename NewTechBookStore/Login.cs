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

namespace NewTechBookStore
{
    public partial class Login : Form
    {
        public static string user;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user = txtUsername.Text;
            try
            {
                using (SqlConnection SqlConnect = new SqlConnection(Koneksi.Connect))
                {
                    SqlConnect.Open();
                    if (txtUsername.Text == "" || txtPassword.Text == "")
                    {
                        MessageBox.Show("Login Gagal! Data yang diinputkan tidak lengkap.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        SqlDataAdapter GetUser = new SqlDataAdapter("EXEC spLogin @USERNAME, @PASSWD", SqlConnect);
                        GetUser.SelectCommand.Parameters.AddWithValue("@USERNAME", txtUsername.Text.Trim());
                        GetUser.SelectCommand.Parameters.AddWithValue("@PASSWD", txtPassword.Text.Trim());
                        GetUser.SelectCommand.ExecuteNonQuery();

                        DataTable dt = new DataTable();
                        GetUser.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow dr in dt.Rows)
                            {
                                if (dr["level_user"].ToString() == "Administrator")
                                {
                                    MessageBox.Show("Login Sukses! Selamat Datang Administrator " + dr["nama"].ToString());
                                    Dashboard admin = new Dashboard();
                                    admin.Show();
                                    this.Hide();
                                    SqlConnect.Close();
                                }
                                else if (dr["level_user"].ToString() == "Kasir")
                                {
                                    MessageBox.Show("Login Sukses! Selamat Datang Kasir " + dr["nama"].ToString());
                                    Dashboard2 user = new Dashboard2();
                                    user.Show();
                                    this.Hide();
                                    SqlConnect.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Login Gagal! Username atau Password Salah!");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Login Gagal! Data Tidak Ditemukan!");
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
