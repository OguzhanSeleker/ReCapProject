using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            IsDeleted = false;
            ModifiedDate = DateTime.Now;
        }
        [Key]
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
