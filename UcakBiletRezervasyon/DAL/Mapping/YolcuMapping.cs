using DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
   public class YolcuMapping : EntityTypeConfiguration<Yolcu>
    {
        public YolcuMapping()
        {
            ToTable("Yolcular");

            HasKey(x => x.YolcuID);
            Property(x => x.YolcuAdi).IsRequired().HasMaxLength(50);
            Property(x => x.YolcuSoyadi).IsRequired().HasMaxLength(20); ;
            Property(x => x.DogumTarihi).IsRequired().HasColumnType("datetime2");
            Property(x => x.TcNo).IsRequired().HasMaxLength(11);
            Property(x => x.Email).IsRequired().HasMaxLength(100);

            
           

        }
    }
}
