using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirezioneController : ControllerBase
    {
        // GET: api/<DirezioneController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DirezioneController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DirezioneController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DirezioneController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DirezioneController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
