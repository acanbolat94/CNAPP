using CNAPP.Dto.Abstract;
using CNAPP.Entity.Concrete;
using System.Collections.Generic;

namespace CNAPP.Dto.Concrete
{
    public class DepartmentDto : BaseDto
    {
        public string DepartmentName { get; set; }
        public string Description { get; set; }
    }
}
