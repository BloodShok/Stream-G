using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Social_Manager.Web.Controllers
{
    [Route("auth")]
    public class AuthController : Controller
    {
        private readonly IAuthenticationSchemeProvider _authenticationSchemeProvider;
        public AuthController(IAuthenticationSchemeProvider authenticationSchemeProvider)
        {
            _authenticationSchemeProvider = authenticationSchemeProvider;
        }
        [Route("data")]
        public async Task<IActionResult> Data()
        {
            var data = (await _authenticationSchemeProvider.GetAllSchemesAsync()).Select(n => n.DisplayName);

            return Ok(data);
        }

        [Route("signin")]
        public IActionResult SignIn()
        {
           
            var sd = Challenge(new AuthenticationProperties { RedirectUri = "/api/values" }, "Google");
            return sd;
        }
    }
}