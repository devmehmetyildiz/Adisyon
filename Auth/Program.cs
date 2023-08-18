using Auth.Dataaccess;
using Auth.Dataaccess.Abstract;
using Auth.Dataaccess.Concrete;
using Auth.Middlewares;
using Auth.Utils;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);


ConfigurationManager configuration = builder.Configuration;

builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => options.AllowAnyMethod().AllowCredentials()
     .AllowAnyHeader().WithOrigins(configuration["Corsdomains"]));
});

builder.Services.AddHttpContextAccessor();
builder.Services.AddTransient<ClaimsPrincipal>(s => s.GetService<IHttpContextAccessor>().HttpContext.User);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Default")));
builder.Services.AddScoped<IAccesstokenRepository, AccesstokenRepository>();

builder.Services.AddControllers();
builder.Services.AddAuthentication
(AuthenticationOption.DefaultScheme)
    .AddScheme<AuthenticationOption, AuthenticationMiddleware>
    (AuthenticationOption.DefaultScheme,
        options => { });


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseAuthentication();
app.UseAuthorization();
app.MapControllers().RequireAuthorization();

app.Run();
