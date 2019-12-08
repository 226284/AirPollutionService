using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPollution.Models
{
    public class IndexLevel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("indexLevelName")]
        public string IndexLevelName { get; set; }
    }
}
