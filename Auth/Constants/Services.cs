using Microsoft.Extensions.Configuration;

namespace Auth.Constants
{
    public class Services
    {
        private readonly IConfiguration _configuration;
        private static Services Instance = null;

        public readonly string Auth;
        public readonly string Business;
        public readonly string Gateway;
        public readonly string Payment;
        public readonly string Userrole;
        public readonly string Warehouse;

        private Services(IConfiguration configuration)
        {
            _configuration = configuration;

            Auth = _configuration["Services:Auth"];
            Business = _configuration["Services:Business"];
            Gateway = _configuration["Services:Gateway"];
            Payment = _configuration["Services:Payment"];
            Userrole = _configuration["Services:Userrole"];
            Warehouse = _configuration["Services:Warehouse"];
        }

        public static Services GetInstance(IConfiguration configuration)
        {
            if (Instance == null)
            {
                Instance = new Services(configuration);
            }
            return Instance;
        }
    }
}
