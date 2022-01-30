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
    public partial class Dashboard2 : Form
    {
        public Dashboard2()
        {
            InitializeComponent();
        }
        private void hide()
        {
            if (panelMaster.Visible == true)
                panelMaster.Visible = false;
        }

        private void show(Panel sub)
        {
            if (sub.Visible == false)
            {
                hide();
                sub.Visible = true;
            }
            else
                sub.Visible = false;
        }

        private Form activeForm = null;
        private void tampilan(Form tampil)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = tampil;
            tampil.TopLevel = false;
            tampil.FormBorderStyle = FormBorderStyle.None;
            tampil.Dock = DockStyle.Fill;
            panelHsl.Controls.Add(tampil);
            panelHsl.Tag = tampil;
            tampil.BringToFront();
            tampil.Show();
        }

        void Display()
        {
            try
            {

                using (SqlConnection SqlConnect = new SqlConnection(Koneksi.Connect))
                {
                    SqlConnect.Open();
                    SqlDataAdapter sqlDisplay = new SqlDataAdapter("EXEC spDataDashboard", SqlConnect);
                    sqlDisplay.SelectCommand.ExecuteNonQuery();

                    DataTable data = new DataTable();
                    sqlDisplay.Fill(data);

                    dgvTransaksiPenjualan.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dashboard2_Load(object sender, EventArgs e)
        {
            lblUser.Text = Login.user;
            Display();
        }
        void Search()
        {
            try
            {
                using (SqlConnection SqlConnect = new SqlConnection(Koneksi.Connect))
                {
                    SqlConnect.Open();
                    SqlDataAdapter carisemua = new SqlDataAdapter("EXEC spCariData4tabel @CARI", SqlConnect);
                    carisemua.SelectCommand.Parameters.AddWithValue("@CARI", txtCari.Text.Trim());
                    carisemua.SelectCommand.ExecuteNonQuery();

                    DataTable data = new DataTable();
                    carisemua.Fill(data);

                    dgvTransaksiPenjualan.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnMaster_Click(object sender, EventArgs e)
        {
            show(panelMaster);
        }

        private void btnBuku_Click(object sender, EventArgs e)
        {
            tampilan(new Data_Buku());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            tampilan(new Data_Pembeli());
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            tampilan(new Data_Transaksi());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCari.Clear();
            Display();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
