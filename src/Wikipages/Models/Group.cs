﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wikipages.Models
{
    [Table("BusinessModel")]
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public string GroupName { get; set; }
    }
}
