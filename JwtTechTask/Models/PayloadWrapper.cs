using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JwtTechTask.Models
{
    public class PayloadWrapper
    {
        [JsonPropertyName("data")]
        public List<UserTransactionData> Data { get; set; }
    }
}
