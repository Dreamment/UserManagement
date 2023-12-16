using Entities.DataTransferObjects.Update;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

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
        public async Task<IActionResult> GetUserInformation([FromQuery] int userId)
        {
            try
            {
                var user = await _userService.GetUserInformationsAsync(userId, false);
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
        public async Task<IActionResult> UpdateUserName([FromRoute] int userId,
            [FromBody] UpdateUserNameDto updateUserNameDto)
        {
            try
            {
                await _userService.UpdateUserNameAsync(userId, updateUserNameDto, false);
                return NoContent();
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

        [HttpPut("UpdateUserUserName")]
        public async Task<IActionResult> UpdateUserUserName([FromRoute] int userId,
            [FromBody] UpdateUserUserNameDto updateUserUserNameDto)
        {
            try
            {
                await _userService.UpdateUserUserNameAsync(userId, updateUserUserNameDto, false);
                return NoContent();
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

        [HttpPut("UpdateUserEmail")]
        public async Task<IActionResult> UpdateUserEmail([FromRoute] int userId,
            [FromBody] UpdateUserEmailDto updateUserEmailDto)
        {
            try
            {
                await _userService.UpdateUserEmailAsync(userId, updateUserEmailDto, false);
                return NoContent();
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

        [HttpPut("UpdateUserPassword")]
        public async Task<IActionResult> UpdateUserPassword([FromRoute] int userId,
            [FromBody] UpdateUserPasswordDto updateUserPasswordDto)
        {
            try
            {
                await _userService.UpdateUserPasswordAsync(userId, updateUserPasswordDto, false);
                return NoContent();
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

        [HttpPut("UpdateUserPhoneNumber")]
        public async Task<IActionResult> UpdateUserPhoneNumber([FromRoute] int userId,
            [FromBody] UpdateUserPhoneNumberDto updateUserPhoneNumberDto)
        {
            try
            {
                await _userService.UpdateUserPhoneNumberAsync(userId, updateUserPhoneNumberDto, false);
                return NoContent();
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

        [HttpPut("UpdateUserAddressWithNewAddress")]
        public async Task<IActionResult> UpdateUserAddressWithNewAddress([FromRoute] int userId,
            [FromBody] UpdateUserAddressDto updateUserAddressDto)
        {
            try
            {
                await _userService.UpdateUserAddressWithNewAddressAsync(userId, updateUserAddressDto, false);
                return NoContent();
            }
            catch (Exception e)
            {
                if (e.Message == "User not found" || e.Message == "Address not found")
                {
                    return NotFound();
                }
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpPut("UpdateUserAddressWithExistingAddress")]
        public async Task<IActionResult> UpdateUserAddressWithExistingAddress([FromRoute] int userId, [FromRoute] Guid AddressId)
        {
            try
            {
                await _userService.UpdateUserAddressWithExistingAddressAsync(userId, AddressId, false);
                return NoContent();
            }
            catch (Exception e)
            {
                if (e.Message == "User not found" || e.Message == "Address not found")
                {
                    return NotFound();
                }
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpPut("UpdateUserWebSite")]
        public async Task<IActionResult> UpdateUserWebSite([FromRoute] int userId,
            [FromBody] UpdateUserWebSiteDto updateUserWebSiteDto)
        {
            try
            {
                await _userService.UpdateUserWebSiteAsync(userId, updateUserWebSiteDto, false);
                return NoContent();
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

        [HttpPut("UpdateUserCompanyWithNewCompany")]
        public async Task<IActionResult> UpdateUserCompanyWithNewCompany([FromRoute] int userId,
            [FromBody] UpdateUserCompanyDto updateUserCompanyDto)
        {
            try
            {
                await _userService.UpdateUserCompanyWithNewCompanyAsync(userId, updateUserCompanyDto, false);
                return NoContent();
            }
            catch (Exception e)
            {
                if (e.Message == "User not found" || e.Message == "Company not found")
                {
                    return NotFound();
                }
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpPut("UpdateUserCompanyWithExistingCompany")]
        public async Task<IActionResult> UpdateUserCompanyWithExistingCompany([FromRoute] int userId, [FromRoute] Guid companyId)
        {
            try
            {
                await _userService.UpdateUserCompanyWithExistingCompanyAsync(userId, companyId, false);
                return NoContent();
            }
            catch (Exception e)
            {
                if (e.Message == "User not found" || e.Message == "Company not found")
                {
                    return NotFound();
                }
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }

        [HttpPut("UpdateUserInformationsWithNewInformations")]
        public async Task<IActionResult> UpdateUserInformationsWithNewInformations([FromRoute] int userId,
            [FromBody] UpdateUserInformationsDto updateUserInformationsDto)
        {
            try
            {
                await _userService.UpdateUserInformationsWtihNewCompanyOrAddressAsync(userId, updateUserInformationsDto, false);
                return NoContent();
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

        [HttpPut("UpdateUserInformationsWithExistingInformations")]
        public async Task<IActionResult> UpdateUserInformationsWithExistingInformations(
            [FromRoute] int userId, [FromRoute] Guid AddressId, [FromRoute] Guid CompanyId,
            [FromBody] UpdateUserInformationsDto updateUserInformationsDto)
        {
            try
            {
                await _userService.UpdateUserInformationsWithExistingCompanyOrAddressAsync(
                    userId, AddressId, CompanyId, updateUserInformationsDto, false);
                return NoContent();
            }
            catch (Exception e)
            {
                if (e.Message == "User not found" || e.Message == "Address not found" || e.Message == "Company not found")
                {
                    return NotFound();
                }
                return StatusCode(500, $"Internal server error: {e.Message}");
            }
        }
    }
}
