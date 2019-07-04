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
    public partial class Biletler : Form
    {
        UcusAra anaForm;
        public Biletler(UcusAra ucus)
        {
            anaForm = ucus;
            InitializeComponent();
        }
        private Context _context;
        private IUnitOfWork _uow;
        private IRepository<Sefer> _seferRepository;
       

        private void btnDevam_Click(object sender, EventArgs e)
        {
            YolcuBilgileri yolcu = new YolcuBilgileri(this);
            yolcu.Show();
            this.Hide();
        }
        private void Biletler_Load(object sender, EventArgs e)
        {

            lblKalkis1.Text = lblKalkis2.Text = lblKalkis3.Text = lblKalkis4.Text = Bilgiler.NeredenSehir;

            lblVaris1.Text = lblVaris2.Text = lblVaris3.Text = lblVaris4.Text = Bilgiler.NereyeSehir;
            lblTarih.Text = "TARİH (" + Bilgiler.GidisTarihi.ToShortDateString() + " )";

            if (Bilgiler.GidisDonus == true)
            {
                lblTarih.Text = "TARİH (" + Bilgiler.GidisTarihi.ToShortDateString() + " - " + Bilgiler.DonusTarihi.ToShortDateString() + " )";
                lblDonusKalkis1.Text = lblDonusKalkis2.Text = lblDonusKalkis3.Text = lblDonusKalkis4.Text = Bilgiler.NereyeSehir.ToString();

                lblDonusVaris1.Text = lblDonusVaris2.Text = lblDonusVaris3.Text = lblDonusVaris4.Text = Bilgiler.NeredenSehir.ToString();
            }
            else
            {
                panel7.Hide();
            }
        }


        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaForm.Show();
        }

        private void BtnSec1_Click(object sender, EventArgs e)
        {
            _context = new Context();
            _uow = new UnitOfWork(_context);
            _seferRepository = new Repository<Sefer>(_context);

            _seferRepository.Add(new Sefer
            {
                KalkisSehir = Bilgiler.NeredenSehirID,
                VarisSehir = Bilgiler.NereyeSehirID,
                KalkisSaati ="08:00",
                Sure =1,
                Ucret =100
            });
            int islem=_uow.SaveChanges();
            MessageBox.Show("Seçildi");
            panel2.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _context = new Context();
            _uow = new UnitOfWork(_context);
            _seferRepository = new Repository<Sefer>(_context);

            _seferRepository.Add(new Sefer
            {
                KalkisSehir = Bilgiler.NeredenSehirID,
                VarisSehir = Bilgiler.NereyeSehirID,
                KalkisSaati = "11:00",
                Sure = 1,
                Ucret = 80
            });
            int islem = _uow.SaveChanges();
            MessageBox.Show("Seçildi");
            panel4.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            _context = new Context();
            _uow = new UnitOfWork(_context);
            _seferRepository = new Repository<Sefer>(_context);

            _seferRepository.Add(new Sefer
            {
                KalkisSehir = Bilgiler.NeredenSehirID,
                VarisSehir = Bilgiler.NereyeSehirID,
                KalkisSaati = "13:50",
                Sure = 1,
                Ucret = 110
            });
            int islem = _uow.SaveChanges();
            MessageBox.Show("Seçildi");
            panel5.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            _context = new Context();
            _uow = new UnitOfWork(_context);
            _seferRepository = new Repository<Sefer>(_context);

            _seferRepository.Add(new Sefer
            {
                KalkisSehir = Bilgiler.NeredenSehirID,
                VarisSehir = Bilgiler.NereyeSehirID,
                KalkisSaati = "18:20",
                Sure = 1,
                Ucret = 150
            });
            int islem = _uow.SaveChanges();
            MessageBox.Show("Seçildi");
            panel6.Enabled = false;
            panel9.Enabled = false;
        }
        
        private void Biletler_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            _context = new Context();
            _uow = new UnitOfWork(_context);
            _seferRepository = new Repository<Sefer>(_context);

            _seferRepository.Add(new Sefer
            {
                KalkisSehir = Bilgiler.NeredenSehirID,
                VarisSehir = Bilgiler.NereyeSehirID,
                KalkisSaati = "08:00",
                Sure = 1,
                Ucret = 100
            });
            int islem = _uow.SaveChanges();
            MessageBox.Show("Seçildi");
            panel12.Enabled = false;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            _context = new Context();
            _uow = new UnitOfWork(_context);
            _seferRepository = new Repository<Sefer>(_context);

            _seferRepository.Add(new Sefer
            {
                KalkisSehir = Bilgiler.NeredenSehirID,
                VarisSehir = Bilgiler.NereyeSehirID,
                KalkisSaati = "11:00",
                Sure = 1,
                Ucret = 80
            });
            int islem = _uow.SaveChanges();
            MessageBox.Show("Seçildi");
            panel11.Enabled = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            _context = new Context();
            _uow = new UnitOfWork(_context);
            _seferRepository = new Repository<Sefer>(_context);

            _seferRepository.Add(new Sefer
            {
                KalkisSehir = Bilgiler.NeredenSehirID,
                VarisSehir = Bilgiler.NereyeSehirID,
                KalkisSaati = "13:50",
                Sure = 1,
                Ucret = 110
            });
            int islem = _uow.SaveChanges();
            MessageBox.Show("Seçildi");
            panel10.Enabled = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            _context = new Context();
            _uow = new UnitOfWork(_context);
            _seferRepository = new Repository<Sefer>(_context);

            _seferRepository.Add(new Sefer
            {
                KalkisSehir = Bilgiler.NeredenSehirID,
                VarisSehir = Bilgiler.NereyeSehirID,
                KalkisSaati = "18:20",
                Sure = 1,
                Ucret = 150
            });
            int islem = _uow.SaveChanges();
            MessageBox.Show("Seçildi");
            panel9.Enabled = false;
        }
    }
}
