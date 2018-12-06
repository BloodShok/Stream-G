using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StreamG.Infrastructure.TwitchNotification.Interfaces
{
    public interface ITwitchAuthenticationClient
    {
        Task AuthenticationMessage(string security_Token, string redirectUrl);
    }
}
