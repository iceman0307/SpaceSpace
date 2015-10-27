using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpareSpace.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public virtual Address Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        // should be encrypted
        public string Password { get; set; }
        public virtual CardInfo CardInfo { get; set; }
        public virtual UserRole Role { get; set; }
    }
}
