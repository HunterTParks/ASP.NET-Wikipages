using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wikipages.Models
{
    [Table("Business")]
    public class Business
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int BusinessModelId { get; set; }
    }
}
