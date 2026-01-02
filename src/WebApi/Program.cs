var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCatalogContext(builder.Configuration)
    .AddBasketContext(builder.Configuration)
    .AddOrderingContext(builder.Configuration);

builder.Services.AddFastEndpoints();
builder.Services.SwaggerDocument(o => o.DocumentSettings = s =>
    {
        s.Title = "NetModulith API";
        s.Version = "v1";
    });

var app = builder.Build();

// Middlwares pipeline
app.UseCatalogContext()
    .UseBasketContext()
    .UseOrderingContext();

if (app.Environment.IsDevelopment())
    app.MapGet("/", () => Results.Redirect("/swagger")).ExcludeFromDescription();

app.UseFastEndpoints();
app.UseSwaggerGen();

app.Run();
