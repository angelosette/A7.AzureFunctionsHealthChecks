using AzureFunctionsHealthChecks;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Hosting;

var builder = FunctionsApplication.CreateBuilder(args);

builder.ConfigureFunctionsWebApplication();

builder.Services.AddHealthChecks()
    .AddUrlGroup(new Uri("https://example.com"), name: "example-url", failureStatus: HealthStatus.Unhealthy);
builder.Services.AddAzureFunctionsHealthChecks();

builder.Build().Run();
