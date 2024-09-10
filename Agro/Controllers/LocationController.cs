using Agro_Handler.IHandler;
using Microsoft.AspNetCore.Mvc;

namespace Agro.Controllers
{
    public class LocationController: Controller
    {
        private readonly ILocationHandler _locationHandler;
        public LocationController(ILocationHandler locationHandler)
        {
            _locationHandler = locationHandler;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetLocations()
        {
            var locations = _locationHandler.GetLocations().ToList();
            return View(locations);
        }
    }
}
