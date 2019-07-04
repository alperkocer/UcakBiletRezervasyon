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
    public partial class YolcuBilgileri : Form
    {        
        Biletler anaForm;
        public YolcuBilgileri(Biletler bilet)
        {
            anaForm = bilet;
            InitializeComponent();
        }

        private Context _context;
        private IUnitOfWork uow;
        private IRepository<Yolcu> _yolcuRepository;
        int a = Bilgiler.Yolcular;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void YolcuBilgileri_Load(object sender, EventArgs e)
        {
            lblYolcuBilgileri.Text = a + " Yolcu Bilgilerini Giriniz";
            if (a == 1)
                btnDevam.Visible = false;
            else if (a != 1)
                btnKoltukSecimi.Enabled = false;
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            if (Metotlar.BosAlanVarMi2(panelYolcu))
            {
                MessageBox.Show("Tüm bilgileri giriniz!!!");
            }
            else
            {
                lblYolcuBilgileri.Text = (a - 1) + " Yolcu Bilgilerini Giriniz";
                a--;
                _context = new Context();
                uow = new UnitOfWork(_context);
                _yolcuRepository = new Repository<Yolcu>(_context);

                Yolcu yolcuEkle = new Yolcu
                {
                    YolcuAdi = txtAd.Text,
                    YolcuSoyadi = txtSoyad.Text,
                    DogumTarihi = dtDogumTarihi.Value,
                    Cinsiyet = rdbBay.Checked ? false : true,
                    TcNo = mskTc.Text,
                    Email = txtEmail.Text,
                    Telefon = mskTelefon.Text
                };

                _yolcuRepository.Add(yolcuEkle);
                Metotlar.Temizle(panelYolcu);

                if (a > 1)
                {
                    int islem = uow.SaveChanges();
                    MessageBox.Show(" yolcunun bilgileri eklendi");
                    btnKoltukSecimi.Enabled = false;

                }
                else if (a == 1)
                {
                    btnDevam.Visible = false;
                    btnKoltukSecimi.Enabled = true;
                    int islem = uow.SaveChanges();
                    MessageBox.Show(" yolcunun bilgileri eklendi");
                }
            }
             
        }
        private void btnKoltukSecimi_Click(object sender, EventArgs e)
        {
            if (Metotlar.BosAlanVarMi2(panelYolcu))
            {
                MessageBox.Show("Tüm bilgileri giriniz!!!");
            }
            else
            {
                _context = new Context();
                uow = new UnitOfWork(_context);
                _yolcuRepository = new Repository<Yolcu>(_context);

                Yolcu yolcuEkle = new Yolcu
                {
                    YolcuAdi = txtAd.Text,
                    YolcuSoyadi = txtSoyad.Text,
                    DogumTarihi = dtDogumTarihi.Value,
                    Cinsiyet = rdbBay.Checked ? false : true,
                    TcNo = mskTc.Text,
                    Email = txtEmail.Text,
                    Telefon = mskTelefon.Text
                };

                _yolcuRepository.Add(yolcuEkle);
                int islem = uow.SaveChanges();
                a--;
                Metotlar.Temizle(panelYolcu);

                KoltukSecimi kSecim = new KoltukSecimi(this);
                kSecim.Show();
                this.Hide();
            }
        }
    }
}
