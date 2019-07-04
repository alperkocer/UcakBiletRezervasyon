using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Odeme
    {
        public int OdemeID { get; set; }
       
        public decimal UcakBiletUcreti { get; set; }
        public decimal KDV { get; set; }
        public decimal Sigorta { get; set; }
        public decimal HizmetBedeli { get; set; }
        public decimal Indirim { get; set; }

        public virtual List<Bilet> Biletler { get; set; }

        public virtual KartBilgileri KartBilgileri { get; set; }

    }
}
