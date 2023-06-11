using CNAPP.Dto.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNAPP.Dto.Concrete
{
    public class EmployeeDto : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
    }
}
