using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using backend.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private archivio_filmContext ctx = new archivio_filmContext();
        // GET: api/<FilmController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            List<string> fieldList = new List<string>();
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "server=localhost;database=archivio_film;uid=localUser;pwd=localUser";
            try{
                connection.Open();
                Console.WriteLine("Connessione eseguita");

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM film";
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                { 
                    fieldList.Add(reader["id"].ToString());
                    fieldList.Add(reader["titolo"].ToString());
                    fieldList.Add(reader["genere"].ToString());
                    fieldList.Add(reader["durata"].ToString());
                }

                return fieldList.ToArray();

            }catch(Exception e){
                Console.WriteLine("Eccezione!\n "+ e.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }



            return new string[] { "value1", "value2" };
        }

        // GET api/<FilmController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FilmController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "server=localhost;database=archivio_film;uid=localUser;pwd=localUser";
            try{
                connection.Open();
                Console.WriteLine("Connessione eseguita");

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO film(titolo, genere, durata) VALUES(\"Jurassic Park\", \"Avventura\", \"120\")";
                MySqlDataReader reader = cmd.ExecuteReader();
            }catch(Exception e){
                Console.WriteLine("Eccezione!\n "+ e.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
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
