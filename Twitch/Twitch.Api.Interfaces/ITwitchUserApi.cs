using System;
using Twitch.API.Data.User;

namespace Twitch.Api.Abstraction
{
    public interface ITwitchUserApi
    {
        TwitchUser GetCurrentUser();
    }
}
