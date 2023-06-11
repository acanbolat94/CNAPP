using CNAPP.Entity.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNAPP.Entity.Concrete
{
    public class Employee:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
