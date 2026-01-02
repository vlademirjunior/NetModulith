namespace Basket;

public static class BasketContext
{
    public static IServiceCollection AddBasketContext(this IServiceCollection services, IConfiguration configuration)
    {
        // Register basket-related services here
        return services;
    }

    public static IApplicationBuilder UseBasketContext(this IApplicationBuilder app)
    {
        // Configure basket-related middleware here
        return app;
    }
}
