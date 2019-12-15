using AirPollution.Models;
using AirPollution.ModelsDTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPollution.AutoMapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<StationDTO, Station>()
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.id))
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.stationName))
                .ForMember(x => x.Latitude, opt => opt.MapFrom(x => x.gegrLat))
                .ForMember(x => x.Longitude, opt => opt.MapFrom(x => x.gegrLon));

            CreateMap<SensorDTO, Sensor>()
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.id))
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.param.paramCode))
                .ForMember(x => x.Station.Id, opt => opt.MapFrom(x => x.stationId));
        }
    }
}
