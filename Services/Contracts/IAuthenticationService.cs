﻿using Entities.DataTransferObjects.Auth;
using Microsoft.AspNetCore.Identity;

namespace Services.Contracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistrationDto);
        Task<SignInResult> LoginUser(UserForAuthenticationDto userForAuthenticationDto);
        Task<string> CreateTokenAsync();
    }
}
