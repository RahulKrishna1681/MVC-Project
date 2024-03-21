using Microsoft.AspNetCore.Mvc;
using BookDash.Data;
using BookDash.Models;

namespace BookDash.Controllers
{
    public class LoginController : Controller
    {

        private readonly ApplicationDbContext _context;
        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(LoginViewModel viewModel)
        {
            ModelState.Remove("Email");
            ModelState.Remove("Phone");
            if (ModelState.IsValid)
            {
                var validUser = _context.Users.FirstOrDefault(u => u.Name == viewModel.Name && u.Password == viewModel.Password);

                if (validUser != null)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
    }
}