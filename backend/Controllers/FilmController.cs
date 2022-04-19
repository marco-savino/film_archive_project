using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using backend.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private FilmService filmService = new FilmService();

        // GET: api/<FilmController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return filmService.getAllFilms();
        }

        // GET api/<FilmController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return filmService.getFilmById(id);
        }

        // POST api/<FilmController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            filmService.postFilm(value);
        }

        // PUT api/<FilmController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FilmController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
