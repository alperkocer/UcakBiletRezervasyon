using DAL;
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
    public partial class Odeme : Form
    {
        YemekBagajSecimi anaForm;
        public Odeme(YemekBagajSecimi secim)
        {
            anaForm = secim;
            InitializeComponent();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Odeme_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }
        private void Odeme_Load(object sender, EventArgs e)
        {
            pnlOdemeForm.Enabled = false;
            lblYemekBilet.Text = (Bilgiler.YemekSecimi + Bilgiler.BagajSecimi).ToString();
        }
    }
}
