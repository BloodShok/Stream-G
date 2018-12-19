using MediatR;
using StreamG.Services.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using StreamG.DTO;
using Twitch.Api.Abstraction;
using Twitch.API.Data.Token;

namespace StreamG.Services.CommandHandlers.TwitchUserAuthorize
{
    public class TwitchUserAuthorizeCommandHandler : IRequestHandler<AuthorizeTwitchUserCommand, TwitchAuthorizeInfoDto>
    {
        private readonly ITwitchAuthorizing _twitchAuthorizing;
        private readonly ITwitchUserApi _twitchUserApi;
        public TwitchUserAuthorizeCommandHandler(ITwitchAuthorizing twitchAuthorizing, ITwitchUserApi twitchUserApi)
        {
            _twitchAuthorizing = twitchAuthorizing;
            _twitchUserApi = twitchUserApi;
        }
        public Task<TwitchAuthorizeInfoDto> Handle(AuthorizeTwitchUserCommand request, CancellationToken cancellationToken)
        {
            _twitchAuthorizing.Authorize(request.Code);
            var user = _twitchUserApi.GetCurrentUser();
 
            var authorizeInfoDto = new TwitchAuthorizeInfoDto()
            {
                Id = user.Id,
                DisplayName = user.DisplayName,
                AccessCode = request.Code,
                ProfileImageUrl = user.ProfileImageUrl
            };

            return Task.FromResult(authorizeInfoDto);
        }
    }
}
