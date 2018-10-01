using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Social_Manager.WEB.Controllers
{
    [Route("Auth")]
    public class AuthController : Controller
    {
        IAuthorizationService _service;
        public AuthController(IAuthorizationService authorizationService)
        {
            _service = authorizationService;
        }
       
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        [Route("AuthData")]
        public IActionResult AuthData()
        {
            return Ok("Ok res");
        }
    }
}