using AirPollution.Contexts;
using AirPollution.Models;
using AirPollution.ModelsDTO;
using AutoMapper;
using Coravel.Invocable;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AirPollution.Services
{
    public class GetAllStations: IInvocable
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly AirPollutionContext _AirPollutionContext;
        private readonly IMapper _mapper;

        public bool GetPollutionDataError { get; private set; }

        public GetAllStations(IHttpClientFactory clientFactory, IMapper mapper, AirPollutionContext AirPollutionContext)
        {
            _clientFactory = clientFactory;
            _mapper = mapper;
            _AirPollutionContext = AirPollutionContext;
        }

        public async Task Invoke()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                "http://api.gios.gov.pl/pjp-api/rest/station/findAll");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    var answer = await response.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject<List<StationDTO>>(answer);

                    var listOfStations = new List<Station>();

                    foreach (var s in data)
                    {
                        listOfStations.Add(_mapper.Map<Station>(s));
                    }

                    await _AirPollutionContext.AddRangeAsync(listOfStations);
                    await _AirPollutionContext.SaveChangesAsync();
                }
                catch(Exception e)
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
