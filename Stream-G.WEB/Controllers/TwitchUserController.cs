using System;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
namespace StreamG.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwitchUserController : ControllerBase
    {
        public TwitchUserController()
        {
          
        }

        [HttpPost("message")]
        public IActionResult Post()
        {
            return Redirect("https://xxx.xxxx.com");
        }
    }
}