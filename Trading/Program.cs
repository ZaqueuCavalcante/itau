using Itau.Trading.Settings;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddSingleton<DatabaseSettings>();

var app = builder.Build();

app.MapOpenApi();
app.UseHttpsRedirection();
app.Run();
