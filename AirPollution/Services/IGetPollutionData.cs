using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirPollution.Services
{
    public interface IGetPollutionData
    {
        Task Invoke();
    }
}
