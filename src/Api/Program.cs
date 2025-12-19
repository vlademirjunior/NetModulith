using FastEndpoints;

var builder = WebApplication.CreateBuilder(args);

// Add FastEndpoints services
builder.Services.AddFastEndpoints();

var app = builder.Build();

// Configure FastEndpoints
app.UseFastEndpoints();

app.Run();
