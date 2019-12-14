using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirPollution.Models
{
    public class O3
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public Station Station { get; set; }
        public int Value { get; set; }
    }
}
