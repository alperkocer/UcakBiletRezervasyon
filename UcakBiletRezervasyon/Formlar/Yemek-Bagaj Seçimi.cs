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
    public partial class YemekBagajSecimi : Form
    {
        KoltukSecimi anaForm;
        public YemekBagajSecimi(KoltukSecimi secim)
        {
            anaForm = secim;
            InitializeComponent();
        }
        private void btnDigerHizmetler_Click(object sender, EventArgs e)
        {
            Odeme odeme = new Odeme(this);
            odeme.Show();
            this.Hide();
        }

        private void YemekBagajSecimi_Load(object sender, EventArgs e)
        {
            pnlYemekBagaj.Enabled = false;
            cmbKahvaltilik.Items.Add("Tost  20Tl");
            cmbKahvaltilik.Items.Add("Sandviç  15Tl");
            cmbKahvaltilik.Items.Add("Izgara  45Tl");
            cmbKahvaltilik.Items.Add("Tatlı   30Tl");

            if (cmbKahvaltilik.SelectedIndex == 0)
            {
                Bilgiler.YemekSecimi = 20;
            }
            else if (cmbKahvaltilik.SelectedIndex == 1)
            {
                Bilgiler.YemekSecimi = 15;
            }
            else if (cmbKahvaltilik.SelectedIndex == 2)
            {
                Bilgiler.YemekSecimi = 45;
            }
            else if (cmbKahvaltilik.SelectedIndex == 3)
            {
                Bilgiler.YemekSecimi = 30;
            }

            if (cmbBagajArtır.SelectedIndex == 0)
            {
                Bilgiler.BagajSecimi = 25;
            }
            else if (cmbBagajArtır.SelectedIndex == 1)
            {
                Bilgiler.BagajSecimi = 50;
            }
            else if (cmbBagajArtır.SelectedIndex == 2)
            {
                Bilgiler.BagajSecimi = 100;
            }
            else if (cmbBagajArtır.SelectedIndex == 3)
            {
                Bilgiler.BagajSecimi = 150;
            }

        }

        private void YemekBagajSecimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }
    }
}
