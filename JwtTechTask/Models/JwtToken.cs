using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtTechTask.Models
{
    public class JwtToken
    {
        public string Raw { get; }
        public string Header { get; }
        public string Payload { get; }
        public string Signature { get; }
        public string DecodedPayload { get; }

        public JwtToken(string jwt)
        {
            Raw = jwt ?? throw new ArgumentNullException(nameof(jwt));
            var parts = jwt.Split('.');
            if (parts.Length < 2)
                throw new ArgumentException("Invalid JWT token: must have at least header and payload.");

            Header = parts[0];
            Payload = parts[1];
            Signature = parts.Length > 2 ? parts[2] : null;

            DecodedPayload = DecodeBase64(Payload);
        }

        private string DecodeBase64(string base64)
        {
            string padded = PadBase64(base64);
            byte[] data = Convert.FromBase64String(padded);
            return Encoding.UTF8.GetString(data);
        }

        private string PadBase64(string base64)
        {
            int padding = 4 - (base64.Length % 4);
            if (padding < 4)
                base64 += new string('=', padding);
            return base64.Replace('-', '+').Replace('_', '/');
        }
    }
}
