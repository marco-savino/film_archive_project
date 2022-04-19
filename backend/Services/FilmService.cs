using MySql.Data.MySqlClient;
using backend.Models;
using System.Text.Json;

namespace backend.Services
{
    class FilmService
    {
        private archivio_filmContext ctx;

        public FilmService()
        {
            ctx = new archivio_filmContext();
        }

        public string[] getAllFilms()
        {
            Film[] filmList = ctx.Films.ToArray();
            string[] filmListString = new string[filmList.Length];
            
            for(int i=0; i<filmListString.Length; i++)
            {
                filmListString[i] = JsonSerializer.Serialize(filmList[i]);
            }

            return filmListString; 
        }
    }
}
