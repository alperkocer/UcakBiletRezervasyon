using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Ucak
    {
        public int UcakID { get; set; }
        public int UcakNo { get; set; }
        public short EconomyKoltukSayisi { get; set; }
        public short BusinessKoltukSayisi { get; set; }

        public virtual List<Bilet> Biletler { get; set; }
    }
}
