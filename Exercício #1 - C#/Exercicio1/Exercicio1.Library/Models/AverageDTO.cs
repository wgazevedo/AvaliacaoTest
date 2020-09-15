using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1.Library.Models
{
    public class AverageDTO
    {
        [JsonProperty("cidade")]
        public string City { get; set; }
        [JsonProperty("idade")]
        public float Age { get; set; }
    }
}
