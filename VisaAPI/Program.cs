using AuthAPI;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var databaseUrl = Environment.GetEnvironmentVariable("DATABASE_URL");  // use this as the db url when using docker 
// var databaseUrl = "Host=localhost;Port=5000;Database=dcodeDB;Username=postgres;Password=123;";

// Add services to the container.

builder.Services.AddControllers();
// builder.Services.AddDbContext<>()
builder.Services.AddDbContext<AuthAPIContext>(
    options => options.UseNpgsql(databaseUrl)
);

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    var key = Environment.GetEnvironmentVariable("JWT_KEY");  
    var issuer = Environment.GetEnvironmentVariable("JWT_ISSUER");  
    var audience = Environment.GetEnvironmentVariable("JWT_AUDIENCE");  

    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = issuer,
        ValidAudience = audience,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
        ClockSkew = TimeSpan.Zero  // Remove delay of token expiration
    };
});

// Add Authorization
builder.Services.AddAuthorization();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
