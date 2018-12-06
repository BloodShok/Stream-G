using MediatR;
using StreamG.Services.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Twitch.Api.Abstraction;
using Twitch.API.Data.Token;

namespace StreamG.Services.CommandHandlers.TwitchUserAuthorize
{
    public class TwitchUserAuthorizeCommandHandler : IRequestHandler<AuthorizeTwitchUserCommand, Token>
    {
        private readonly ITwitchAuthorizing _twitchAuthorizing;
        private readonly ITwitchUserApi _twitchUserApi;
        public TwitchUserAuthorizeCommandHandler(ITwitchAuthorizing twitchAuthorizing, ITwitchUserApi twitchUserApi)
        {
            _twitchAuthorizing = twitchAuthorizing;
            _twitchUserApi = twitchUserApi;
        }
        public Task<Token> Handle(AuthorizeTwitchUserCommand request, CancellationToken cancellationToken)
        {
            var token = _twitchAuthorizing.GetAccessToken(request.code);
            var user = _twitchUserApi.GetCurrentUser();
            return Task.FromResult(token);
        }
    }
}
