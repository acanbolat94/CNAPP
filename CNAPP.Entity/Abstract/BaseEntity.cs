using System.ComponentModel.DataAnnotations;

namespace CNAPP.Entity.Abstract
{
    public class BaseEntity:IBaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
