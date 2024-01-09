using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.Reflection;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureAppConfiguration((hostContext, configApp) =>
{
    configApp.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
});

builder.ConfigureServices((hostContext, services) =>
{
    services.AddMassTransit(busConfigurator =>
    {
        var entryAssembly = Assembly.GetEntryAssembly();
        busConfigurator.AddConsumers(entryAssembly);
        busConfigurator.UsingRabbitMq((context, busFactoryConfigurator) =>
        {
            var connectionString = hostContext.Configuration.GetConnectionString("rabbitMQConnection");
            busFactoryConfigurator.Host(connectionString, "/", hostConfigurator => { });

            busFactoryConfigurator.ConfigureEndpoints(context);
        });
    });
});

var app = builder.Build();

app.Run();