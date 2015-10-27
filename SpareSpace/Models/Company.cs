using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpareSpace.Models
{
    public class Company
    {
        [Key]
        public string Name { get; set; }
        public virtual Address Address { get; set; }
        public virtual User ContactPerson { get; set; }
        public virtual Space Space { get; set; }
        public string ImagePath { get; set; }
    }
}
