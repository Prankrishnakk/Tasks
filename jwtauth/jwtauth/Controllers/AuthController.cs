using jwtauth.Models;
using jwtauth.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace jwtauth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    { 
        private static List<User> users = new List<User>();
        private readonly TokenService _tokenService;

        public AuthController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if (users.Any(x => x.Username == user.Username))
                return BadRequest("Username already taken.");

            users.Add(user);
            return Ok("User registered successfully.");
        }

        [HttpPost("login")]
        public IActionResult Login(User loginRequest)
        {
            var user = users.FirstOrDefault(x => x.Username == loginRequest.Username && x.Password == loginRequest.Password);

            if (user == null)
                return Unauthorized("Invalid username or password.");

            var token = _tokenService.CreateToken(user);

            return Ok(new { token });
        }
    }
}

