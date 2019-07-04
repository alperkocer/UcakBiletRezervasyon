using DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
   public class OdemeMapping : EntityTypeConfiguration<Odeme>
    {
        public OdemeMapping()
        {
            ToTable("Odemeler");

            HasKey(x => x.OdemeID);
            Property(x => x.UcakBiletUcreti).IsRequired();

            HasRequired(x => x.KartBilgileri).WithRequiredPrincipal(x => x.Odeme);

        }
    }
}
