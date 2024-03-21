using BookDash.Data;
using BookDash.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BookDash.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Logic to display the admin dashboard view
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(AdminLoginViewModel viewModel)
        {
            ModelState.Remove("Email");
            ModelState.Remove("Phone");

            if (ModelState.IsValid)
            {
                var validUser = _context.Users.FirstOrDefault(u => u.Name == viewModel.Username && u.Password == viewModel.Password);

                if (viewModel.Username == "admin@gmail.com" && viewModel.Password == "Admin@123")
                {
                    return RedirectToAction("ViewUsers", "Admin");
                }
            }
            return View();
        }

        public IActionResult ViewUsers()
        {
            // Logic to display form data view
            var users = _context.FormDatas.ToList();
            return View(users);
        }
    }
}
