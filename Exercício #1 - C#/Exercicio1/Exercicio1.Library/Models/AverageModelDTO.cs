using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1.Library.Models
{
    public class AverageModelDTO
    {
        [JsonProperty("medias")]
        public List<AverageDTO> Averages { get; set; }
    }
}
