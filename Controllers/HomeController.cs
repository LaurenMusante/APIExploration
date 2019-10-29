
using Microsoft.AspNetCore.Mvc;
using ApiExploration.Models;

namespace ApiExploration.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allDestinations = Destination.GetDestinations();
            return View(allDestinations);
        }
    }
}
