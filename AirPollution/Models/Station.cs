using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirPollution.Models
{
    public class Station
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }

        public PM25 PM25 { get; set; }
        public PM10 PM10 { get; set; }
        public CO CO { get; set; }
        public NO2 NO2 { get; set; }
        public NOx NOx { get; set; }
        public O3 O3 { get; set; }
        public SO2 SO2 { get; set; }

        public ICollection<Sensor> Sensors { get; set; }
    }
}
