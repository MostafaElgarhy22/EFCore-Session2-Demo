using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Session2_Demo
{
    internal class CompanyDbContext : DbContext
    {

        public CompanyDbContext() : base()
        {

        }



        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CompanyDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Fluent API for each and every Model.

            modelBuilder.ApplyConfiguration(new EmployeeConfigurations());

            
        }
    }

    internal class DbContext
    {

        protected virtual void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
