using Microsoft.AspNetCore.Mvc;

namespace Searchamb.Controllers
{
    public class BuscadorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
