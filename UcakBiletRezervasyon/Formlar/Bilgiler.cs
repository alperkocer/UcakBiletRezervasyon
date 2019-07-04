using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formlar
{
   public class Bilgiler
    {
        public static DateTime GidisTarihi { get; set; }
        public static DateTime DonusTarihi { get; set; }
        public static string NeredenSehir { get; set; }
        public static int NeredenSehirID { get; set; }
        public static int NereyeSehirID { get; set; }
        public static string NereyeSehir { get; set; }
        public static string Sinif { get; set; }
        public static bool RezerveMi { get; set; }
        public static bool SatisMi { get; set; }
        public static int Yolcular { get; set; }
        public static bool YetiskinMi { get; set; }
        public static bool CocukMu { get; set; }
        public static bool GidisDonus { get; set; }
        public static bool TekYon { get; set; }
        public static int YemekSecimi { get; set; }
        public static int BagajSecimi { get; set; }
    }


    //public enum SeyahatTipi
    //{
    //    GidisDonus,
    //    TekYon
    //}
}
