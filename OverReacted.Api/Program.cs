using FluentValidation.AspNetCore;
using Jobguy.Application.Contracts;
using Microsoft.EntityFrameworkCore;
using OverReacted.Application.Dtos;
using OverReacted.Application.Dtos.Auth;
using OverReacted.Application.Dtos.Settings;
using OverReacted.Application.Interfaces;
using OverReacted.Application.Services;
using OverReacted.Application.Services.Implements;
using OverReacted.Infrastructure.Authentication;
using OverReacted.Infrastructure.Configurations;
using OverReacted.Infrastructure.Notifications;
using OverReacted.Infrastructure.Persistance;
using OverReacted.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
// Add services to the container.
builder.Services.AddControllers()
    .AddFluentValidation(options =>
{
    options.ImplicitlyValidateChildProperties = true;
    options.ImplicitlyValidateRootCollectionElements = true;
    options.RegisterValidatorsFromAssembly(typeof(RegisterUserDto).Assembly);
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<OverReactedDbContext>(opt =>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection"));
});

builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.Configure<AuthenticationSetting>(builder.Configuration.GetSection("Authentication"));
builder.Services.AddCustomJwtAutentication(configuration.GetSection(nameof(JwtSettings)).Get<JwtSettings>());
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>))
    .AddScoped<IUserService, UserService>()
    .AddScoped<ITokenProvider, TokenGenerator>()
    .AddScoped<IEmailService, EmailService>()
    .AddScoped<IArticleService, ArticleService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<OverReactedDbContext>();
    context.Database.Migrate();
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
