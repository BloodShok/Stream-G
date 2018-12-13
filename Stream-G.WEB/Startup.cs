using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.AzureADB2C.UI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using Twitch.API.Configuration;
using Twitch.API.Data;
using MediatR;
using Microsoft.AspNetCore.Http;
using StreamG.Services.CommandHandlers.TwitchUserAuthorize;
using StreamG.Infrastructure.TwitchNotification.Hubs;

namespace Social_Manager.WEB
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region Azure
            //services.AddAuthentication(options =>
            //{
            //    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //   .AddJwtBearer(jwtOptions =>
            //   {
            //       jwtOptions.Authority = $"https://login.microsoftonline.com/tfp/{Configuration["AzureAdB2C:Tenant"]}/{Configuration["AzureAdB2C:Policy"]}/v2.0/";
            //       jwtOptions.Audience = Configuration["AzureAdB2C:ClientId"];
            //       jwtOptions.Events = new JwtBearerEvents
            //       {
            //           OnAuthenticationFailed = AuthenticationFailed
            //       };
            //   });
            #endregion
            services.AddCors();
            services.AddSignalR();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.ConfigurateTwitchApi(x =>
            {
                x.ClientId = "zelka51qk5amh7qm05a7vqtriwfv2k";
                x.ClientSecret = "xakg0ffzovmb36vb7brazvvncjyvp2";
                x.Scopes = new List<string> { Scope.UserRead, Scope.ChannelRead, Scope.ViewingActivityRead };
                x.RedirectUrl = "https://localhost:44349/api/TwitchAuthorization/authorize";
            });

            services.AddMediatR(typeof(TwitchUserAuthorizeCommandHandler).Assembly);
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "home",
                    template: "api/{controller=posts}/{action=Get}/{id?}");
            });
            app.UseCors(builder => builder
                                        .WithOrigins("http://localhost:4200")
                                        .AllowAnyMethod()
                                        .AllowAnyHeader()
                                        .AllowCredentials());

            app.UseTwitchAuthentication();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSignalR(route => {
                route.MapHub<AuthorizationNotifyHub>("/authorizationnotify");
            });
         
            
        }
    }
}
