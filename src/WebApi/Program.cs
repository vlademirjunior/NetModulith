var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFastEndpoints();
builder.Services.SwaggerDocument(o => o.DocumentSettings = s =>
    {
        s.Title = "NetModulith API";
        s.Version = "v1";
    });

var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.MapGet("/", () => Results.Redirect("/swagger")).ExcludeFromDescription();

app.UseFastEndpoints();
app.UseSwaggerGen();

app.Run();
