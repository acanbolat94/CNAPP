using CNAPP.Entity.Abstract;
using System.Collections.Generic;

namespace CNAPP.Entity.Concrete
{
    public class Department : BaseEntity
    {
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
