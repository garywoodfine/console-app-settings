using Newtonsoft.Json;

namespace FizzBuzz.Models
{
    public class Modulo
    {
         [JsonProperty("title")]
        public string Title { get; set; }

         [JsonProperty("number")]
        public int Number { get; set; }

    }
}