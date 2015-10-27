using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SpareSpace.Models
{
    public class SpaceAttributes
    {
        [Key]
        public int SpaceAttributesId { get; set; }
        public int Size { get; set; }
        public TimeSpan OpeningHours { get; set; }
        public virtual ICollection<SpaceElement> Elements { get; set; }

    }
}
