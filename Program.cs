using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HelloWorldRazor.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<HelloWorldRazorContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("HelloWorldRazorContext")));
}
else
{
    builder.Services.AddDbContext<HelloWorldRazorContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionRazorContext")));
}


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
