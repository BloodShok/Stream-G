using System;
using System.Collections.Generic;
using System.Text;
using Twitch.API.Data.Token;

namespace StreamG.Services.Interfaces
{
    public interface ITwitchAuthorizationService
    {
        Token GetApplicationToken();
    }
}
