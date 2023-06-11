using CNAPP.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CNAPP.Entity.Context
{
    public class CNAPPContext : DbContext
    {
        public Employee Employees { get; set; }
        public Department Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=CNAPP; Trusted_Connection=true");
        }
    }
}
