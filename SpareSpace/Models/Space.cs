using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SpareSpace.Models
{
    public enum PaymentTerm
    {
        HOURLY, DAILY, WEEKLY, MONTHLY
    }
    public class Space
    {
        [Key]
        public int SpaceId { get; set; }
        public virtual SpaceType Type { get; set; }
        [ForeignKey("SpaceCategoryId")]
        public virtual ICollection<SpaceCategory> Category { get; set; }
        [ForeignKey("BusinessCategoryId")]
        public virtual ICollection<BusinessCategory> BusinessCategory { get; set; }
        public virtual SpaceAttributes Attributes { get; set; }
        public double Price { get; set; }
        public PaymentTerm PaymentTerm { get; set; }
        public string ImagePath { get; set; }
    }
}
