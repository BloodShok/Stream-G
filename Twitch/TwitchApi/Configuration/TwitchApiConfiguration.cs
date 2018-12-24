using System;
using System.Collections.Generic;
using System.Text;
using Twitch.API.Data;
using Microsoft.Extensions.DependencyInjection;
using Twitch.Api.Abstraction;

namespace Twitch.API.Configuration
{
    public static class TwitchApiConfiguration
    {
        public static void AddTwitchConfiguration(this IServiceCollection services, Action<Options> func)
        {
            TwitchApiBase.SetConfiguration(func);

            services.AddScoped<ITwitchUserApi, TwitchUserApi>();
            services.AddScoped<ITwitchAuthorizing, TwitchApiAuthorizing>();
        }
    }
}
