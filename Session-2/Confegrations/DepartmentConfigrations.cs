using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_2.Entities;

namespace Session_2.Confegrations
{
    internal class DepartmentConfigrations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(D => D.Id);
            builder.Property(D => D.Id).UseIdentityColumn(100,100);
            builder.Property(D => D.DeptName).HasColumnName("DepartmentName")
                                             .HasColumnType("varchar")
                                             .HasMaxLength(100);



        }
    }
}
