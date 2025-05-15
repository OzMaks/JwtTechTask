using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JwtTechTask.Models
{
    public class Transaction
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("amount")]
        public double Amount { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("meta")]
        public MetaData Meta { get; set; }

        [JsonPropertyName("status")]
        public object Status { get; set; } // Can be string or int (as seen in 2nd user)
    }
}
