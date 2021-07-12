using Microsoft.AspNetCore.Mvc;
using Roulette.Security.Helpers;
using Roulette.Security.Interfaces;
using Roulette.Security.Models;
using Roulette.Security.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RouletteCore
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IAccountServices _accountServices;

        public ValuesController(IAccountServices accountServices)
        {
            _accountServices = accountServices;
        }
            // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost("Login")]
        public string Login([FromBody] LoginModel loginModel)
        {
            var authToken = _accountServices.Login(loginModel);
            Authorisation.AuthToken = authToken;
            return authToken;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
