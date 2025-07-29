using Microsoft.AspNetCore.Mvc;
using WebService.Services;

namespace WebService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlatformsController : Controller
    {
        private readonly PlatformService service;

        public PlatformsController(PlatformService service)
        {
            this.service = service;
        }

        [HttpGet("{location}")]
        public ActionResult<List<string>> GetPlatforms(string location)
        {
            var platforms = service.GetLocation(location);

            if(platforms.Count == 0)
            {
                return NotFound("No have location in platforms");
            }

            return Ok(platforms);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
