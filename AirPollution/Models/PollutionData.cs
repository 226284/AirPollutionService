using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AirPollution.Models
{   
    /// <summary>
    /// Pollution Data Model
    /// </summary>
    public class PollutionData
    {
        [Key]
        public int id { get; set; }
        public string indexLevel { get; set; }
        public string no2IndexLevel { get; set; }
        public string coIndexLevel { get; set; }
        public string pm25IndexLevel { get; set; }

    }
}
