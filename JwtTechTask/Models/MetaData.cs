using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JwtTechTask.Models
{
    public class MetaData
    {
        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("confirmed")]
        public bool Confirmed { get; set; }
    }
}
