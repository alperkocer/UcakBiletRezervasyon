using DAL;
using DAL.Repositories;
using DAL.Repository;
using DAL.UnitOfWork;
using DATA;
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
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
        }

        private Context _context;
        private IUnitOfWork uow;
        private IRepository<Kullanici> kullaniciRepository;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            _context = new Context();
            uow = new UnitOfWork(_context);
            kullaniciRepository = new Repository<Kullanici>(_context);

           
            if (Metotlar.BosAlanVarMi(pnlUyeKayit))
            {
                MessageBox.Show("Lütfen kayıt için tüm alanları doldurunuz!");
            }
            else
            {
                Kullanici kullaniciEkle = new Kullanici
                {
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Parola = txtParola.Text
                };

                if(_context.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == txtKullaniciAdi.Text) != null)
                {
                    MessageBox.Show("Aynı kullanıcı adıyla kayıt oluşturulamaz");
                }
                else
                {
                    kullaniciRepository.Add(kullaniciEkle);
                    int islem = uow.SaveChanges();
                    MessageBox.Show("Üye kaydınız oluşturulmuştur.");
                }
            }
        }     
        private void btnKaydet_MouseHover(object sender, EventArgs e)
        {
            btnKaydet.BackColor = Color.Maroon;
        }

        private void btnKaydet_MouseLeave(object sender, EventArgs e)
        {
            btnKaydet.BackColor = Color.Firebrick;
        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            this.Hide();
            giris.Show();
        }

        private void UyeOl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }
    }
}
