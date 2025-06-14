using Microsoft.AspNetCore.Mvc;
using WebApiProject.Models;
using WebApiProject.Services;

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserService _userService;

        public AuthController(UserService userService)
        {
            _userService = userService;
        }

        // Register endpoint
        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterModel model)
        {
            var user = _userService.RegisterUser(model.Username, model.Password);
            return Ok(new { Message = "User registered successfully", UserId = user.Id });
        }

        // Login endpoint
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            var user = _userService.AuthenticateUser(model.Username, model.Password);
            if (user == null) return Unauthorized();
            
            // In a real-world app, generate a JWT token here
            var token = "mock-jwt-token"; // Replace with real JWT token logic
            return Ok(new { Token = token });
        }

        // Logout endpoint (mock example)
        [HttpPost("logout")]
        public IActionResult Logout()
        {
            return Ok(new { Message = "Logged out successfully" });
        }
    }
}
