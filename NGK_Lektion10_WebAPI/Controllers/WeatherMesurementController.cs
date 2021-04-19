using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NGK_Lektion10_WebAPI;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NGK_Lektion10_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherMesurementController : ControllerBase
    {
        // GET: api/<WeatherMesurementController>
        [HttpGet]
        public ActionResult<List<WeatherMesurement>> Get()
        {
            return Program.DataBank;
        }

        // GET api/<WeatherMesurementController>/5
        [HttpGet("WithDate")]
        public ActionResult<List<WeatherMesurement>> Get(DateTime date)
        {

            return Program.DataBank.Where(d => d.Date.Date == date.Date).ToList();

        }

        // POST api/<WeatherMesurementController>
        // Hvis der bruges postman, så husk at sætte teksten til at bruge JSON. (under body)
        [HttpPost]
        public void Post([FromBody] WeatherMesurement value)
        {
           Program.DataBank.Add(value);
        }

        // PUT api/<WeatherMesurementController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WeatherMesurementController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
