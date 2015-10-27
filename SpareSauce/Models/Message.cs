using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpareSpace.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public virtual User FromUser { get; set; }
        public virtual ICollection<User> ToUsers { get; set; }
        public DateTime Timestamp { get; set; }
        public string MessageString { get; set; }
    }
}
