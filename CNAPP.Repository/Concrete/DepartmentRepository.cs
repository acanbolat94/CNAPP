using CNAPP.Entity.Concrete;
using CNAPP.Entity.Context;

namespace CNAPP.Repository.Concrete
{
    public class DepartmentRepository : BaseRepository<Department>
    {
        public DepartmentRepository(CNAPPContext dbContext) : base(dbContext)
        {

        }
    }
}
