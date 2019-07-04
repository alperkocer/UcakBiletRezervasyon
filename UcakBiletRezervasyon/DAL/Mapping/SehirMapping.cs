using DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
   public class SehirMapping : EntityTypeConfiguration<Sehir>
    {
        public SehirMapping()
        {
            ToTable("Sehirler");

            HasKey(x => x.SehirID);
            

        }
    }
}
