using Microsoft.AspNetCore.SignalR;
using StreamG.Infrastructure.TwitchNotification.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StreamG.Infrastructure.TwitchNotification.Hubs
{
    public class AuthorizationNotifyHub: Hub<ITwitchAuthenticationClient>
    {
    }
}
