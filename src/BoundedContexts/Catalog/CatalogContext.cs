namespace Catalog;

public static class CatalogContext
{
    public static IServiceCollection AddCatalogContext(this IServiceCollection services, IConfiguration configuration)
    {
        // Register catalog-related services here
        return services;
    }

    public static IApplicationBuilder UseCatalogContext(this IApplicationBuilder app)
    {
        // Configure catalog-related middleware here
        return app;
    }
}
