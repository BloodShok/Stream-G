using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using StreamG.DTO;
using Twitch.API.Data.Token;

namespace StreamG.Services.Commands
{
    public class AuthorizeTwitchUserCommand : IRequest<TwitchAuthorizeInfoDto>
    {
        public string Code { get; set; }
    }
}
