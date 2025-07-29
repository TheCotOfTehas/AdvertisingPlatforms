using Microsoft.AspNetCore.Mvc;
using WebService.Services;

namespace WebService.Controllers
{
    public class PlatformsController : Controller
    {
        private readonly PlatformService service;

        public PlatformsController(PlatformService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
