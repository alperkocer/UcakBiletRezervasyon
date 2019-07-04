using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar
{
    public partial class KoltukSecimi : Form
    {
        YolcuBilgileri anaForm;
        public KoltukSecimi(YolcuBilgileri yolcu)
        {
            anaForm = yolcu;
            InitializeComponent();
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            YemekBagajSecimi secim = new YemekBagajSecimi(this);
            secim.Show();
            this.Hide();
        }

        private void KoltukSecimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }

        private void KoltukSecimi_Load(object sender, EventArgs e)
        {
            pnlKoltukSecimi.Enabled = false;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
