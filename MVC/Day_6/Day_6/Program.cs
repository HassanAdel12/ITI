var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Map("/Dashboard", (newapp) => {
    newapp.Run(async (context) =>
    {
        await context.Response.WriteAsync("Hello Dashboard");
    });
});

app.Use(async (context, next) =>
{
    var path = context.Request.Path.Value;
    if (!path.Contains("Student"))
        await next();
    else
        await context.Response.WriteAsync("Hello Student");
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hello in my Application");
});

app.Run();

