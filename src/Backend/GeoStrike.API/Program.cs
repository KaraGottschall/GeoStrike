#region

using System.Globalization;
using GeoStrike.API.Filters;
using GeoStrike.Application;
using GeoStrike.Infrastructure;
using GeoStrike.Infrastructure.DataAccess;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;

#endregion

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<GeoStrikeDbContext>(options =>
    options.UseSqlServer(
        connectionString,
        sqlOptions => sqlOptions.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(30),
            errorNumbersToAdd: null
        )
    ));

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddApplication();
builder.Services.AddInfrastructure();

builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    List<CultureInfo> supportedCultures =
    [
        new("en"),
        new("pt-BR")
    ];

    options.DefaultRequestCulture = new("en");

    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;

    options.RequestCultureProviders = [new AcceptLanguageHeaderRequestCultureProvider()];
});

builder.Services.AddMvc(options =>
{
    options.Filters.Add<ExceptionFilter>();
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("GeoStrikeCors", policy =>
    {
        policy.WithOrigins("https://localhost:7286")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment()) app.MapOpenApi();

using IServiceScope scope = app.Services.CreateScope();
GeoStrikeDbContext dbContext = scope.ServiceProvider.GetRequiredService<GeoStrikeDbContext>();
dbContext.Database.Migrate();

app.UseHttpsRedirection();
app.UseCors("GeoStrikeCors");
app.UseAuthorization();

app.MapControllers();

app.Run();