using Microsoft.AspNetCore.Mvc;

namespace AgendaTarefa.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
