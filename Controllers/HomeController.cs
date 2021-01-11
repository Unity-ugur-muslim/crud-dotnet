using Microsoft.AspNetCore.Mvc;

namespace Crud.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}