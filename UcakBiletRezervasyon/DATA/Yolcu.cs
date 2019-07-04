using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class Yolcu
    {        
        public int YolcuID { get; set; }       
       
        public string YolcuAdi { get; set; }
      
        public string YolcuSoyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Cinsiyet { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }   
        public string Telefon { get; set; }  
        
        public bool IsParent { get; set; }
      
        

        public virtual List<Bilet> Biletler { get; set; }
       
    }
}
