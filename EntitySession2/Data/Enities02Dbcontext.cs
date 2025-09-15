using EntitySession2.Data.Configurations;
using EntitySession2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession2.Data
{
    internal class Enities02Dbcontext:DbContext
    {
        public Enities02Dbcontext():base()
        {
            
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=G03; Trusted_Connection=True; TrustServerCertificate=True");
     
        }

        public DbSet<Employee>Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>()
            //     .ToTable("Employess")
            //     .HasKey(Emp => Emp.EmpId);
            ////Identity Constrain(1,1)
            ////modelBuilder.Entity<Employee>().Property("Name"); 
            //// maybe throw exeption if the paremeter is wrong 

            //// modelBuilder.Entity<Employee>().Property<string>()
            //modelBuilder.Entity<Employee>().Property(emp => emp.EmpName)
            //      .HasColumnName("EmployeeName")
            //      .HasColumnType("VarChar")
            //      .HasMaxLength(50)
            //      .IsRequired();






            //modelBuilder.Entity<Department>(D => {

            //    D.ToTable("Departments_Table")
            //    .HasKey(Dep => Dep.DeptId);

            //    D.Property(d => d.DeptId)
            //    .UseIdentityColumn(1, 2);

            //    D.Property(d => d.Name)
            //    .HasColumnType("varchar")
            //    .HasMaxLength(50);





            // });



            //modelBuilder.ApplyConfiguration(new EmployeeConfiguraions());
            //modelBuilder.ApplyConfiguration(new DeparmentConfugurations());


            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
          
        }









    }



    
}
