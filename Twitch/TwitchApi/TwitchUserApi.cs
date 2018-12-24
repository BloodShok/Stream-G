using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using Twitch.Api.Abstraction;
using Twitch.API.Data.BaseEntity;
using Twitch.API.Data.Token;
using Twitch.API.Data.User;

namespace Twitch.API
{
    internal class TwitchUserApi : TwitchApiBase, ITwitchUserApi
    {
        public TwitchUser GetCurrentUser()
        {
            var restClient = new RestClient($"https://api.twitch.tv/helix/users");
            restClient.AddDefaultHeader("Authorization", $"Bearer {Token.AccessToken}");
            var userContainer = Execute<TwitchDataEntityContainer<TwitchUser>>(Method.GET, restClient);
            new List<string>();
            return userContainer.Entities.First();
        }
    }
}
