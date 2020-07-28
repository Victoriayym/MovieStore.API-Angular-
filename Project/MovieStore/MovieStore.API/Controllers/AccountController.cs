using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Core.Models.Request;
using MovieStore.Core.ServiceInterfaces;

namespace MovieStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("register")]
        //http://localhost/api/account/register --http post

        public async Task<IActionResult> RegisterUser([FromBody] UserRegisterRequestModel model)
        {   //model binding
            //when posting json data, make sure your json keys are the same as C# model properties
            //{
            //    "firstname":"Andy",
            //        "lastname":"Wang",
            //        "email": "yy2210@nyu.edu",
            //        "password": "Andy30#"
            //}
            //in MVC, name of the input in HTML should be same as C# model property
            var user = await _userService.RegisterUser(model);
            return Ok(user);

        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestModel loginRequest)
        {
            var user = await _userService.ValidateUser(loginRequest.Email, loginRequest.Password);
            return Ok(user);
        }

    }
}
