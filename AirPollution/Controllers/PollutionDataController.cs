using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirPollution.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AirPollution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PollutionDataController : ControllerBase
    {
        // GET: api/PollutionData
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PollutionData/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PollutionData
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/PollutionData/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
