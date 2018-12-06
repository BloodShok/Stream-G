using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace StreamG.WEB.Middleware
{
    public class TwitchBearerHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public TwitchBearerHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            StringValues twitchBearer;
            var bearer = context.Request.Headers.TryGetValue("TwitchBearer", out twitchBearer);
        }
    }
}
