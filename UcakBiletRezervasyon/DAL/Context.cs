using DAL.Mapping;
using DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class Context : DbContext
    {
       // internal object Ucak;

        public Context()
        {
            Database.Connection.ConnectionString = "server=.; database=UcakDb; uid=sa; pwd=123;";
        }

        public DbSet<Yolcu> Yolcular { get; set; }
        public DbSet<Bilet> Biletler { get; set; }
        public DbSet<Ucak> Ucaklar   { get; set; }
        public DbSet<Sefer> Seferler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Odeme> Odemeler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KartBilgileri> KartBilgilerii { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new BiletMapping());
            modelBuilder.Configurations.Add(new OdemeMapping() );
            modelBuilder.Configurations.Add(new SeferMapping());
            modelBuilder.Configurations.Add(new SehirMapping());
            modelBuilder.Configurations.Add(new UcakMapping());
            modelBuilder.Configurations.Add(new YolcuMapping());
            modelBuilder.Configurations.Add(new KullaniciMapping());
            modelBuilder.Configurations.Add(new KartBilgileriMapping());

            base.OnModelCreating(modelBuilder);

        }
    }
}
