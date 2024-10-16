using Ecommerce_Application.Configurations;
using Ecommerce_Application.Data;
using Ecommerce_Application.Models;
using Ecommerce_Application.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Serilog;
using Stripe;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

try
{
    builder.Host.UseSerilog();

    // Configure the database context with SQL Server
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

    // Configure identity options to disable email confirmation
    builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
    {
        options.SignIn.RequireConfirmedAccount = false;
    })
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultUI();

    // Configure Stripe settings
    builder.Services.Configure<StripeSettings>(builder.Configuration.GetSection("Stripe"));

    // Add MVC and Razor Pages
    builder.Services.AddControllersWithViews();
    builder.Services.AddRazorPages();

    // Configure session
    builder.Services.AddSession(options =>
    {
        options.IdleTimeout = TimeSpan.FromMinutes(30);
        options.Cookie.HttpOnly = true;
        options.Cookie.IsEssential = true;
    });

    // Register services
    builder.Services.AddTransient<IEmailSender, EmailSender>();
    builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
    builder.Services.AddScoped<CartService>();
    builder.Services.AddScoped<OrderService>();
    builder.Services.AddScoped<PaymentService>(serviceProvider =>
    {
        var stripeSettings = serviceProvider.GetRequiredService<IOptions<StripeSettings>>().Value;
        var logger = serviceProvider.GetRequiredService<ILogger<PaymentService>>();
        return new PaymentService(stripeSettings.SecretKey, logger);
    });
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application start-up failed");
    throw;
}
finally
{
    Log.CloseAndFlush();
}

var app = builder.Build();

// Stripe API Key configuration
StripeConfiguration.ApiKey = builder.Configuration["Stripe:SecretKey"];

// Configure middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
    Log.Information("Production environment: using exception handler and HSTS.");
}
else
{
    app.UseDeveloperExceptionPage();
    Log.Information("Development environment: using developer exception page.");
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();
app.MapControllers();
app.Run();