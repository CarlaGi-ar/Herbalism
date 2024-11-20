var builder = WebApplication.CreateBuilder(args);

// Build the app
var app = builder.Build();

// Configure middleware and request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.UseDefaultFiles(); // Enables serving default files like index.html
app.UseStaticFiles();  // Enables serving static files (CSS, JS, images, etc.)

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/", async context =>
    {
        await context.Response.WriteAsync("Hello World!");
    });
});

app.Run();