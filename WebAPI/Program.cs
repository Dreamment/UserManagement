using Repositories.Contracts;
using Services.Contracts;
using WebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.ConfigureCustomServices();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.ConfigureIdentity();
builder.Services.ConfigureJwt(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

var serviceProvider = app.Services.CreateScope().ServiceProvider;
ServiceExtensions.AddInitialPasswords(serviceProvider.GetRequiredService<IUserService>(), serviceProvider.GetRequiredService<IRepositoryManager>()).Wait();

app.Run();