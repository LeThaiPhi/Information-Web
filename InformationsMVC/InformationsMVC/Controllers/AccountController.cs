using InformationsMVC.Data;
using InformationsMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace InformationsMVC.Controllers
{
    public class AccountController : Controller

    {
        private readonly InformationsMVCContext _context;

        public AccountController(InformationsMVCContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User _userFromPage)
        {
            var _user = _context.User.Where(m => m.Email == _userFromPage.Email && m.Password == _userFromPage.Password).FirstOrDefault();
            if (_user == null)
            {
                ViewBag.LoginStatus = 0;
            }
            else
            {
                return RedirectToAction("Index", "Account");
            }
            return View();
        }
    }
}
