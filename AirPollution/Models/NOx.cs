using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirPollution.Models
{
    public class NOx
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public double Value { get; set; }

        public int StationId { get; set; }
        public Station Station { get; set; }
    }
}
