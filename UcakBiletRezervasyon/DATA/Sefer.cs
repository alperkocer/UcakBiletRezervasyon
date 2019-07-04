using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Sefer
    {
        public int SeferID { get; set; }
       // public int SehirID { get; set; }
       
        public int KalkisSehir { get; set; }
        public int VarisSehir { get; set; }
        public string KalkisSaati { get; set; }
        public int Sure { get; set; }
        public int Ucret { get; set; }

        public virtual List<Bilet> Biletler { get; set; }
        public virtual Sehir KalkisSehirBilgisi { get; set; }
        public virtual Sehir VarisSehirBilgisi { get; set; }

    }
}
