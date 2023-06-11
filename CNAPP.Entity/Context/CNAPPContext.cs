using CNAPP.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CNAPP.Entity.Context
{
    public class CNAPPContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=CNAPPDEV; Trusted_Connection=true");
        }
    }
}
