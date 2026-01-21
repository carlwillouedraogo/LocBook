using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace projetLocBook.Entites
{
    public class AuthResponse
    {

        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("is_admin")]
        public bool isAdmin { get; set; }
    }
}
