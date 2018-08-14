using Newtonsoft.Json;
using System.Collections.Generic;

namespace FizzBuzz.Models
{
    [JsonObject("application")]    
    public class Application
    {
        [JsonProperty("name")]
        public string Name { get; set; }

         [JsonProperty("modulos")]
         public List<Modulo> Modulos { get; set; }
    }
}