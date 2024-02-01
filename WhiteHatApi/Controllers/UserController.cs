using Microsoft.AspNetCore.Mvc;

namespace WhiteHatApi.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
