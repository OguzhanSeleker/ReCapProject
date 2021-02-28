
using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class Car : BaseEntity, IEntity
    {
        
        [Required]
        public int BrandId { get; set; }
        [Required]
        public int ColorId { get; set; }
        [Required]
        public int ModelYear { get; set; }
        [Required]
        public decimal DailyPrice { get; set; }
        [Required]
        public string Description { get; set; }

        [ForeignKey("BrandId")]
        public Brand Brand{ get; set; }

        [ForeignKey("ColorId")]
        public Color Color { get; set; }
    }
}
