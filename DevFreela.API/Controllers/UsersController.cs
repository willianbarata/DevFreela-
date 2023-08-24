using DevFreela.API.Models;
using DevFreela.Application.Commands.CreateUser;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        //api/users/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        //api/users
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserCommand createUserModel)
        {
            if(!ModelState.IsValid)
            {
                var message = ModelState
                    .SelectMany(ms => ms.Value.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();
                return BadRequest(message);
            }
            return NoContent();
        }


        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] LoginModel loginModel) 
        {
            return NoContent();
        }


    }
}
