using DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
   public class SeferMapping : EntityTypeConfiguration<Sefer>
    {
        public SeferMapping()
        {
            ToTable("Seferler");
            

            HasKey(x => x.SeferID);
            Property(x => x.KalkisSehir).IsRequired();
            Property(x => x.VarisSehir).IsRequired();
            Property(x => x.KalkisSaati).IsRequired();
            Property(x => x.Sure).IsRequired();
            Property(x => x.Ucret).IsRequired().HasColumnType("money");

            HasRequired(x => x.KalkisSehirBilgisi).WithMany(x => x.KalkisSehirBilgi).HasForeignKey(x=>x.KalkisSehir).WillCascadeOnDelete(false);

            HasRequired(x => x.VarisSehirBilgisi).WithMany(x => x.VarisSehirBilgi).HasForeignKey(x=>x.VarisSehir).WillCascadeOnDelete(false);



        }
    }
}
