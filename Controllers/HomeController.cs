using Microsoft.AspNetCore.Mvc;

namespace POSProfessional.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}