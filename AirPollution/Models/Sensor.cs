using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirPollution.Models
{
    public class Sensor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int StationId { get; set; }
        public Station Station { get; set; }
    }
}
