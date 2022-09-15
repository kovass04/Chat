using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using test_Chat.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<test_ChatContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("test_ChatContext") ?? throw new InvalidOperationException("Connection string 'test_ChatContext' not found.")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
