using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Stockapp.Models
{
    public class User
    {
        [JsonPropertyName("user")]
        public string userName { get; set; }

        [JsonPropertyName("email")]
        public string emailAddress { get; set; }
    }
}