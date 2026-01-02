namespace Ordering;

public static class OrderingContext
{
    public static IServiceCollection AddOrderingContext(this IServiceCollection services, IConfiguration configuration)
    {
        // Register ordering-related services here
        return services;
    }

    public static IApplicationBuilder UseOrderingContext(this IApplicationBuilder app)
    {
        // Configure ordering-related middleware here
        return app;
    }
}
