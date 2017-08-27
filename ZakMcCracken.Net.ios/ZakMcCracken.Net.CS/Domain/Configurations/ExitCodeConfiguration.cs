using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZakMcCracken.Net.CS.Extensions;

namespace ZakMcCracken.Net.CS.Domain.Configurations
{
  public   class ExitCodeConfiguration : EntityTypeConfiguration<ExitCode>
    {
        public ExitCodeConfiguration()
        {

            ToTable("tblExitCode");
            HasKey(x => x.PkExitCode);

            Property(x => x.Section)
                .IsRequired()  
                .HasUniqueIndexAnnotation("IXUniqueExitCode", 0);
            Property(x => x.Zeile)
                .IsRequired()
                .HasUniqueIndexAnnotation("IXUniqueExitCode", 1);
            Property(x => x.Spalte)
                .IsRequired()
                .HasUniqueIndexAnnotation("IXUniqueExitCode", 2);

            Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(4)
                .IsFixedLength();

        }

    }
}
