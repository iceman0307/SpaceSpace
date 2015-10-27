using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpareSpace.Models
{
    public class CardInfo
    {
        [Key]
        public int CardInfoId { get; set; }
        [MaxLength(19, ErrorMessage="FU"), MinLength(19, ErrorMessage="FU")]
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public int CSV { get; set; }
        [Range(0, 99, ErrorMessage = "FU")]
        public int ExpirationYear { get; set; }
        [Range(1,12, ErrorMessage = "FU")]
        public int ExpirationMonth { get; set; }
    }
}
