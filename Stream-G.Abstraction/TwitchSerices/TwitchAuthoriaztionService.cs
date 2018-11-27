using StreamG.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Twitch.API;
using Twitch.API.Data.Token;

namespace StreamG.Services.TwitchSerices
{
    public class TwitchAuthoriaztionService : ITwitchAuthorizationService
    {
        TwitchApi twitchApi;

        public TwitchAuthoriaztionService()
        {
           // twitchApi = new TwitchApi();
        }
        public Token GetApplicationToken()
        {
            throw new NotImplementedException();
        }
    }
}
