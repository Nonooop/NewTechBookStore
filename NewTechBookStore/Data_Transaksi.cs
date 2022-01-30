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
    public partial class Data_Transaksi : Form
    {
        private SqlCommand cmd;
        private SqlDataReader dr;
        public Data_Transaksi()
        {
            InitializeComponent();
        }
        void Display()
        {
            try
            {
                using (SqlConnection SqlConnect = new SqlConnection(Koneksi.Connect))
                {
                    SqlConnect.Open();
                    SqlDataAdapter sqlDisplay = new SqlDataAdapter("EXEC spDataTransaksi", SqlConnect);
                    sqlDisplay.SelectCommand.ExecuteNonQuery();

                    DataTable data = new DataTable();
                    sqlDisplay.Fill(data);

                    dgvTransaksi.DataSource = data;
                
                    SqlDataAdapter GetUser = new SqlDataAdapter("EXEC spCariDataUser @CARI", SqlConnect);
                    GetUser.SelectCommand.Parameters.AddWithValue("@CARI", Login.user);
                    GetUser.SelectCommand.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    GetUser.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            String n = dr["id_user"].ToString();
                            txtIDUser.Text = n.ToString();
                        }
                    }
                    SqlConnect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Search()
        {
            try
            {
                using (SqlConnection SqlConnect = new SqlConnection(Koneksi.Connect))
                {
                    SqlConnect.Open();
                    SqlDataAdapter GetUser = new SqlDataAdapter("EXEC spCariDataTransaksi @CARI", SqlConnect);
                    GetUser.SelectCommand.Parameters.AddWithValue("@CARI", txtCari.Text.Trim());
                    GetUser.SelectCommand.ExecuteNonQuery();

                    DataTable data = new DataTable();
                    GetUser.Fill(data);

                    dgvTransaksi.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void IdOtomatis()
        {
            long itung;
            string urut;
            using (SqlConnection IdSqlConnect = new SqlConnection(Koneksi.Connect))
            {
                IdSqlConnect.Open();
                cmd = new SqlCommand("EXECUTE spIdTransaksi", IdSqlConnect);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    itung = Convert.ToInt64(dr[0].ToString().Substring(dr["id_transaksi"].ToString().Length - 4, 4)) + 1;
                    string idurut = "0000" + itung;
                    urut = "TSR" + idurut.Substring(idurut.Length - 4, 4);
                }
                else
                {
                    urut = "TSR0001";
                }
                dr.Close();
                txtID.Text = urut;
            }

        }
        
        void comboPelanggan()
        {
            using (SqlConnection IdSqlConnect = new SqlConnection(Koneksi.Connect))
            {
                IdSqlConnect.Open();
                cmd = new SqlCommand("EXEC spDataNamaPelanggan", IdSqlConnect);
                dr = cmd.ExecuteReader();
                dr.Read();
                while (dr.Read())
                {
                    cbIDCust.Items.Add(dr[0].ToString());
                }
            }
        }

        void comboBuku()
        {
            using (SqlConnection IdSqlConnect = new SqlConnection(Koneksi.Connect))
            {
                IdSqlConnect.Open();
                cmd = new SqlCommand("EXEC spDataNamaBuku", IdSqlConnect);
                dr = cmd.ExecuteReader();
                dr.Read();
                while (dr.Read())
                {
                    cbIDBrg.Items.Add(dr[0].ToString());
                }
            }
        }

        void ClearData()
        {
            txtID.Clear();
            txtKuantitas.Clear();
            txtCari.Clear();
        }

        private void Data_Transaksi_Load(object sender, EventArgs e)
        {
            ClearData();
            IdOtomatis();
            Display();
            comboBuku();
            comboPelanggan();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtID.Text.Trim() == "" || txtIDUser.Text.Trim() == "" || cbIDCust.Text.Trim() == "" ||
                cbIDBrg.Text.Trim() == "" || txtKuantitas.Text.Trim() == "" )
                {
                    MessageBox.Show("Data tidak boleh dikosongkan");
                }
                else
                {
                    using (SqlConnection SqlConnectSimpan = new SqlConnection(Koneksi.Connect))
                    {
                        SqlConnectSimpan.Open();
                        int x,y, total;
                        x = int.Parse(this.txtKuantitas.Text);
                        SqlDataAdapter GetUser = new SqlDataAdapter("EXEC spCariDataBuku @CARI", SqlConnectSimpan);
                        GetUser.SelectCommand.Parameters.AddWithValue("@CARI", cbIDBrg.Text.Trim());
                        GetUser.SelectCommand.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        GetUser.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            foreach (DataRow dr in dt.Rows)
                            {
                                String n = dr["harga"].ToString();
                                y = Convert.ToInt32(n);
                                total = x * y;
                                txtCari.Text = total.ToString();
                            }
                        }
                        SqlDataAdapter Insert = new SqlDataAdapter("EXEC spInputTransaksi @ID, @PELAYAN, @PELANGGAN, @BARANG,@JUMLAH,@TOTAL", SqlConnectSimpan);
                        Insert.SelectCommand.Parameters.AddWithValue("@ID", txtID.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@PELAYAN", txtIDUser.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@PELANGGAN", cbIDCust.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@BARANG", cbIDBrg.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@JUMLAH", txtKuantitas.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@TOTAL", txtCari.Text.Trim());
                        Insert.SelectCommand.ExecuteNonQuery();

                        MessageBox.Show("Data Tersimpan");
                        ClearData();
                        IdOtomatis();
                        Display();
                        SqlConnectSimpan.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvTransaksi.SelectedRows)
                {
                    txtID.Text = row.Cells[0].Value.ToString();
                    txtIDUser.Text = row.Cells[2].Value.ToString();
                    cbIDCust.Text = row.Cells[3].Value.ToString();
                    cbIDBrg.Text = row.Cells[4].Value.ToString();
                    txtKuantitas.Text = row.Cells[5].Value.ToString();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection IdSqlConnectEdit = new SqlConnection(Koneksi.Connect))
                {
                    IdSqlConnectEdit.Open();
                    DialogResult dr = MessageBox.Show("Anda yakin ingin mengubah data " + txtID.Text + " ?",
                        "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        int x, y, total;
                        x = int.Parse(this.txtKuantitas.Text);
                        SqlDataAdapter GetUser = new SqlDataAdapter("EXEC spCariDataBuku @CARI", IdSqlConnectEdit);
                        GetUser.SelectCommand.Parameters.AddWithValue("@CARI", cbIDBrg.Text.Trim());
                        GetUser.SelectCommand.ExecuteNonQuery();
                        DataTable dat = new DataTable();
                        GetUser.Fill(dat);
                        if (dat.Rows.Count > 0)
                        {
                            foreach (DataRow drow in dat.Rows)
                            {
                                String n = drow["harga"].ToString();
                                y = Convert.ToInt32(n);
                                total = x * y;
                                txtCari.Text = total.ToString();
                            }
                        }
                        SqlCommand update = new SqlCommand("EXEC spUpdateTransaksi @ID,@PELANGGAN, @BARANG,@JUMLAH,@TOTAL", IdSqlConnectEdit);
                        update.Parameters.AddWithValue("@ID", txtID.Text.Trim());
                        update.Parameters.AddWithValue("@PELANGGAN", cbIDCust.Text.Trim());
                        update.Parameters.AddWithValue("@BARANG", cbIDBrg.Text.Trim());
                        update.Parameters.AddWithValue("@JUMLAH", txtKuantitas.Text.Trim());
                        update.Parameters.AddWithValue("@TOTAL", txtCari.Text.Trim());

                        update.ExecuteNonQuery();

                        MessageBox.Show("Data " + txtID.Text+"  Terupdate");
                        ClearData();
                        IdOtomatis();
                        Display();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection IdSqlConnectHps = new SqlConnection(Koneksi.Connect))
                {
                    IdSqlConnectHps.Open();
                    DialogResult dr = MessageBox.Show("Anda yakin ingin menghapus data " + txtID.Text + " ?",
                        "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        SqlCommand hapus = new SqlCommand("EXEC spHapusTransaksi @ID ", IdSqlConnectHps);
                        hapus.Parameters.AddWithValue("@ID", txtID.Text);
                        hapus.ExecuteNonQuery();

                        MessageBox.Show("Data " + txtID.Text + "  Terhapus");
                        ClearData();
                        IdOtomatis();
                        Display();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
            IdOtomatis();
            Display();
        }
    }
}
