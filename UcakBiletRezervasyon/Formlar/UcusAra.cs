using DAL;
using DAL.Repositories;
using DAL.Repository;
using DAL.UnitOfWork;
using DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar
{
    public partial class UcusAra : Form
    {
        Giris anaForm;      
     
        private Context _context;
        private IUnitOfWork _uow;
        private IRepository<Biletler> _biletRepository;
        private IRepository<Sehir> _sehirRepository;
            
        public UcusAra(Giris giris)
        {
            anaForm = giris;
            InitializeComponent();
        }
        Context db;
        private void SehirEkle()
        {
            db = new Context();
            cmbNereden.DataSource = db.Sehirler.ToList();
            cmbNereden.DisplayMember = "SehirHavaalani";
            cmbNereden.ValueMember = "SehirID";
            cmbNereye.DataSource = db.Sehirler.ToList();
            cmbNereye.DisplayMember = "SehirHavaalani";
            cmbNereye.ValueMember = "SehirID";
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _context = new Context();
            _uow = new UnitOfWork(_context);
            _biletRepository = new Repository<Biletler>(_context);
            _sehirRepository = new Repository<Sehir>(_context);
            rdbSatis.Checked = true;
            rdbTek.Checked = true;
            rdbRezervasyon.Enabled = false;
            dtDonusTarihi.Enabled = false;
            pnlYolcuSayı.Visible = false;
            cmbSinif.Items.Add("Economy");
            cmbSinif.Items.Add("Business");
            SehirEkle();
            cmbNereden.SelectedIndex = -1;
            cmbNereye.SelectedIndex = -1;
            nmrYetiskinSayisi.Value = 1;
            cmbNereye.Enabled = false;
            dtGidisTarihi.MinDate = DateTime.Now;
            dtDonusTarihi.MinDate = dtGidisTarihi.Value;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Bilgiler.GidisTarihi = dtGidisTarihi.Value.Date;
            Bilgiler.DonusTarihi = dtDonusTarihi.Value.Date;
            Bilgiler.RezerveMi = rdbRezervasyon.Checked;
            Bilgiler.GidisDonus = rdbGidisDonus.Checked ? true : false;
            Bilgiler.YetiskinMi = nmrYetiskinSayisi.Value > 0 ? true : false;
            Bilgiler.CocukMu = nmrCocukSayisi.Value > 0 ? true : false;
            
            
            if (cmbSinif.SelectedIndex == -1 || cmbNereden.SelectedIndex==-1||cmbNereye.SelectedIndex==-1)
            {
                MessageBox.Show("Lütfen Seçim Yapınız..");
            }
            else if (nmrYetiskinSayisi.Value + nmrCocukSayisi.Value > 7 )
            {
                MessageBox.Show("En fazla 7 kişilik bilet alabilirsiniz..");
            }
            else
            {
                Bilgiler.Sinif = cmbSinif.SelectedItem.ToString();
                Bilgiler.Yolcular = Convert.ToInt32(nmrYetiskinSayisi.Value) + Convert.ToInt32(nmrCocukSayisi.Value);
                Bilgiler.NeredenSehir = (cmbNereden.SelectedItem as dynamic).SehirAdi;
                Bilgiler.NereyeSehir = (cmbNereye.SelectedItem as dynamic).SehirAdi;
                Bilgiler.NereyeSehirID = (int)cmbNereye.SelectedValue;
                Bilgiler.NeredenSehirID = (int)(cmbNereden.SelectedValue);
                Biletler bilet = new Biletler(this);
                bilet.Show();
                this.Hide();
            }
        }      

        private void btnGeri_Click(object sender, EventArgs e)
        {         
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlYolcuSayı.Visible = true;
        }

        private void rdbGidisDonus_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGidisDonus.Checked)
                dtDonusTarihi.Enabled = true;
                
        }

        private void rdbTek_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTek.Checked)
                dtDonusTarihi.Enabled = false;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (cmbNereden.SelectedIndex > -1)
            {
                string temp = (cmbNereden.SelectedItem as dynamic).SehirHavaalani;
                cmbNereden.Text = (cmbNereye.SelectedItem as dynamic).SehirHavaalani;
                cmbNereye.Text = temp;
            }
        }

        private void UcusAra_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }

        private void CmbNereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNereye.Enabled = true;
        }

        private void DtGidisTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtDonusTarihi.MinDate = dtGidisTarihi.Value;
        }
    }
}
