using DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    public class BiletMapping : EntityTypeConfiguration<Bilet>
    {
        public BiletMapping()
        {
            ToTable("Biletler");

            HasKey(x => x.BiletID);
           
            Property(x => x.UcakID).IsRequired();
            Property(x => x.PNR).IsRequired();
            Property(x => x.SeferID);
            Property(x => x.RezervasyonKodu).IsRequired().HasMaxLength(6);
            Property(x => x.Sinif).IsRequired().HasMaxLength(10);
            Property(x => x.GidisTarihi).HasColumnType("datetime2").IsOptional();
            Property(x => x.DonusTarihi).HasColumnType("datetime2").IsOptional();

            HasRequired(x => x.Sefer).WithMany(x => x.Biletler).HasForeignKey(x=> x.SeferID);
            HasRequired(x => x.Odeme).WithMany(x => x.Biletler).HasForeignKey(X=>X.OdemeID);
            HasRequired(x => x.Ucak).WithMany(x => x.Biletler).HasForeignKey(x => x.UcakID);
            HasRequired(x => x.Yolcu).WithMany(x => x.Biletler).HasForeignKey(x=>x.YolcuID);

        }
    }
}
