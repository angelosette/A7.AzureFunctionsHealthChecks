# AzureFunctionsHealthChecks
ASette.AzureFunctionsHealthChecks is a NuGet package that provides health check functionality for Azure Functions, similar to the UseHealthChecks middleware in ASP.NET Core. Easily integrate health checks into your Azure Functions applications to monitor and report the health status of your services.

## Using the package
### Installing the package
`dotnet add package ASette.AzureFunctionsHealthChecks`

### Setting up Health checks
The goal is to utilize the same health check framework provided for ASP.NET Core

```csharp
builder.Services.AddHealthChecks()
    .AddUrlGroup(new Uri("https://example.com"), name: "example-url", failureStatus: HealthStatus.Unhealthy);
```

### Enable Azure Function Health
This line integrates health checks with Azure Functions and creates a health check endpoint at `/health`. When this endpoint is accessed, it will provide a report on the health status of the application and its dependencies.

```csharp
builder.Services.AddAzureFunctionsHealthChecks();
```
By adding this line, the application will have a health check endpoint at `/health`. This endpoint can be used to monitor the health of the application and its dependencies, providing valuable information for maintaining the application's reliability and availability.
