using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

public class LoggingMiddleware
{
    private readonly RequestDelegate _next;

    public LoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        // Log incoming request
        Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");

        // Pass control to the next middleware
        await _next(context);

        // Log outgoing response
        Console.WriteLine($"Response: {context.Response.StatusCode}");
    }
}
