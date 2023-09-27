using Microsoft.AspNetCore.Mvc;

namespace Emlak.WebUI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
