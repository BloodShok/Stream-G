using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Twitch.API.Data.Token
{
    public class Token
    {
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; private set; }

        [JsonProperty(PropertyName = "expires_in")]
        public string ExpiresIn { get; private set; }

        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; private set; }

        [JsonProperty(PropertyName = "scope")]
        public List<string> Scope { get; private set; }

        public override string ToString()
        {
            return $"AccessToken - { AccessToken } \nExpiresIn - { ExpiresIn } \nTokenType - { TokenType }";
        }
    }
}
