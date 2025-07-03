using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NewMovieApp
{
    public class SerialDeserial
    {
        public static void Serialization(List<Movie> movies)
        {
            string data = JsonConvert.SerializeObject(movies);

            File.WriteAllText("MovieData.json",data);

        }

        public static List<Movie> Deserialization()
        {
            string filename = "MovieData.json";
            List<Movie> tempmovies = new List<Movie>();

            if (File.Exists(filename)) { 
                
                string json = File.ReadAllText(filename);
                tempmovies = JsonConvert.DeserializeObject<List<Movie>>(json);

            }
            return tempmovies;
        }
    }
}
