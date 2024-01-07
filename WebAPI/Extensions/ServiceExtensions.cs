using Entities.Exceptions.Database;
using Entities.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Repositories;
using Repositories.Contracts;
using Repositories.EFCore;
using Services;
using Services.Contracts;
using StackExchange.Redis;
using System.Reflection;
using System.Text;

namespace WebAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IAdminService, AdminManager>();
            services.AddScoped<IAuthenticationService, AuthenticationManager>();
            services.AddSingleton<ICacheService, RedisCacheManager>();
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
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequiredLength = 8;
                opts.User.RequireUniqueEmail = true;

            }).AddEntityFrameworkStores<RepositoryContext>()
            .AddDefaultTokenProviders();
        }

        public static void ConfigureJwt(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtSettings = configuration.GetSection("JwtSettings");
            var secretKey = jwtSettings["secretKey"];

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
                opts.Events = new JwtBearerEvents
                {
                    OnMessageReceived = context =>
                    {
                        var accessToken = context.Request.Query["access_token"];
                        var path = context.HttpContext.Request.Path;
                        if (!string.IsNullOrEmpty(accessToken) && path.StartsWithSegments("/notificationHub"))
                        {
                            context.Token = accessToken;
                        }
                        return Task.CompletedTask;
                    }
                };
            });
        }

        public static async Task AddInitialPasswords(IRepositoryManager _repositoryManager)
        {
            var userNames = new List<string>
            {
                "Bret", "Antonette", "Samantha", "Karianne", "Kamren","Leopoldo_Corkery",
                "Elwyn.Skiles", "Maxime_Nienow", "Delphine", "Moriah.Stanton", "admin" };
            for (int i = 1; i <= 11; i++)
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
                throw new SeedDatabaseException($"Something went wrong inside AddInitialPasswords action: {ex.Message}");
            }
        }
        public static void EnsureSeedData(this IServiceScope serviceScope)
        {
            Thread.Sleep(2000);
            var dbContext = serviceScope.ServiceProvider.GetRequiredService<RepositoryContext>();
            dbContext.Database.Migrate();
        }

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo { Title = "UserManagementWebAPI", Version = "v1" });

                s.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme."
                    + "\n\n\nEnter 'Bearer' [space] and then your token in the text input below."
                    + "\n\n\nExample: 'Bearer YourToken'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                s.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header,
                        },
                        new List<string>()
                    }
                });

                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                s.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });
        }
        public static void ConfigureRedis(this IServiceCollection services, IConfiguration configuration)
        {
            var multiplexer = ConnectionMultiplexer.Connect(configuration.GetConnectionString("redisConnection"));
            services.AddSingleton<IConnectionMultiplexer>(multiplexer);
        }
    }
}
