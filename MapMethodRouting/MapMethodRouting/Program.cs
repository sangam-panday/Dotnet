var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.Map("/Home", () => "Hello World!");
//app.MapGet("/", () => "Hello World! - Get");
//app.MapPut("/", () => "Hello World! - Put");
//app.MapDelete("/", () => "Hello World! - Delete");
//app.MapPost("/", () => "Hello World! - Post");

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is  a Home page... Get");
    });
    endpoints.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is  a Home page... Put");
    });
    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is  a Home page... Delete");
    });
    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is  a Home page... Post");
    });
});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Page not found..");
});

app.Run();