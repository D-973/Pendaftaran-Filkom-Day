using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendaftaran_Filkom_Day
{
    public partial class Pendaftaran : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        
        //Constructor
        public Pendaftaran()
        {
            InitializeComponent();
            random = new Random();

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
                    
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void Pendaftaran_Load(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnPendaftaran_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnDPendaftaran_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnDBus_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
