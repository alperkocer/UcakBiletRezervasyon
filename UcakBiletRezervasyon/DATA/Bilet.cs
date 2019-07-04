using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Bilet
    {
        public int BiletID { get; set; }
        public int SeferID { get; set; }        
        public string RezervasyonKodu { get; set; }        
        public int UcakID { get; set; }
        public int OdemeID { get; set; }
        public int YolcuID { get; set; }
        public bool YetiskinMi { get; set; }
        public decimal PNR { get; set; }
        public string Sinif { get; set; }
        public string GidisSaati { get; set; }
        public string DonusSaati { get; set; }
        public DateTime GidisTarihi { get; set; }
        public DateTime DonusTarihi { get; set; }
        
       // public bool IsRezervasyon { get; set; }
        public bool Sigorta { get; set; }
        public int KoltukNo { get; set; }

        public virtual Yolcu Yolcu { get; set; }
        public virtual Odeme Odeme { get; set; }
        public virtual Sefer Sefer { get; set; }
        public virtual Ucak Ucak { get; set; }


        public override string ToString()
        {
            return $"{BiletID} - {GidisTarihi.ToShortDateString()} - {DonusTarihi.ToShortDateString()} - {Sigorta}   -  {OdemeID} - {UcakID} - ";
        }

    }
}
