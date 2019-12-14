using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPollution.ModelsDTO
{
    public class MeasureDataDTO
    {
        public string key { get; set; }
        public List<Value> values { get; set; }
    }
}
