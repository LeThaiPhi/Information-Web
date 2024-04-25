using Microsoft.AspNetCore.Mvc;

namespace InformationsMVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
