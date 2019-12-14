using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPollution.ModelsDTO
{
    public class StationDTO
    {
        public int id { get; set; }
        public string stationName { get; set; }
        public string gegrLat { get; set; }
        public string gegrLon { get; set; }
        public City city { get; set; }
        public string addressStreet { get; set; }
    }
}
