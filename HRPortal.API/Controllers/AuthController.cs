using Microsoft.AspNetCore.Mvc;

namespace HRPortal.API.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
