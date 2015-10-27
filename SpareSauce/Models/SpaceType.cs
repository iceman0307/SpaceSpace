using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpareSpace.Models
{
    public class SpaceType
    {
        [Key]
        public int SpaceTypeId { get; set; }
        public string Name { get; set; }
    }
}
