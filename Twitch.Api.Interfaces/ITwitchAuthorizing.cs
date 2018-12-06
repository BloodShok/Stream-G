using System;
using System.Collections.Generic;
using System.Text;
using Twitch.API.Data.Token;
using Twitch.API.Data.User;

namespace Twitch.Api.Abstraction
{
    public interface ITwitchAuthorizing
    {
        Token GetAccessToken(string code);
    }
}
