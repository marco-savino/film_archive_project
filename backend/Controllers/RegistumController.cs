using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistumController : ControllerBase
    {
        // GET: api/<RegistumController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RegistumController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RegistumController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RegistumController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RegistumController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
