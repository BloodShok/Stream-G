using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Twitch.API.Data;
using Twitch.API.Data.Token;

namespace Twitch.Api.Abstraction
{
    public abstract class TwitchApiBase
    {
        protected static Options Options;
        public static Token Token { get; protected set; }

        public static void SetConfiguration(Action<Options> func)
        {
            Options = new Options();
            func.Invoke(Options);
        }

        public T Execute<T>(Method restMethod, RestClient restClient) where T : new()
        {
            var request = new RestRequest(restMethod);

            var response = restClient.Execute(request);

            return JsonConvert.DeserializeObject<T>(response.Content);
        }
    }
}
