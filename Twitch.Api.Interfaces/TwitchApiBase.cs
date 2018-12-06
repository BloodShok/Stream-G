using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using Twitch.API.Data;

namespace Twitch.Api.Abstraction
{
    public abstract class TwitchApiBase
    {
        public static Options Options;
        public RestClient RestClient;

        public static void SetConfiguration(Action<Options> func)
        {
            Options = new Options();
            func.Invoke(Options);
        }

        public static void SetBearerToken(string token)
        {
            Options.UserBearer = token;
        }
    }
}
