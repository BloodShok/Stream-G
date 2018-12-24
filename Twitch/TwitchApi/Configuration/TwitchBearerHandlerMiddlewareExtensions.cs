using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Twitch.API.Middleware;

namespace Twitch.API.Configuration
{
    public static class TwitchBearerHandlerMiddlewareExtensions
    {
        public static IApplicationBuilder UseTwitchAuthentication(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TwitchBearerHandlerMiddleware>();
        }
    }
}
