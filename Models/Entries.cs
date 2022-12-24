using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDiary.Models
{
    public class Entries
    {
        [Key]
        public int Did { get; set; }
        public string Date { get; set; }
        public string Entry { get; set; }
    }
}
