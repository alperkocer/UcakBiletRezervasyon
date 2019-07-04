using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
   public class KartBilgileri
    {
        [Key]
        public int KartID { get; set; }
        public string KartIsim { get; set; }
        public string KartSoyisim { get; set; }
        public string Email { get; set; }
        public string KartNumarasi { get; set; }


        public virtual Odeme Odeme { get; set; }
    }
}
