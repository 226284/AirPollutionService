using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPollution.ModelsDTO
{
    public class SensorDTO
    {
            public int id { get; set; }
            public int stationId { get; set; }
            public Param param { get; set; }
    }
}
