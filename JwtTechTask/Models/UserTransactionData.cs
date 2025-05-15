using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JwtTechTask.Models
{
    public class UserTransactionData
    {
        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        [JsonPropertyName("transactions")]
        public List<Transaction> Transactions { get; set; }
    }
}
