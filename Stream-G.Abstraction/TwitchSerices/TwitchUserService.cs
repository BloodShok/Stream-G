using System;
using System.Collections.Generic;
using System.Text;

using StreamG.Services.Interfaces;
using Twitch.Api.Abstraction;
using Twitch.API;
using Twitch.API.Data.User;

namespace StreamG.Services.TwitchSerices
{
    public class TwitchUserService : ITwitchUserService
    {
        private ITwitchUserApi _twitchUserApi;

        public TwitchUserService(ITwitchUserApi twitchUserApi)
        {
            _twitchUserApi = twitchUserApi;
        }

        public TwitchUser GetUser()
        {
            return _twitchUserApi.GetUserData();
        }
    }
}
