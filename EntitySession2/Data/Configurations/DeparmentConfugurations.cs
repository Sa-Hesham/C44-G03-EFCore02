using EntitySession2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession2.Data.Configurations
{
    internal class DeparmentConfugurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Department> builder)
        {

           
            builder .ToTable("Departments_Table")
                .HasKey(Dep => Dep.DeptId);

               builder .Property(d => d.DeptId)
                .UseIdentityColumn(1, 2);

               builder .Property(d => d.Name)
                .HasColumnType("varchar")
                .HasMaxLength(20);




           
        }
    }
}
