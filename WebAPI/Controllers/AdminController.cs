using Entities.DataTransferObjects.Admin;
using Entities.ErrorModel;
using Entities.Exceptions.NotFound;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns>Return all users</returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET /Admin
        /// 
        /// </remarks>
        /// <response code="200">Returns all users</response>
        /// <response code="404">Users not found</response>
        /// <response code="500">Internal server error</response>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<User>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var users = await _adminService.GetAllUsers(false);
                return Ok(users);
            }
            catch (EntityNotFoundException e)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, e.Message));
            }
            catch (Exception e)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {e.Message}"));
            }
        }

        /// <summary>
        /// Get user by user name
        /// </summary>
        /// <param name="userName">User name</param>
        /// <returns>Return user information</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE /Admin/GetUser?userName={userName}
        ///
        /// </remarks>
        /// <response code="200">Returns user information</response>
        /// <response code="404">User not found</response>
        /// <response code="500">Internal server error</response>
        [HttpGet("GetUser")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> GetUserById([FromQuery]string userName)
        {
            try
            {
                var user = await _adminService.GetUserById(userName, false);
                return Ok(user);
            }
            catch (EntityNotFoundException e)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, e.Message));
            }
            catch (Exception e)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {e.Message}"));
            }
        }

        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="userName">User name</param>
        /// <param name="updateUserDto">User information</param>
        /// <returns>Return user information</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /Admin/{userName}
        ///     {
        ///        "userName": "string",
        ///        "email": "string",
        ///        "phoneNumber": "string",
        ///        "password": "string",
        ///        "website": "string",
        ///        "address": {
        ///          "street": "string",
        ///          "suite": "string",
        ///          "city": "string",
        ///          "zipcode": "string",
        ///          "geo": {
        ///            "lat": "string",
        ///            "lng": "string"
        ///          }
        ///        },
        ///        "company": {
        ///          "name": "string",
        ///          "catchPhrase": "string",
        ///          "bs": "string"
        ///        }
        ///     }
        ///
        /// </remarks>
        /// <response code="200">Returns user information</response>
        /// <response code="404">User not found</response>
        /// <response code="500">Internal server error</response>
        [HttpPut("{userName}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateUser(string userName, AdminUpdateUserInformationsDto updateUserDto)
        {
            try
            {
                await _adminService.UpdateUser(userName, updateUserDto, false);
                return Ok();
            }
            catch (EntityNotFoundException e)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, e.Message));
            }
            catch (Exception e)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {e.Message}"));
            }
        }

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="userName">User name</param>
        /// <returns>Return user information</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE /Admin/{userName}
        ///
        /// </remarks>
        /// <response code="200">Returns user information</response>
        /// <response code="404">User not found</response>
        /// <response code="500">Internal server error</response>
        [HttpDelete("{userName}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> DeleteUser(string userName)
        {
            try
            {
                await _adminService.DeleteUser(userName, false);
                return Ok();
            }
            catch (EntityNotFoundException e)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, e.Message));
            }
            catch (Exception e)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {e.Message}"));
            }
        }
    }
}
