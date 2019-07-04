using DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
   public class KullaniciMapping : EntityTypeConfiguration<Kullanici>
    {

        public KullaniciMapping()
        {
            ToTable("Kullanıcılar");
            HasKey(x => x.KullaniciID);

            Property(x => x.KullaniciAdi).IsRequired();
            Property(x => x.Parola).IsRequired();

        }
    }
}
