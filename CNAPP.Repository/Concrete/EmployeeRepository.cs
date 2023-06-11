using CNAPP.Entity.Concrete;
using CNAPP.Entity.Context;

namespace CNAPP.Repository.Concrete
{
    public class EmployeeRepository : BaseRepository<Employee>
    {
        public EmployeeRepository(CNAPPContext dbContext) : base(dbContext)
        {

        }
    }
}
