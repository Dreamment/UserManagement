using Entities.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Repositories;
using Repositories.Contracts;
using Repositories.EFCore;
using Services;
using Services.Contracts;
using System.Text;

namespace WebAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IUserService, UserManager>();
        }
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
            => services.AddDbContext<RepositoryContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("sqlConnection"),
                b => b.MigrationsAssembly("WebAPI")));
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole<int>>(opts =>
            {
                opts.Password.RequireDigit = true;
                opts.Password.RequireLowercase = true;
                opts.Password.RequireUppercase = true;
                opts.Password.RequireNonAlphanumeric = true;
                opts.Password.RequiredLength = 8;
                opts.User.RequireUniqueEmail = true;

            }).AddEntityFrameworkStores<RepositoryContext>()
            .AddDefaultTokenProviders();
        }

        public static void ConfigureJwt(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtSettings = configuration.GetSection("JwtSettings");
            var secretKey = Environment.GetEnvironmentVariable("secretKey");
            services.AddAuthentication(opts =>
            {
                opts.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opts.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(opts =>
            {
                opts.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtSettings["validIssuer"],
                    ValidAudience = jwtSettings["validAudience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
                };
            });
        }

        public static async Task AddInitialPasswords(IRepositoryManager _repositoryManager)
        {
            var userNames = new List<string>
            {
                "Bret", "Antonette", "Samantha", "Karianne", "Kamren",
                "Leopoldo_Corkery", "Elwyn.Skiles", "Maxime_Nienow", "Delphine", "Moriah.Stanton" };
            for (int i = 1; i <= 10; i++)
            {
                var passwordHasher = new PasswordHasher<User>();
                var user = await _repositoryManager.User.GetUserByIdAsync(i, false);
                if (user == null)
                    continue;
                if (user.UserName != userNames[i - 1])
                    continue;
                if (user.PasswordHash != null)
                    continue;
                user.PasswordHash = passwordHasher.HashPassword(user, $"{user.UserName}");
                await _repositoryManager.User.UpdateUserAsync(user);
            }
            try
            {
                await _repositoryManager.SaveAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Something went wrong inside AddInitialPasswords action: {ex.Message}");
            }
        }
        public static void EnsureSeedData(this IServiceScope serviceScope)
        {
            var dbContext = serviceScope.ServiceProvider.GetRequiredService<RepositoryContext>();
            dbContext.Database.Migrate();
        }
    }
}
