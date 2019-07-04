using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar
{
    public partial class Giris : Form
    {

        Context db;
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            db = new Context();
            txtParola.PasswordChar = '*';
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (db.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == txtKullaniciAdi.Text && x.Parola == txtParola.Text) != null)
            {
                UcusAra ucusAra = new UcusAra(this);
                ucusAra.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Kullanıcı adı veya şifreyi yanlış girdiniz. Lütfen tekrar deneyiniz!");

            txtKullaniciAdi.Text = txtParola.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeOl uyeol = new UyeOl();
            uyeol.Show();
            this.Hide();
        }
               
               
        private void button1_Click(object sender, EventArgs e)
        {
            UcusAra ucus = new UcusAra(this);
            ucus.Show();
            this.Hide();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
        }

        private void Giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }
    }
}
