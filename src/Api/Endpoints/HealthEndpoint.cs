using FastEndpoints;

namespace NetModulith.Api.Endpoints;

public class HealthEndpoint : EndpointWithoutRequest<HealthResponse>
{
    public override void Configure()
    {
        Get("/health");
        AllowAnonymous();
    }

    public override Task HandleAsync(CancellationToken ct)
    {
        Response = new HealthResponse { Status = "Healthy", Timestamp = DateTime.UtcNow };
        return Task.CompletedTask;
    }
}

public class HealthResponse
{
    public string Status { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }
}
