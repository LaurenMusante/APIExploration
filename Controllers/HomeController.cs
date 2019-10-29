
using Microsoft.AspNetCore.Mvc;
using ApiExploration.Models;

namespace ApiExploration.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
