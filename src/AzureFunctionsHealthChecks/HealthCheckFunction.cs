using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Http;

namespace AzureFunctionsHealthChecks;

public class HealthCheckFunction
{
    private readonly HealthCheckService _healthCheck;

    public HealthCheckFunction(HealthCheckService healthCheck)
    {
        _healthCheck = healthCheck;
    }

    [Function("Health")]
    public async Task<IActionResult> Health(
     [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "health")] HttpRequest req)
    {
        var status = await _healthCheck.CheckHealthAsync();
        return new OkObjectResult(Enum.GetName(typeof(HealthStatus), status.Status));
    }
}
