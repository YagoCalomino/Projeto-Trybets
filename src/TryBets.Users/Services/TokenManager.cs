using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TryBets.Users.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace TryBets.Users.Services
{
    public class TokenManager
    {
        private readonly TokenOptions _tokenOptions;
        public TokenManager()
        {
            _tokenOptions = new TokenOptions {
                Secret = "4d82a63bbdc67c1e4784ed6587f3730c",
                ExpiresDay = 1
            };
        }

        public string Generate(User user)
        {
            var identityClaims = new ClaimsIdentity();
            identityClaims.AddClaim(new Claim(ClaimTypes.Email, user.Email!));

            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_tokenOptions.Secret!));
            var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256Signature);

            var securityTokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = identityClaims,
                SigningCredentials = signingCredentials,
                Expires = DateTime.Now.AddDays(_tokenOptions.ExpiresDay)
            };

            var securityToken = jwtTokenHandler.CreateToken(securityTokenDescriptor);
            return jwtTokenHandler.WriteToken(securityToken);
        }
    }
}