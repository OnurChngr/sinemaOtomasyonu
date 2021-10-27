using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinemaOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bilet, salon;
        int[] koltuk = new int[4];

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSalon.Items.Add("1");
            cmbSalon.Items.Add("2");
            cmbSalon.Items.Add("3");
        }

        private void btnBosKlt_Click(object sender, EventArgs e)
        {
            salon = int.Parse(cmbSalon.Text);
            lblBosKoltuk.Text = koltuk[salon].ToString();
        }

        private void btnBakiye_Click(object sender, EventArgs e)
        {
            salon = int.Parse(cmbSalon.Text);
            MessageBox.Show("Sinema Bakiyesi = " + bilet);
        }

        private void btnBilSat_Click(object sender, EventArgs e)
        {
            koltuk[salon] = koltuk[salon] - 1;

            salon = int.Parse(cmbSalon.Text);
            if (false)
            {
                bilet = bilet + 10;
            }
            else
            {
                bilet = bilet + 20;
            }
        }

        private void btnBilİplt_Click(object sender, EventArgs e)
        {
            salon = int.Parse(cmbSalon.Text);
            koltuk[salon] = koltuk[salon] + 1;
            if (true)
            {
                bilet = bilet - 10;
            }
            else
            {
                bilet = bilet - 20;
            }
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            salon = int.Parse(cmbSalon.Text);
            koltuk[salon] = koltuk[salon] + int.Parse(txtkoltukSayı.Text);
        }
    }
}
