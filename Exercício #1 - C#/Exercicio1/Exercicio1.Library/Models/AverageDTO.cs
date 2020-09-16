using Newtonsoft.Json;

namespace Exercicio1.Library.Models
{
    public class AverageDTO
    {
        [JsonProperty("cidade")]
        public string City { get; set; }
        [JsonProperty("idade")]
        public decimal Age { get; set; }
    }
}
