using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using StreamG.Infrastructure.TwitchNotification.Hubs;
using StreamG.Infrastructure.TwitchNotification.Interfaces;
using StreamG.Services.Commands;
using Twitch.API;

namespace StreamG.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwitchAuthorizationController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IHubContext<AuthorizationNotifyHub, ITwitchAuthenticationClient> _hubContext;
        public TwitchAuthorizationController(IMediator mediator, IHubContext<AuthorizationNotifyHub, ITwitchAuthenticationClient> hubContext)
        {
            _mediator = mediator;
            _hubContext = hubContext;
        }

        [HttpGet("authorize")]
        public async Task Authorize(string code, string state)
        {
            var result = await _mediator.Send(new AuthorizeTwitchUserCommand { Code = code  });

            await _hubContext.Clients.All.AuthenticationMessage(result);
        }
    }
}