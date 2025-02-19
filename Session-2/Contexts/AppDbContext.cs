using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Session_2.Confegrations;
using Session_2.Entities;

namespace Session_2.Contexts
{
    internal class AppDbContext : DbContext
    {

        public AppDbContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfigrations());
            modelBuilder.ApplyConfiguration(new DepartmentConfigrations());


            modelBuilder.Entity<Employee>()
                        .HasOne(E => E.Department)
                        .WithOne(E => E.Manager)
                        .HasForeignKey<Department>(E => E.EmpId);


            modelBuilder.Entity<Department>().HasMany(D => D.Employees)
                                             .WithOne(E => E.WorkFor)
                                             .HasForeignKey(E => E.WorkForId);



            modelBuilder.Entity<StudentCourse>().HasKey(SC => new {SC.CourseId , SC.StudentId });


            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Code To Connect To DB
            optionsBuilder.UseSqlServer("Server = .; Database = AppDBG02; Trusted_Connection = True; TrustServerCertificate = True");

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }  



    }
}
