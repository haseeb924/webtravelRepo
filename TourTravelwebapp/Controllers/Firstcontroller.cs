using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace TourTravelwebapp.Controllers
{
    public class Firstcontroller : Controller
    {
        private readonly ILogger<Firstcontroller> _logger;

        public Firstcontroller(ILogger<Firstcontroller> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View();
        }

     
        
    }

}
