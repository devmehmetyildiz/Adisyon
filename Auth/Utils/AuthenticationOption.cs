using Microsoft.AspNetCore.Authentication;

namespace Auth.Utils
{
    public class AuthenticationOption : AuthenticationSchemeOptions
    {
        public const string DefaultScheme = "AuthenticationOption";
        public string TokenHeaderName { get; set; } = "MyToken";
    }
}
