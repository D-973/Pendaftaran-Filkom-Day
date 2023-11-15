using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Pendaftaran_Filkom_Day;

namespace Tugas_Project_akhir
{
    public partial class FormBus : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        MySqlCommand command;
        DataTable table;
        MySqlDataReader mdr;

        private DataSet ds = new DataSet();
        private string alamat, query;

        public FormBus()
        {
            alamat = "server=localhost; database=filkomday; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void ReloadForm()
        {
            // Clear any textboxes, reset checkboxes, or perform any other necessary actions
            txtnim.Text = string.Empty;
            txtnama.Text = string.Empty;
            txtket.Text = string.Empty;
            txtbus.Text = string.Empty;  

            FormBus_Load(null, null);
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            try
            {
                FormBus_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE db_mahasiswa.mahasiswa SET LAST_NAME = '" + txtnim.Text + "', FIRST_NAME = '" + txtnim.Text + "', NO_BUS = " + int.Parse(txtbus.Text) + " WHERE NIM = " + int.Parse(txtnim.Text);

            koneksi.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(updateQuery, koneksi);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Updated");
                }
                else
                {
                    MessageBox.Show("Data Not Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            koneksi.Close();
        }

        private void btncari_Click_1(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                query = string.Format("select * from mahasiswa where NIM = '{0}'", txtnim.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        txtnama.Text = kolom["LAST_NAME"].ToString();
                        txtbus.Text = kolom["NO_BUS"].ToString();
                        txtket.Text = kolom["KETERANGAN"].ToString() ;

                    }

                }
                else
                {
                    MessageBox.Show("NIM tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormBus_Load_1(object sender, EventArgs e)
        {
            LoadTheme();
            txtnim.Text = string.Empty;
            txtnama.Text = string.Empty;
            txtket.Text = string.Empty;
            txtbus.Text = string.Empty;
            try
            {
                koneksi.Open();

                query = string.Format("select * from mahasiswa");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 30;
                dataGridView1.Columns[0].HeaderText = "NIM";
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[1].HeaderText = "LAST_NAME";
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[2].HeaderText = "FIRST_NAME";
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[3].HeaderText = "NO_BUS";
                dataGridView1.Columns[4].Width = 150;
                dataGridView1.Columns[4].HeaderText = "KETERANGAN";


                txtnim.Clear();
                txtnama.Clear();
                txtbus.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                query = string.Format("update mahasiswa set NO_BUS = '{0}', KETERANGAN = '{1}' where NIM = '{2}'", txtbus.Text, txtket.Text, txtnim.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
               
                FormBus_Load(null, null);
                MessageBox.Show("Data telah disimpan.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnbaru_Click(object sender, EventArgs e)
        {
            try
            {
                ReloadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        private void FormBus_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                query = string.Format("select * from mahasiswa");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 30;
                dataGridView1.Columns[0].HeaderText = "NIM";
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[1].HeaderText = "LAST_NAME";
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[2].HeaderText = "FIRST_NAME";
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[3].HeaderText = "NO_BUS";
                dataGridView1.Columns[4].Width = 150;
                dataGridView1.Columns[4].HeaderText = "KETERANGAN";


                txtnim.Clear();
                txtnama.Clear();
                txtbus.Clear();
                txtket.Clear(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
