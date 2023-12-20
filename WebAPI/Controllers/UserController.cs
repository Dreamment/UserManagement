using Entities.DataTransferObjects.Get;
using Entities.DataTransferObjects.Update;
using Entities.ErrorModel;
using Entities.Exceptions.BadRequest;
using Entities.Exceptions.Database;
using Entities.Exceptions.NotFound;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System.Security.Claims;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "User")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Get user information associated with the token user.
        /// </summary>
        /// <returns> Information of user.</returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET /User
        /// 
        /// </remarks>
        /// <response code ="200">User information returned successfully.</response>
        /// <response code ="404">User not found.</response>
        /// <response code ="403">User is deactivated.</response>
        /// <response code ="500">Internal server error.</response>
        [HttpGet]
        [ProducesResponseType(typeof(GetUserInformationsDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> GetUserInformation()
        {
            try
            {
                var currentUserName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;
                var user = await _userService.GetUserInformationsAsync(currentUserName, false);
                return Ok(user);
            }
            catch (NotFoundException e)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, e.Message));
            }
            catch (UserDeactiveDatabaseException e)
            {
                return StatusCode(
                    StatusCodes.Status403Forbidden,
                    new ErrorDetails(StatusCodes.Status403Forbidden, e.Message));
            }
            catch (Exception e)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {e.Message}"));
            }
        }

        /// <summary>
        /// Update the name associated with the token user with new name.
        /// </summary>
        /// <param name="updateUserNameDto"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT /User/UpdateUserName
        ///     {
        ///         "name": "New name"
        ///     }
        ///     
        /// </remarks>
        /// <response code ="204">User's name updated successfully.</response>
        /// <response code ="404">User not found.</response>
        /// <response code ="400">New name is same with user.</response>
        /// <response code ="403">User is deactivated.</response>
        /// <response code ="500">Internal server error.</response>
        [HttpPut("UpdateUserName")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateUserName(
            [FromBody] UpdateUserNameDto updateUserNameDto)
        {
            try
            {
                var currentUserName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;
                await _userService.UpdateUserNameAsync(currentUserName, updateUserNameDto, false);
                return NoContent();
            }
            catch (NotFoundException e)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, e.Message));
            }
            catch (BadRequestException e)
            {
                return StatusCode(
                    StatusCodes.Status400BadRequest,
                    new ErrorDetails(StatusCodes.Status400BadRequest, e.Message));
            }
            catch (UserDeactiveDatabaseException e)
            {
                return StatusCode(
                    StatusCodes.Status403Forbidden,
                    new ErrorDetails(StatusCodes.Status403Forbidden, e.Message));
            }
            catch (Exception e)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {e.Message}"));
            }
        }

        /// <summary>
        /// Update the username associated with the token user with new username.
        /// </summary>
        /// <param name="updateUserUserNameDto"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT /User/UpdateUserUserName
        ///     {
        ///         "userName": "New username"
        ///     }
        ///     
        /// </remarks>
        /// <response code ="204">User's username updated successfully.</response>
        /// <response code ="404">User not found.</response>
        /// <response code ="400">New username is same with user.</response>
        /// <response code ="409">New username is already registered by another person.</response>
        /// <response code ="403">User is deactivated.</response>
        /// <response code ="500">Internal server error.</response>
        [HttpPut("UpdateUserUserName")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateUserUserName(
            [FromBody] UpdateUserUserNameDto updateUserUserNameDto)
        {
            try
            {
                var currentUserName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;
                await _userService.UpdateUserUserNameAsync(currentUserName, updateUserUserNameDto, false);
                return NoContent();
            }
            catch (NotFoundException e)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, e.Message));
            }
            catch (BadRequestException e)
            {
                return StatusCode(
                    StatusCodes.Status400BadRequest,
                    new ErrorDetails(StatusCodes.Status400BadRequest, e.Message));
            }
            catch (AlreadyExistsDatabaseException e)
            {
                return StatusCode(
                    StatusCodes.Status409Conflict,
                    new ErrorDetails(StatusCodes.Status409Conflict, e.Message));
            }
            catch (UserDeactiveDatabaseException e)
            {
                return StatusCode(
                    StatusCodes.Status403Forbidden,
                    new ErrorDetails(StatusCodes.Status403Forbidden, e.Message));
            }
            catch (Exception e)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {e.Message}"));
            }
        }

        /// <summary>
        /// Update the email associated with the token user with new email.
        /// </summary>
        /// <param name="updateUserEmailDto"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT /User/UpdateUserEmail
        ///     {
        ///         "email": "New email"
        ///     }
        ///     
        /// </remarks>
        /// <response code ="204">User's email updated successfully.</response>
        /// <response code ="404">User not found.</response>
        /// <response code ="400">New email is same with user.</response>
        /// <response code ="409">User's email is already registered by another person.</response>
        /// <response code ="403">User is deactivated.</response>
        /// <response code ="500">Internal server error.</response>
        [HttpPut("UpdateUserEmail")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateUserEmail(
            [FromBody] UpdateUserEmailDto updateUserEmailDto)
        {
            try
            {
                var currentUserName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;
                await _userService.UpdateUserEmailAsync(currentUserName, updateUserEmailDto, false);
                return NoContent();
            }
            catch (NotFoundException e)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, e.Message));
            }
            catch (BadRequestException e)
            {
                return StatusCode(
                    StatusCodes.Status400BadRequest,
                    new ErrorDetails(StatusCodes.Status400BadRequest, e.Message));
            }
            catch (AlreadyExistsDatabaseException e)
            {
                return StatusCode(
                    StatusCodes.Status409Conflict,
                    new ErrorDetails(StatusCodes.Status409Conflict, e.Message));
            }
            catch (UserDeactiveDatabaseException e)
            {
                return StatusCode(
                    StatusCodes.Status403Forbidden,
                    new ErrorDetails(StatusCodes.Status403Forbidden, e.Message));
            }
            catch (Exception e)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {e.Message}"));
            }
        }

        /// <summary>
        /// Update the password associated with the token user with new password.
        /// </summary>
        /// <param name="updateUserPasswordDto"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT /User/UpdateUserPassword
        ///     {
        ///         "oldPassword": "Old Password",
        ///         "newPassword": "New Password"
        ///     }
        ///     
        /// </remarks>
        /// <response code ="204">User's password updated successfully.</response>
        /// <response code ="404">User not found.</response>
        /// <response code ="400">
        ///     Old password is same with new password. <br />
        ///     Old password is wrong.
        /// </response>
        /// <response code ="403">User is deactivated.</response>
        /// <response code ="500">Internal server error.</response>
        [HttpPut("UpdateUserPassword")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateUserPassword(
            [FromBody] UpdateUserPasswordDto updateUserPasswordDto)
        {
            try
            {
                var currentUserName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;
                await _userService.UpdateUserPasswordAsync(currentUserName, updateUserPasswordDto, false);
                return NoContent();
            }
            catch (NotFoundException e)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, e.Message));
            }
            catch (BadRequestException e)
            {
                return StatusCode(
                    StatusCodes.Status400BadRequest,
                    new ErrorDetails(StatusCodes.Status400BadRequest, e.Message));
            }
            catch (UserDeactiveDatabaseException e)
            {
                return StatusCode(
                    StatusCodes.Status403Forbidden,
                    new ErrorDetails(StatusCodes.Status403Forbidden, e.Message));
            }
            catch (Exception e)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {e.Message}"));
            }
        }

        /// <summary>
        /// Update the phone number associated with the token user with new phone number.
        /// </summary>
        /// <param name="updateUserPhoneNumberDto"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT /User/UpdateUserPhoneNumber
        ///     {
        ///         "phoneNumber": "New phone number"
        ///     }
        ///     
        /// </remarks>
        /// <response code ="204">User's phone number updated successfully.</response>
        /// <response code ="404">User not found.</response>
        /// <response code ="400">New phone number is same with user.</response>
        /// <response code ="403">User is deactivated.</response>
        /// <response code ="409">User's phone number is already registered by another person.</response>
        /// <response code ="500">Internal server error.</response>
        [HttpPut("UpdateUserPhoneNumber")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateUserPhoneNumber(
            [FromBody] UpdateUserPhoneNumberDto updateUserPhoneNumberDto)
        {
            try
            {
                var currentUserName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;
                await _userService.UpdateUserPhoneNumberAsync(currentUserName, updateUserPhoneNumberDto, false);
                return NoContent();
            }
            catch (NotFoundException e)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, e.Message));
            }
            catch (BadRequestException e)
            {
                return StatusCode(
                    StatusCodes.Status400BadRequest,
                    new ErrorDetails(StatusCodes.Status400BadRequest, e.Message));
            }
            catch (UserDeactiveDatabaseException e)
            {
                return StatusCode(
                    StatusCodes.Status403Forbidden,
                    new ErrorDetails(StatusCodes.Status403Forbidden, e.Message));
            }
            catch (AlreadyExistsDatabaseException e)
            {
                return StatusCode(
                    StatusCodes.Status409Conflict,
                    new ErrorDetails(StatusCodes.Status409Conflict, e.Message));
            }
            catch (Exception e)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {e.Message}"));
            }
        }

        /// <summary>
        /// Update the address associated with the token user with a new address.
        /// </summary>
        /// <param name="updateUserAddressDto"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT /User/UpdateUserWtihNewAddress
        ///     {
        ///         "street": "New street",
        ///         "suite": "New suite",
        ///         "city": "New city",
        ///         "zipcode": "New zipcode",
        ///         "geo": {
        ///             "lat": "New lat",
        ///             "lng": "New lng"
        ///         }
        ///     }
        /// 
        /// </remarks>
        /// <response code ="204">User's address updated successfully.</response>
        /// <response code ="404">User not found.</response>
        /// <response code ="400">New address is same with user.</response>
        /// <response code ="403">User is deactivated.</response>
        /// <response code ="500">Internal server error.</response>
        [HttpPut("UpdateUserAddressWithNewAddress")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateUserAddressWithNewAddress(
            [FromBody] UpdateUserAddressDto updateUserAddressDto)
        {
            try
            {
                var currentUserName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;
                await _userService.UpdateUserAddressWithNewAddressAsync(currentUserName, updateUserAddressDto, false);
                return NoContent();
            }
            catch (NotFoundException e)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, e.Message));
            }
            catch (BadRequestException e)
            {
                return StatusCode(
                    StatusCodes.Status400BadRequest,
                    new ErrorDetails(StatusCodes.Status400BadRequest, e.Message));
            }
            catch (UserDeactiveDatabaseException e)
            {
                return StatusCode(
                    StatusCodes.Status403Forbidden,
                    new ErrorDetails(StatusCodes.Status403Forbidden, e.Message));
            }
            catch (Exception e)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {e.Message}"));
            }
        }

        /// <summary>
        /// Update the address with an existing adress associated with the token.
        /// </summary>
        /// <param name="AddressId"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT /User/UpdateUserAddressWithExistingAddress?AddressId=AddressId
        /// </remarks>
        /// <response code ="204">User's address updated successfully.</response>
        /// <response code ="404">User not found.</response>
        /// <response code ="400">New address id is same with user.</response>
        /// <response code ="403">User is deactivated.</response>
        /// <response code ="500">Internal server error.</response>
        [HttpPut("UpdateUserAddressWithExistingAddress")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateUserAddressWithExistingAddress([FromQuery] Guid AddressId)
        {
            try
            {
                var currentUserName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;
                await _userService.UpdateUserAddressWithExistingAddressAsync(currentUserName, AddressId, false);
                return NoContent();
            }
            catch (NotFoundException e)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, e.Message));
            }
            catch (BadRequestException e)
            {
                return StatusCode(
                    StatusCodes.Status400BadRequest,
                    new ErrorDetails(StatusCodes.Status400BadRequest, e.Message));
            }
            catch (UserDeactiveDatabaseException e)
            {
                return StatusCode(
                    StatusCodes.Status403Forbidden,
                    new ErrorDetails(StatusCodes.Status403Forbidden, e.Message));
            }
            catch (Exception e)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {e.Message}"));
            }
        }

        /// <summary>
        /// Update the website associated with the token user with a new website.
        /// </summary>
        /// <param name="updateUserWebSiteDto"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT /User/UpdateUserWebSite
        ///     {
        ///        "website": "New website"
        ///     }
        ///     
        /// </remarks>
        /// <response code ="204">User's website updated successfully.</response>
        /// <response code ="404">User not found.</response>
        /// <response code ="400">
        ///     New website is same with user. <b />
        ///     Did not enter a valid website.
        /// </response>
        /// <response code ="403">User is deactivated.</response>
        /// <response code ="500">Internal server error.</response>
        [HttpPut("UpdateUserWebSite")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateUserWebSite(
            [FromBody] UpdateUserWebSiteDto updateUserWebSiteDto)
        {
            try
            {
                var currentUserName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;
                await _userService.UpdateUserWebSiteAsync(currentUserName, updateUserWebSiteDto, false);
                return NoContent();
            }
            catch (NotFoundException e)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, e.Message));
            }
            catch (BadRequestException e)
            {
                return StatusCode(
                    StatusCodes.Status400BadRequest,
                    new ErrorDetails(StatusCodes.Status400BadRequest, e.Message));
            }
            catch (UserDeactiveDatabaseException e)
            {
                return StatusCode(
                    StatusCodes.Status403Forbidden,
                    new ErrorDetails(StatusCodes.Status403Forbidden, e.Message));
            }
            catch (Exception e)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {e.Message}"));
            }
        }

        /// <summary>
        /// Update the company associated with the token user with a new company.
        /// </summary>
        /// <param name="updateUserCompanyDto"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT /User/UpdateUserCompanyWithNewCompany
        ///     {
        ///         "name": "New name",
        ///         "catchPhrase": "New catch phrase",
        ///         "bs": "New bs"
        ///     }
        /// 
        /// </remarks>
        /// <response code ="204">User's company updated successfully.</response>
        /// <response code ="404">User not found.</response>
        /// <response code ="400">New company is same with user.</response>
        /// <response code ="403">User is deactivated.</response>
        /// <response code ="500">Internal server error.</response>
        [HttpPut("UpdateUserCompanyWithNewCompany")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateUserCompanyWithNewCompany(
            [FromBody] UpdateUserCompanyDto updateUserCompanyDto)
        {
            try
            {
                var currentUserName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;
                await _userService.UpdateUserCompanyWithNewCompanyAsync(currentUserName, updateUserCompanyDto, false);
                return NoContent();
            }
            catch (NotFoundException e)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, e.Message));
            }
            catch (BadRequestException e)
            {
                return StatusCode(
                    StatusCodes.Status400BadRequest,
                    new ErrorDetails(StatusCodes.Status400BadRequest, e.Message));
            }
            catch (UserDeactiveDatabaseException e)
            {
                return StatusCode(
                    StatusCodes.Status403Forbidden,
                    new ErrorDetails(StatusCodes.Status403Forbidden, e.Message));
            }
            catch (Exception e)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {e.Message}"));
            }
        }

        /// <summary>
        /// Update the company associated with the token user with an existing company.
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT /User/UpdateUserCompanyWithExistingCompany?companyId=companyId
        /// 
        /// </remarks>
        /// <response code ="204">User's company updated successfully.</response>
        /// <response code ="404">User not found.</response>
        /// <response code ="400">New company id is same with user.</response>
        /// <response code ="403">User is deactivated.</response>
        /// <response code ="500">Internal server error.</response>
        [HttpPut("UpdateUserCompanyWithExistingCompany")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateUserCompanyWithExistingCompany([FromQuery] Guid companyId)
        {
            try
            {
                var currentUserName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;
                await _userService.UpdateUserCompanyWithExistingCompanyAsync(currentUserName, companyId, false);
                return NoContent();
            }
            catch (NotFoundException e)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, e.Message));
            }
            catch (BadRequestException e)
            {
                return StatusCode(
                    StatusCodes.Status400BadRequest,
                    new ErrorDetails(StatusCodes.Status400BadRequest, e.Message));
            }
            catch (UserDeactiveDatabaseException e)
            {
                return StatusCode(
                    StatusCodes.Status403Forbidden,
                    new ErrorDetails(StatusCodes.Status403Forbidden, e.Message));
            }
            catch (Exception e)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {e.Message}"));
            }
        }

        /// <summary>
        /// Updates the informations associated with the token user with new informations.
        /// </summary>
        /// <param name="updateUserInformationsDto"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT /User/UpdateUserInformationsWithNewInformations
        ///     {
        ///         "name": "New name",
        ///         "username": "New username",
        ///         "email": "New email",
        ///         "phoneNumber": "New phone number",
        ///         "updateUserAddressDto": {
        ///             "street": "New street",
        ///             "suite": "New suite",
        ///             "city": "New city",
        ///             "zipcode": "New zipcode",
        ///             "geo": {
        ///                 "lat": "New lat",
        ///                 "lng": "New lng"
        ///             }
        ///             "updateUserCompanyDto": {
        ///                 "name": "New name",
        ///                 "catchPhrase": "New catch phrase",
        ///                 "bs": "New bs"
        ///             }  
        ///     }
        /// 
        /// </remarks>
        /// <response code ="204">User's informations updated successfully.</response>
        /// <response code ="404">User not found.</response>
        /// <response code ="400">Informations are same with user.</response>
        /// <response code ="403">User is deactivated.</response>
        /// <response code ="500">Internal server error.</response>
        [HttpPut("UpdateUserInformationsWithNewInformations")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateUserInformationsWithNewInformations(
            [FromBody] UpdateUserInformationsDto updateUserInformationsDto)
        {
            try
            {
                var currentUserName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;
                await _userService.UpdateUserInformationsWithNewCompanyOrAddressAsync(currentUserName, updateUserInformationsDto, false);
                return NoContent();
            }
            catch (NotFoundException e)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, e.Message));
            }
            catch (BadRequestException e)
            {
                return StatusCode(
                    StatusCodes.Status400BadRequest,
                    new ErrorDetails(StatusCodes.Status400BadRequest, e.Message));
            }
            catch (UserDeactiveDatabaseException e)
            {
                return StatusCode(
                    StatusCodes.Status403Forbidden,
                    new ErrorDetails(StatusCodes.Status403Forbidden, e.Message));
            }
            catch (Exception e)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {e.Message}"));
            }
        }

        /// <summary>
        /// Updates the informations associated with the token user with existing and new informations.
        /// </summary>
        /// <param name="AddressId"></param>
        /// <param name="CompanyId"></param>
        /// <param name="updateUserInformationsDto"></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT /User/UpdateUserInformationsWithExistingInformations?AddressId=AddressId&#38;CompanyId=CompanyId
        ///     {
        ///         "name": "New name",
        ///         "username": "New username",
        ///         "email": "New email",
        ///         "website": "New website",
        ///         "phoneNumber": "New phone number"
        ///     }
        /// 
        /// </remarks>
        /// <response code ="204">User's informations updated successfully.</response>
        /// <response code ="404">
        ///     User not found. <br />
        ///     Address not found. <br />
        ///     Company not found.
        /// </response>
        /// <response code ="400">
        ///     Can not give new adress and new company. Give address id and/or company id.<br />
        ///     Give at least an adressid or companyid.<br />
        ///     Same address id and/or company id with user.
        /// </response>
        /// <response code ="403">User is deactivated.</response>
        /// <response code ="500">Internal server error.</response>
        [HttpPut("UpdateUserInformationsWithExistingInformations")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> UpdateUserInformationsWithExistingInformations(
            [FromQuery] Guid? AddressId, [FromQuery] Guid? CompanyId,
            [FromBody] UpdateUserInformationsDto updateUserInformationsDto)
        {
            try
            {
                var currentUserName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;
                await _userService.UpdateUserInformationsWithExistingCompanyOrAddressAsync(
                    currentUserName, AddressId, CompanyId, updateUserInformationsDto, false);
                return NoContent();
            }
            catch (NotFoundException e)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, e.Message));
            }
            catch (BadRequestException e)
            {
                return StatusCode(
                    StatusCodes.Status400BadRequest,
                    new ErrorDetails(StatusCodes.Status400BadRequest, e.Message));
            }
            catch (UserDeactiveDatabaseException e)
            {
                return StatusCode(
                    StatusCodes.Status403Forbidden,
                    new ErrorDetails(StatusCodes.Status403Forbidden, e.Message));
            }
            catch (Exception e)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {e.Message}"));
            }
        }

        /// <summary>
        /// Deletes the user associated with the token.
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     DELETE /User
        ///     
        /// </remarks>
        /// <response code ="204">User deleted successfully.</response>
        /// <response code ="404">User not found.</response>
        /// <response code ="403">User is already deactivated.</response>
        /// <response code ="500">Internal server error.</response>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ErrorDetails), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> DeleteUser()
        {
            try
            {
                var currentUserName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;
                await _userService.DeactivateUserAsync(currentUserName, false);
                return NoContent();
            }
            catch (NotFoundException e)
            {
                return StatusCode(
                    StatusCodes.Status404NotFound,
                    new ErrorDetails(StatusCodes.Status404NotFound, e.Message));
            }
            catch (UserDeactiveDatabaseException e)
            {
                return StatusCode(
                    StatusCodes.Status403Forbidden,
                    new ErrorDetails(StatusCodes.Status403Forbidden, e.Message));
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
