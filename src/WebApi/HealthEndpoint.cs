namespace WebApi;

/// <summary>
/// Response model for health check.
/// </summary>
public class HealthResponse
{
    /// <summary>
    /// Gets or sets the status of the health check.
    /// </summary>
    public string Status { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the timestamp of the health check.
    /// </summary>
    public DateTime Timestamp { get; set; }
}

/// <summary>
/// Summary for the HealthEndpoint (Swagger Documentation).
/// </summary>
public class MySummary : Summary<HealthEndpoint>
{
    public MySummary()
    {
        Summary = "Health check endpoint";
        Description = "Verifies that the service is running and healthy.";
        Response<HealthResponse>(200, "ok response with body",
            example: new() { Status = "Healthy", Timestamp = DateTime.UtcNow });
    }
}

/// <summary>
/// Health check endpoint to verify the service is running.
/// </summary>
public class HealthEndpoint : EndpointWithoutRequest<HealthResponse>

{
    /// <summary>
    /// Configures the health endpoint.
    /// </summary>
    public override void Configure()
    {
        Get("/health");
        AllowAnonymous();
    }

    /// <summary>
    /// Handles the health check request.
    /// </summary>
    public override Task HandleAsync(CancellationToken ct)
    {
        Response = new() { Status = "Healthy", Timestamp = DateTime.UtcNow };
        return Task.CompletedTask;
    }
}
