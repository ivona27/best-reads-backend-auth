using AuthService.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet, Authorize(Roles = "Admin")]
        public async Task<ActionResult<List<UserModel>>> GetUsers()
        {
            return Ok("Yeeeeey");
        }
    }
}
