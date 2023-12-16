using Entities.DataTransferObjects.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationManager;

        public AuthController(IAuthenticationService authenticationManager)
        {
            _authenticationManager = authenticationManager;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistrationDto)
        {
            var result = new IdentityResult();
            try
            {
                result = await _authenticationManager.RegisterUser(userForRegistrationDto);
            }
            catch (Exception ex)
            {
                return BadRequest(new AuthResponseDto { Errors = new[] { ex.Message } });
            }
            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description);
                return BadRequest(new AuthResponseDto { Errors = errors });
            }
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginUser([FromBody] UserForAuthenticationDto userForAuthenticationDto)
        {
            var result = new Microsoft.AspNetCore.Identity.SignInResult();
            try 
            {
                result = await _authenticationManager.LoginUser(userForAuthenticationDto);
            }
            catch (Exception ex)
            {
                return BadRequest(new AuthResponseDto { Errors = new[] { ex.Message } });
            }
            if (result.IsNotAllowed)
                return BadRequest(new AuthResponseDto { Errors = new[] { "You must give Email or User Name" } });
            if (!result.Succeeded)
                return BadRequest(new AuthResponseDto { Errors = new[] { "Wrong User Name or Email or Password" } });
            var token = await _authenticationManager.CreateTokenAsync();
            return Ok(new AuthResponseDto { Success = true, Token = token });
        }
    }
}
