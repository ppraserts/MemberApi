using System;
using System.ComponentModel.DataAnnotations;

namespace Member.Models
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
