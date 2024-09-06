using AuthAPI.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminAuthController : ControllerBase
    {
        private readonly IConfiguration _configuration; 
        private readonly AuthAPIContext _context;

        public AdminAuthController(IConfiguration configuration, AuthAPIContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        [HttpPost("login")]
        public IActionResult Login(LoginDTO loginDto)
        {

            
            var admin = _context.Admins.FirstOrDefault(u => u.Email == loginDto.Email);

            if (!(admin != null && VerifyPassword(admin.Password, loginDto.Password))) return Unauthorized();

            var token = GenerateJwtToken(admin.Email);
            return Ok(new
            {
                admin.Name,
                admin.Email,
                JwtToken = token
            });
        }

        // Generate JWT token
        private string GenerateJwtToken(string email)
        {
            //var jwtSettings = _configuration.GetSection("JwtSettings");
            //var key = Encoding.ASCII.GetBytes(jwtSettings["Key"]);
            //var issuer = jwtSettings["Issuer"];
            //var audience = jwtSettings["Audience"];
            //var tokenExpiration = TimeSpan.FromMinutes(double.Parse(jwtSettings["DurationInMinutes"]));
            var key = Encoding.ASCII.GetBytes(Environment.GetEnvironmentVariable("JWT_KEY"));
            var issuer = Environment.GetEnvironmentVariable("JWT_ISSUER");
            var audience = Environment.GetEnvironmentVariable("JWT_AUDIENCE");
            var tokenExpiration = TimeSpan.FromMinutes(double.Parse(Environment.GetEnvironmentVariable("JWT_DURATION_IN_MINUTES")));

            var claims = new[]
                {
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Role, "Admin"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.Add(tokenExpiration),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = issuer,
                Audience = audience
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private static bool VerifyPassword(string storedPasswordHash, string providedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(providedPassword, storedPasswordHash);
        }


    }
}
