using Repositories.Contracts;
using WebAPI.Extensions;
using WebAPI.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});
builder.Services.AddSignalR();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigureSwagger();
builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.ConfigureCustomServices();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.ConfigureIdentity();
builder.Services.ConfigureJwt(builder.Configuration);
builder.Services.ConfigureRedis(builder.Configuration);

var app = builder.Build();

// if you want to use swagger in darkmode uncomment the following line it will open in almost 5-10 seconds delayed
// after open or close dark mode rebuild the solution
//app.UseStaticFiles();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(s =>
    {
        s.SwaggerEndpoint("/swagger/v1/swagger.json", "UserManagementWebAPI v1");
        //s.InjectStylesheet("/swagger-ui/SwaggerDark.css");
    });
}
// you can use this url to open swagger if it will open late : https://localhost:8080/swagger/index.html

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapHub<NotificationHub>("/notificationHub");

var scope = app.Services.CreateScope();
ServiceExtensions.EnsureSeedData(scope);
var serviceProvider = scope.ServiceProvider;
ServiceExtensions.AddInitialPasswords(serviceProvider.GetRequiredService<IRepositoryManager>()).Wait();

app.Run();