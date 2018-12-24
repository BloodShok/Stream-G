using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using Twitch.Api.Abstraction;
using System.Web;

namespace Twitch.API.Middleware
{
    internal class TwitchBearerHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public TwitchBearerHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ITwitchAuthorizing _twitchAuthorizing)
        {
            context.Request.Headers.TryGetValue("TwitchCode", out var twitchCode);

            _twitchAuthorizing.Authorize(twitchCode.ToString());

            await _next(context);
        }
    }
}
