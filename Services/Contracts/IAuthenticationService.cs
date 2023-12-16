using Entities.DataTransferObjects.Auth;
using Microsoft.AspNetCore.Identity;

namespace Services.Contracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistrationDto);
        Task<SignInResult> LoginUserWithUserName(string userName, string password);
        Task<SignInResult> LoginUserWithEmail(string email, string password);
        string CreateToken();
    }
}
