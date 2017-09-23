using System;
using System.ComponentModel.DataAnnotations;

namespace MemberApi.Models
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
    }
}