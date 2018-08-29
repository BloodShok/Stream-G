using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Social_Manager.Core.DataBaseConfig;
using Social_Manager.Core.Domain;

namespace Social_Manager.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        
        UserManager<ApplicationUser> _userManager;

        public ValuesController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        // GET api/values
        [HttpGet]
        public   IActionResult Get()
        {
           
            return Ok("Ok");
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
