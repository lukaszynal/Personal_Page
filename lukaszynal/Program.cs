using lukaszynal.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<JsonFileService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{

    endpoints.MapControllerRoute("projectName", "Projects/{projectName}",
                    new { Controller = "Home", action = "Projects" });
    endpoints.MapControllerRoute("projects", "Projects",
                new { Controller = "Home", action = "Projects" });
    endpoints.MapControllerRoute("courses", "Courses",
            new { Controller = "Home", action = "Courses" });
    endpoints.MapControllerRoute("resume", "Resume",
        new { Controller = "Home", action = "Resume" });
});


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

app.Run();
