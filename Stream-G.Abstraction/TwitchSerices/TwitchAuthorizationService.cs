using StreamG.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Twitch.Api.Abstraction;
using Twitch.API;
using Twitch.API.Data.Token;

namespace StreamG.Services.TwitchSerices
{
    public class TwitchAuthorizationService : ITwitchAuthorizationService
    {
        ITwitchAuthorizing _twitchAuthorizing;

        public TwitchAuthorizationService(ITwitchAuthorizing twitchAuthorizing)
        {
            _twitchAuthorizing = twitchAuthorizing;
        }
        public Token GetApplicationToken()
        {
            var token = _twitchAuthorizing.GetAuthorizeToken();
            return token;
        }

        public void SetAuhorizeCode(string code)
        {
            
        }
    }
}
