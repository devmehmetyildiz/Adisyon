using Auth.Utils;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Auth.Middlewares
{
    public class AuthenticationMiddleware : AuthenticationHandler<AuthenticationOption>
    {

        public AuthenticationMiddleware(IOptionsMonitor<AuthenticationOption> options, ILoggerFactory logger,UrlEncoder encoder,ISystemClock clock) : base(options, logger, encoder, clock)
        {
            
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey(Options.TokenHeaderName))
            {
                return AuthenticateResult.Fail($"Missing header: {Options.TokenHeaderName}");
            }

            string token = Request.Headers[Options.TokenHeaderName]!;

            if (token != "token")
            {
                return AuthenticateResult.Fail($"Invalid token.");
            }

            var claims = new List<Claim>()
            {
                new Claim("FirstName", "Juan")
            };

            var claimsIdentity = new ClaimsIdentity
                (claims, this.Scheme.Name);
            var claimsPrincipal = new ClaimsPrincipal
                (claimsIdentity);

            return AuthenticateResult.Success
                (new AuthenticationTicket(claimsPrincipal,
                this.Scheme.Name));
        }
    }
}
