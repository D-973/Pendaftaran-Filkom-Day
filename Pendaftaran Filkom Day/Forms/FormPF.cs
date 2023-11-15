using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pendaftaran_Filkom_Day.Forms
{
    public partial class FormPF : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public FormPF()
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
            TxtNIM.Text = string.Empty;
            TxtLastName.Text = string.Empty;
            TxtFirstName.Text = string.Empty;
            CBProdi.SelectedIndex = -1;  // Assuming CBProdi is a ComboBox
            CBSize.SelectedIndex=-1;
            CBMakanan.SelectedIndex = -1;
            TxtBiaya.Text = string.Empty;
            CBNote.SelectedIndex = -1; 
            TxtPenanggung.Text = string.Empty;
            TxtDate.Text = string.Empty;
            CBTingkat.SelectedIndex = -1;

            // Other form-specific reset actions...

            // Optionally, you can re-run the FormPF_Load method to reinitialize the form
            FormPF_Load(null, null);
        }

        private void FormPF_Load(object sender, EventArgs e)
        {
            LoadTheme();
            TxtNIM.Text = string.Empty;
            TxtLastName.Text = string.Empty;
            TxtFirstName.Text = string.Empty;
            CBProdi.SelectedIndex = -1;  // Assuming CBProdi is a ComboBox
            CBSize.SelectedIndex = -1;
            CBTingkat.SelectedIndex = -1;
            CBMakanan.SelectedIndex = -1;
            TxtBiaya.Text = string.Empty;
            CBNote.SelectedIndex = -1;
            TxtDate.Text = string.Empty;
            TxtPenanggung.Text = string.Empty;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                query = string.Format("select * from da where NIM = '{0}'", TxtNIM.Text);
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
                        TxtLastName.Text = kolom["Nama_Belakang"].ToString();
                        TxtFirstName.Text = kolom["Nama_Depan"].ToString();
                        CBProdi.Text = kolom["Prodi"].ToString();
                        CBTingkat.Text =kolom["Tingkat"].ToString();
                        CBSize.Text = kolom["Ukuran_Baju"].ToString();
                        CBMakanan.Text = kolom["Makanan"].ToString();
                        TxtBiaya.Text = kolom["Biaya"].ToString();
                        CBNote.Text = kolom["Note"].ToString();
                        TxtPenanggung.Text = kolom["Penanggung_Jawab"].ToString();
                        TxtDate.Text = kolom["Tanggal"].ToString() ;
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

        private void btnNew_Click(object sender, EventArgs e)
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("UPDATE `da` SET `Ukuran_Baju` = '{0}', `Makanan` = '{1}', `Biaya` = '{2}', `Note` = '{3}', `Penanggung_Jawab` = '{4}', `Tanggal` = '{5}' WHERE NIM = '{6}'", CBSize.Text, CBMakanan.Text, TxtBiaya.Text, CBNote.Text, TxtPenanggung.Text, TxtDate.Text, TxtNIM.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                ReloadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
