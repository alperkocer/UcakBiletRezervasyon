using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Sehir
    {
        public int SehirID { get; set; }      
        public string SehirAdi { get; set; }
        public string HavaalaniAdi { get; set; }

        public string SehirHavaalani { get { return SehirAdi + " - " + HavaalaniAdi; } }

        public virtual List<Sefer> KalkisSehirBilgi { get; set; }
        public virtual List<Sefer> VarisSehirBilgi { get; set; }
    }
}
