﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpareSpace.Models
{
    public class UserRole
    {
        [Key]
        public int UserRoleId { get; set; }
        public string Name { get; set; }
    }
}
