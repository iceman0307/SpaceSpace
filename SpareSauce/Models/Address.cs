using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpareSpace.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string StreetName { get; set; }
        public int Number { get; set; }
        public int Floor { get; set; }
        public string Position { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
    }
}
