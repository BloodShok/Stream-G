using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Twitch.API.Data.Token;

namespace StreamG.Services.Commands
{
    public class AuthorizeTwitchUserCommand : IRequest<Token>
    {
        public string code { get; set; }
    }
}
