using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_2.Entities;

namespace Session_2.Confegrations
{
    internal class EmployeeConfigrations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(E => E.Id);
            builder.Property(E => E.Id).UseIdentityColumn(10, 10);
            builder.Property(E => E.Name).HasColumnName("EmployeeName")
                                         .HasColumnType("nvarchar")
                                         .HasMaxLength(50)
                                         .IsRequired();

            builder.Property(E => E.Salary).HasColumnType("decimal(18,2)")
                                           .IsRequired(false);

        }
    }
}
