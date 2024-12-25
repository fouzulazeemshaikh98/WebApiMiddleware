var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

var app = builder.Build();

// Add custom logging middleware
app.UseMiddleware<LoggingMiddleware>();

// Add other middleware (e.g., routing, authentication)
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

// Map controllers
app.MapControllers();

app.Run();
