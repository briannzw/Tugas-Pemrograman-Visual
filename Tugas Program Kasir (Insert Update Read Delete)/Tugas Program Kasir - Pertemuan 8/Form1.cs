using System.Data;
using System.Data.SqlClient;
namespace Tugas_Program_Kasir___Pertemuan_7
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if(tb_kode.Text.Trim() == "" || tb_nama.Text.Trim() == "" || tb_jual.Text.Trim() == "" || tb_beli.Text.Trim() == "" || tb_jumlah.Text.Trim() == "" || tb_satuan.Text.Trim() == "")
            {
                MessageBox.Show("Mohon isi terlebih dahulu");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    cmd = new SqlCommand("INSERT INTO TBL_BARANG VALUES ('" + tb_kode.Text + "','" + tb_nama.Text + "','" + tb_jual.Text + "','" + tb_beli.Text + "','" + tb_jumlah.Text + "','" + tb_satuan.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert Data Berhasil");
                    TampilBarang();
                    BersihData();
                }
                catch (Exception ex) {
                    MessageBox.Show("Gagal menyimpan Data");
                }
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (tb_kode.Text.Trim() == "" || tb_nama.Text.Trim() == "" || tb_jual.Text.Trim() == "" || tb_beli.Text.Trim() == "" || tb_jumlah.Text.Trim() == "" || tb_satuan.Text.Trim() == "")
            {
                MessageBox.Show("Mohon isi terlebih dahulu");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    cmd = new SqlCommand("UPDATE TBL_BARANG SET KodeBarang='" + tb_kode.Text + "', NamaBarang='" + tb_nama.Text + "', HargaJual='" + tb_jual.Text + "', HargaBeli='" + tb_beli.Text + "', JumlahBarang='" + tb_jumlah.Text + "', SatuanBarang='" + tb_satuan.Text + "' WHERE KodeBarang='" + tb_kode.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Data Berhasil");
                    TampilBarang();
                    BersihData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengupdate Data");
                }
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(tb_kode.Text.Trim() == "")
            {
                MessageBox.Show("Kode Barang tidak boleh kosong");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    cmd = new SqlCommand("DELETE FROM TBL_BARANG WHERE KodeBarang='" + tb_kode.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Data Berhasil");
                    TampilBarang();
                    BersihData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus Data");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TampilBarang();
            BersihData();
        }

        void TampilBarang()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM TBL_BARANG", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_BARANG");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_BARANG";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        void BersihData()
        {
            tb_kode.Text = "";
            tb_nama.Text = "";
            tb_jual.Text = "0";
            tb_beli.Text = "0";
            tb_jumlah.Text = "0";
            tb_satuan.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tb_kode.Text = row.Cells["KodeBarang"].Value.ToString();
                tb_nama.Text = row.Cells["NamaBarang"].Value.ToString();
                tb_jual.Text = row.Cells["HargaJual"].Value.ToString();
                tb_beli.Text = row.Cells["HargaBeli"].Value.ToString();
                tb_jumlah.Text = row.Cells["JumlahBarang"].Value.ToString();
                tb_satuan.Text = row.Cells["SatuanBarang"].Value.ToString();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}