using Newtonsoft.Json;
namespace FizzBuzz.Models
{
    [JsonObject("application")]    
    public class Application
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}