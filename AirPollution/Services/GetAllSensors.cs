using AirPollution.Contexts;
using AirPollution.Models;
using AirPollution.ModelsDTO;
using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AirPollution.Services
{
    public class GetAllSensors
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly AirPollutionContext _AirPollutionContext;
        private readonly IMapper _mapper;

        public GetAllSensors(IHttpClientFactory clientFactory, IMapper mapper, AirPollutionContext AirPollutionContext)
        {
            _clientFactory = clientFactory;
            _mapper = mapper;
            _AirPollutionContext = AirPollutionContext;
        }

        public async Task GetSensorsFromStation(int stationId)
        {
            var url = String.Format("http://api.gios.gov.pl/pjp-api/rest/station/sensors/" + stationId);
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    var answer = await response.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject<List<SensorDTO>>(answer);

                    var listOfSensors = new List<Sensor>();

                    foreach (var s in data)
                    {
                        listOfSensors.Add(_mapper.Map<Sensor>(s));
                    }

                    await _AirPollutionContext.AddRangeAsync(listOfSensors);
                    await _AirPollutionContext.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine($"StatusCode: {response.StatusCode}");
            }
        }
    }
}
