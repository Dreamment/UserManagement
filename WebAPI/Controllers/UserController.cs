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

        [HttpGet]
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

        [HttpPut("UpdateUserName")]
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
            catch (UserNameAlreadyRegisteredDatabaseException e)
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

        [HttpPut("UpdateUserUserName")]
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

        [HttpPut("UpdateUserEmail")]
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
            catch(AlreadyExistsDatabaseException e)
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

        [HttpPut("UpdateUserPassword")]
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
            catch (SavingDatabaseException e)
            {
                return StatusCode(
                    StatusCodes.Status304NotModified,
                    new ErrorDetails(StatusCodes.Status304NotModified, e.Message));
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

        [HttpPut("UpdateUserPhoneNumber")]
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
            catch (Exception e)
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    new ErrorDetails(StatusCodes.Status500InternalServerError, $"Internal server error: {e.Message}"));
            }
        }

        [HttpPut("UpdateUserAddressWithNewAddress")]
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

        [HttpPut("UpdateUserAddressWithExistingAddress")]
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

        [HttpPut("UpdateUserWebSite")]
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

        [HttpPut("UpdateUserCompanyWithNewCompany")]
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

        [HttpPut("UpdateUserCompanyWithExistingCompany")]
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

        [HttpPut("UpdateUserInformationsWithNewInformations")]
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

        [HttpPut("UpdateUserInformationsWithExistingInformations")]
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

        [HttpDelete]
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
