using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendaftaran_Filkom_Day.Forms
{
    public partial class FormDPendaftaran : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        public FormDPendaftaran()
        {
            alamat = "server=localhost; database=filkomday; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void FormDPendaftaran_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                query = string.Format("select * from da");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "NIM";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "Nama Belakang";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Nama Depan";
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[3].HeaderText = "Prodi";
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[4].HeaderText = "Tingkat";
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[5].HeaderText = "Ukuran Baju";
                dataGridView1.Columns[6].Width = 100;
                dataGridView1.Columns[6].HeaderText = "Makanan";
                dataGridView1.Columns[7].Width = 100;
                dataGridView1.Columns[7].HeaderText = "Biaya";
                dataGridView1.Columns[8].Width = 100;
                dataGridView1.Columns[8].HeaderText = "Note";
                dataGridView1.Columns[9].Width = 100;
                dataGridView1.Columns[9].HeaderText = "Penanggung Jawab";
                dataGridView1.Columns[10].Width = 100;
                dataGridView1.Columns[10].HeaderText = "Tanggal";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
