
namespace EFCore_Session2_Demo
{
    internal class DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CompanyDb;Trusted_Connection=True;");
        }

        internal void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            throw new NotImplementedException();
        }
    }
}