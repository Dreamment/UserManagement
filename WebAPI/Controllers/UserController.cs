using Entities.DataTransferObjects.Update;
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
            catch (Exception e)
            {
                if (e.Message == "User not found")
                {
                    return NotFound();
                }
                return StatusCode(500, $"Internal server error: {e.Message}");
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
            catch (Exception e)
            {
                if (e.Message == "User not found")
                {
                    return NotFound();
                }
                else if (e.Message == "User name already exists" || e.Message == "You give same user name with yours")
                {
                    return BadRequest(e.Message);
                }

                return StatusCode(500, $"Internal server error: {e.Message}");
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
            catch (Exception e)
            {
                if (e.Message == "User not found")
                {
                    return NotFound();
                }
                else if (e.Message == "User name already exists" || e.Message == "You give same user name with yours")
                {
                    return BadRequest(e.Message);
                }
                return StatusCode(500, $"Internal server error: {e.Message}");
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
            catch (Exception e)
            {
                if (e.Message == "User not found")
                {
                    return NotFound();
                }
                else if (e.Message == "Email already exists" || e.Message == "You give same email with yours")
                {
                    return BadRequest(e.Message);
                }
                return StatusCode(500, $"Internal server error: {e.Message}");
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
            catch (Exception e)
            {
                if (e.Message == "User not found")
                {
                    return NotFound();
                }
                else if (e.Message == "Password is wrong" || e.Message == "Old password and new password can not be same" ||
                    e.Message == "You give same password with yours")
                {
                    return BadRequest(e.Message);
                }
                return StatusCode(500, $"Internal server error: {e.Message}");
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
            catch (Exception e)
            {
                if (e.Message == "User not found")
                {
                    return NotFound();
                }
                else if (e.Message == "You give same phone number with yours")
                {
                    return BadRequest(e.Message);
                }
                return StatusCode(500, $"Internal server error: {e.Message}");
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
            catch (Exception e)
            {
                if (e.Message == "User not found" || e.Message == "Address not found")
                {
                    return NotFound();
                }
                else if (e.Message == "You give same address with yours")
                {
                    return BadRequest(e.Message);
                }
                return StatusCode(500, $"Internal server error: {e.Message}");
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
            catch (Exception e)
            {
                if (e.Message == "User not found" || e.Message == "Address not found")
                {
                    return NotFound(e.Message);
                }
                else if (e.Message == "You give same address with yours" || e.Message == "You can not give new address or company" || 
                    e.Message == "You must give addressId or companyId")
                {
                    return BadRequest(e.Message);
                }
                return StatusCode(500, $"Internal server error: {e.Message}");
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
            catch (Exception e)
            {
                if (e.Message == "User not found")
                {
                    return NotFound();
                }
                else if (e.Message == "You give same web site with yours")
                {
                    return BadRequest(e.Message);
                }
                return StatusCode(500, $"Internal server error: {e.Message}");
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
            catch (Exception e)
            {
                if (e.Message == "User not found" || e.Message == "Company not found")
                {
                    return NotFound();
                }
                else if (e.Message == "You give same company with yours")
                {
                    return BadRequest(e.Message);
                }
                return StatusCode(500, $"Internal server error: {e.Message}");
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
            catch (Exception e)
            {
                if (e.Message == "User not found" || e.Message == "Company not found")
                {
                    return NotFound();
                }
                else if (e.Message == "You give same company with yours")
                {
                    return BadRequest(e.Message);
                }
                return StatusCode(500, $"Internal server error: {e.Message}");
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
            catch (Exception e)
            {
                if (e.Message == "User not found")
                {
                    return NotFound();
                }
                else if (e.Message == "You give same informations with yours")
                {
                    return BadRequest(e.Message);
                }
                return StatusCode(500, $"Internal server error: {e.Message}");
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
            catch (Exception e)
            {
                if (e.Message == "User not found" || e.Message == "Address not found" || e.Message == "Company not found")
                {
                    return NotFound(e.Message);
                }
                else if (e.Message == "You give same address or company with yours")
                {
                    return BadRequest(e.Message);
                }
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }
    }
}
