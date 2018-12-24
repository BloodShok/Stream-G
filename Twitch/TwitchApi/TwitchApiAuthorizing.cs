using RestSharp;
using System;
using Twitch.API.Data;
using Newtonsoft.Json;
using Twitch.API.Data.Token;
using Twitch.Api.Abstraction;
using Social_Manager.Infrastructure;

namespace Twitch.API
{
    public class TwitchApiAuthorizing : TwitchApiBase, ITwitchAuthorizing
    {

        public void Authorize(string code)
        {
           var restClient = new RestClient("https://id.twitch.tv/oauth2/token" +
                                        $"?client_id={Options.ClientId}" +
                                        $"&client_secret={Options.ClientSecret}" +
                                        $"&code={code}" +
                                        $"&grant_type=authorization_code" +
                                        $"&redirect_uri={RedirectUrls.RedirectUrl}");



            Token = Execute<Token>(Method.POST, restClient);
        }

        public Token GetToken()
        {
            return Token;
        }
    }
}
