using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Social_Manager.Core.DataBaseConfig;
using Social_Manager.Core.Domain;

namespace Social_Manager.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        {
            string ConnectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<SocialManagerContext>(opt => opt.UseSqlServer(ConnectionString));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<SocialManagerContext>()
                .AddDefaultTokenProviders();

            services.AddAuthentication().AddFacebook(fOptions =>
            {
                fOptions.AppId = "313637266079322";
                fOptions.AppSecret = "d0d3581de60f0fc71aa3e8f0af4b858a";
                fOptions.TokenEndpoint = "token-facebook";
            })
            .AddGoogle(gOptions =>
            {
                gOptions.ClientId = "811582334600-nomcfrcmrrb0vc7k5bc8g78cgmp3fhrt.apps.googleusercontent.com";
                gOptions.ClientSecret = "tNZMHdyB7tASWTRJ4HSBYI5c";
                gOptions.TokenEndpoint = "/token-google";
            })
            .AddJwtBearer();

        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseHttpsRedirection();
           // app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
