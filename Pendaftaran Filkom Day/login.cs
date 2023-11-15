using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendaftaran_Filkom_Day
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "admin" && txt_pass.Text == "12345")
            {
                Pendaftaran pendaftaran = new Pendaftaran();
                pendaftaran.Show();

                this.Hide();
            }
            else if (txt_user.Text == "panitia" && txt_pass.Text == "12345")
            {
                PendaftaranDataOnly pendaftaranDataOnly = new PendaftaranDataOnly();
                pendaftaranDataOnly.Show();
            }
            else
            {
                MessageBox.Show("anda salah memasukkan username atau password");
            }
        }

        private void cb_show_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (cb_show.Checked == true)
                {
                    txt_pass.UseSystemPasswordChar = false;
                }
                else
                { 
                    txt_pass.UseSystemPasswordChar = true; 
                }    
            }

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
