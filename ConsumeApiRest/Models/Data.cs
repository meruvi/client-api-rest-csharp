using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeApiRest.Models
{
    class Data
    {
        [JsonProperty("access_token")]
        public string accessToken { get; set; }
        [JsonProperty("token_type")]
        public string tokenType { get; set; }
        [JsonProperty("expires_at")]
        public String expiresAt { get; set; }

    }
}
