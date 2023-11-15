using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TampilBus;

namespace Pendaftaran_Filkom_Day
{
    public partial class PendaftaranDataOnly : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor
        public PendaftaranDataOnly()
        {
            InitializeComponent();
            random = new Random();

            btnCloseChildForm.Visible = false;
        }

        //methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null && btnSender is Button)
            {
                Button clickedButton = (Button)btnSender;
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelIntro.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "FILKOM DAY";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelIntro.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
        private void PendaftaranDataOnly_Load(object sender, EventArgs e)
        {

        }

        private void btnDPendaftaran_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDPendaftaran(), sender);
        }

        private void btnDBus_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Tampbus(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
       

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnCRPendaftaran_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CRPendaftaran(), sender);
        }

        private void btnCRBus_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CRBus(), sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
