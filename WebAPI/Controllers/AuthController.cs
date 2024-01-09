using Entities.DataTransferObjects.Auth;
using Entities.ErrorModel;
using Entities.Exceptions.BadRequest;
using Entities.Exceptions.Database;
using Entities.Exceptions.NotFound;
using Entities.Messages;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Services.Contracts;
using WebAPI.Hubs;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationManager;
        private readonly IHubContext<NotificationHub> _hubContext;
        private readonly IPublishEndpoint _publishEndpoint;

        public AuthController(IAuthenticationService authenticationManager,
            IHubContext<NotificationHub> hubContext,
            IPublishEndpoint publishEndpoint)
        {
            _authenticationManager = authenticationManager;
            _hubContext = hubContext;
            _publishEndpoint = publishEndpoint;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistrationDto)
        {
            try
            {
                var result = await _authenticationManager.RegisterUser(userForRegistrationDto);
                if (!result.Succeeded)
                {
                    var error = result.Errors.Select(e => e.Description).FirstOrDefault();
                    return StatusCode(
                        StatusCodes.Status400BadRequest,
                        new ErrorDetails(StatusCodes.Status400BadRequest, error));
                }
                await _hubContext.Clients.Group("Admin").SendAsync("UserAdded", $"User added with {userForRegistrationDto.UserName}");
                await _publishEndpoint.Publish(new SendMailMessage()
                {
                    UserName = userForRegistrationDto.UserName,
                    Email = userForRegistrationDto.Email,
                    Subject = "Welcome to the system"
                });
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (BadRequestException ex)
            {
                return StatusCode(
                    StatusCodes.Status400BadRequest,
                    new ErrorDetails(StatusCodes.Status400BadRequest, ex.Message));
            }
            catch (RoleNotExistsDatabaseException ex)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, ex.Message));
            }
            catch (UserNameAlreadyRegisteredDatabaseException ex)
            {
                return StatusCode(
                    StatusCodes.Status400BadRequest,
                    new ErrorDetails(StatusCodes.Status400BadRequest, ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}"));
            }
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginUser([FromBody] UserForAuthenticationDto userForAuthenticationDto)
        {
            try
            {
                var result = await _authenticationManager.LoginUser(userForAuthenticationDto);
                if (!result.Succeeded)
                {
                    if (userForAuthenticationDto.Email != null)
                        return StatusCode(
                            StatusCodes.Status401Unauthorized,
                            new ErrorDetails(StatusCodes.Status401Unauthorized, "Wrong Email or Password"));
                    return StatusCode(
                        StatusCodes.Status401Unauthorized,
                        new ErrorDetails(StatusCodes.Status401Unauthorized, "Wrong Username or Password"));
                }
                var token = await _authenticationManager.CreateTokenAsync();
                return StatusCode(StatusCodes.Status200OK, new { Token = token });
            }
            catch (BadRequestException ex)
            {
                return StatusCode(
                    StatusCodes.Status400BadRequest,
                    new ErrorDetails(StatusCodes.Status400BadRequest, ex.Message));
            }
            catch (NotFoundException ex)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, ex.Message));
            }
            catch (UserDeactiveDatabaseException ex)
            {
                return StatusCode(
                    StatusCodes.Status400BadRequest,
                    new ErrorDetails(StatusCodes.Status400BadRequest, ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}"));
            }
        }
    }
}
