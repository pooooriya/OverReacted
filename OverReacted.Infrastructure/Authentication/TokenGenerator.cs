using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using OverReacted.Application.Dtos.Settings;
using OverReacted.Application.Interfaces;
using OverReacted.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
namespace OverReacted.Infrastructure.Authentication
{
    public class TokenGenerator : ITokenProvider
    {
        private readonly IOptions<JwtSettings> jwtSettings;

        public TokenGenerator(IOptions<JwtSettings> jwtSettings)
        {
            this.jwtSettings = jwtSettings;
        }

        public string GenerateAccessToken(User user)
        {
            var Claimes = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Role,user.Role.Name),
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Value.SecretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var encrypt = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Value.EncryptKey));
            var encryptkey = new EncryptingCredentials(encrypt, SecurityAlgorithms.Aes128KW, SecurityAlgorithms.Aes128CbcHmacSha256);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(Claimes),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = creds,
                Issuer = jwtSettings.Value.Issuer,
                Audience = jwtSettings.Value.Audience,
                IssuedAt = DateTime.UtcNow,
                EncryptingCredentials = encryptkey
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
