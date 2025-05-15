using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using JwtTechTask.Models;
using JwtTechTask.Utility;

namespace JwtTechTask
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(basePath, "Data", "token.txt");

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found: " + filePath);
                return;
            }

            string jwt = File.ReadAllText(filePath);

            //  Step 1: Decode the JWT and extract the payload
            var jwtToken = new JwtToken(jwt);
            string jsonPayload = jwtToken.DecodedPayload;

            // Step 2: Deserialize the payload into C# objects
            var wrapper = JsonSerializer.Deserialize<PayloadWrapper>(jsonPayload);

            // Step 3: Print user ID, transaction count, total confirmed amount
            foreach (var user in wrapper.Data)
            {
                TransactionProcessor.PrintUserTransactionSummary(user);
            }
        }

    }
}