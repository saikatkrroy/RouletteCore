using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Roulette.DataAccess.Models;
using Roulette.Security.Helpers;
using Roulette.Security.Interfaces;
using Roulette.Security.Models;
using Roulette.Security.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Threading.Tasks;



namespace RouletteCore
{
    [Route("api/Account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        IAccountServices _accountServices { get; set; }

        public AccountController()
        {
            _accountServices = new AccountServices();
            //_accountServices = accountServices;
        }
        [HttpPost("Login")]
        public string Login([FromBody] LoginModel loginModel)
        {
            var authToken = _accountServices.Login(loginModel);
            Authorisation.AuthToken = authToken;
            return authToken;
        }
        [HttpPost("Logoff")]
        public string Logoff()
        {

            _accountServices.Logoff(Authorisation.AuthToken);
            Authorisation.AuthToken = null;
            return null;
        }
        [HttpPost]
        [Route("api/Account/CreateNewUser")]
        public Users CreateNewUser(LoginModel loginModel)
        {
            return _accountServices.CreateNewUser(loginModel);
        }

        [HttpGet]
        [Route("api/Account/RetrieveUsers")]
        public IList<String> RetrieveUsers()
        {
            return _accountServices.RetrieveUsers();
        }
        [HttpDelete]
        [Route("api/Account/DeleteUser/{userId}")]
        public void DeleteUser([System.Web.Http.FromUri] string userId)
        {
            _accountServices.DeleteUser(userId);
        }
    }
}
