using EntitySession2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession2.Data.Configurations
{
    internal class EmployeeConfiguraions : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
          
       builder.ToTable("Employess")
       .HasKey(Emp => Emp.EmpId);
            //Identity Constrain(1,1)
            //modelBuilder.Entity<Employee>().Property("Name"); 
            // maybe throw exeption if the paremeter is wrong 

            // modelBuilder.Entity<Employee>().Property<string>()
         builder.Property(emp => emp.EmpName)
                  .HasColumnName("EmployeeName")
                  .HasColumnType("VarChar")
                  .HasMaxLength(50)
                  .IsRequired();


            builder.Property(emp => emp.EmpId).UseIdentityColumn(1, 3);
        }
    }
}
