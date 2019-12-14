using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPollution.ModelsDTO
{
    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public Commune commune { get; set; }
    }
}
