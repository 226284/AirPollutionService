using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPollution.Models
{
    public class PollutionDataDTO
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("stCalcDate")]
        public DateTimeOffset StCalcDate { get; set; }

        [JsonProperty("stIndexLevel")]
        public IndexLevel StIndexLevel { get; set; }

        [JsonProperty("stSourceDataDate")]
        public DateTimeOffset StSourceDataDate { get; set; }

        [JsonProperty("so2CalcDate")]
        public DateTimeOffset So2CalcDate { get; set; }

        [JsonProperty("so2IndexLevel")]
        public object So2IndexLevel { get; set; }

        [JsonProperty("so2SourceDataDate")]
        public object So2SourceDataDate { get; set; }

        [JsonProperty("no2CalcDate")]
        public long No2CalcDate { get; set; }

        [JsonProperty("no2IndexLevel")]
        public IndexLevel No2IndexLevel { get; set; }

        [JsonProperty("no2SourceDataDate")]
        public DateTimeOffset No2SourceDataDate { get; set; }

        [JsonProperty("coCalcDate")]
        public DateTimeOffset CoCalcDate { get; set; }

        [JsonProperty("coIndexLevel")]
        public IndexLevel CoIndexLevel { get; set; }

        [JsonProperty("coSourceDataDate")]
        public DateTimeOffset CoSourceDataDate { get; set; }

        [JsonProperty("pm10CalcDate")]
        public DateTimeOffset Pm10CalcDate { get; set; }

        [JsonProperty("pm10IndexLevel")]
        public object Pm10IndexLevel { get; set; }

        [JsonProperty("pm10SourceDataDate")]
        public object Pm10SourceDataDate { get; set; }

        [JsonProperty("pm25CalcDate")]
        public DateTimeOffset Pm25CalcDate { get; set; }

        [JsonProperty("pm25IndexLevel")]
        public IndexLevel Pm25IndexLevel { get; set; }

        [JsonProperty("pm25SourceDataDate")]
        public DateTimeOffset Pm25SourceDataDate { get; set; }

        [JsonProperty("o3CalcDate")]
        public object O3CalcDate { get; set; }

        [JsonProperty("o3IndexLevel")]
        public object O3IndexLevel { get; set; }

        [JsonProperty("o3SourceDataDate")]
        public object O3SourceDataDate { get; set; }

        [JsonProperty("c6h6CalcDate")]
        public object C6H6CalcDate { get; set; }

        [JsonProperty("c6h6IndexLevel")]
        public object C6H6IndexLevel { get; set; }

        [JsonProperty("c6h6SourceDataDate")]
        public object C6H6SourceDataDate { get; set; }

        [JsonProperty("stIndexStatus")]
        public bool StIndexStatus { get; set; }

        [JsonProperty("stIndexCrParam")]
        public string StIndexCrParam { get; set; }
    }

}
