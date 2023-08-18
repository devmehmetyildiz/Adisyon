using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OauthController : ControllerBase
    {
        public OauthController()
        {
            
        }

        public async Task<IActionResult> Test()
        {
            return Ok();
        }
    }
}
