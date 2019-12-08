using AirPollution.Contexts;
using AirPollution.Models;
using Coravel.Invocable;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AirPollution.Services
{
    public class GetPollutionData : IInvocable
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly AirPollutionContext _AirPollutionContext;
        public bool GetPollutionDataError { get; private set; }

        public GetPollutionData(IHttpClientFactory clientFactory, AirPollutionContext AirPollutionContext)
        {
            _clientFactory = clientFactory;
            _AirPollutionContext = AirPollutionContext;
        }

        public async Task Invoke()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                "http://api.gios.gov.pl/pjp-api/rest/aqindex/getIndex/129");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var answer = await response.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<PollutionDataDTO>(answer);

                var converted = new PollutionData()
                {
                    indexLevel = data.StIndexLevel.IndexLevelName,
                    no2IndexLevel = data.No2IndexLevel.IndexLevelName,
                    coIndexLevel = data.CoIndexLevel.IndexLevelName,
                    pm25IndexLevel = data.Pm25IndexLevel.IndexLevelName,
                };

                await _AirPollutionContext.Pollutants.AddAsync(converted);
                await _AirPollutionContext.SaveChangesAsync();
            }
            else
            {
                Console.WriteLine($"StatusCode: {response.StatusCode}");
            }
        }
    }
}
