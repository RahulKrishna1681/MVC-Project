using BookDash.Data;
using BookDash.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookDash.Controllers
{
    public class SignUpController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SignUpController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(LoginViewModel ViewModel)
        {
            try
            {

                var User = new User()
                {
                    Name = ViewModel.Name,
                    Email = ViewModel.Email,
                    Phone = ViewModel.Phone,
                    Password = ViewModel.Password
                };
                _context.Add(User);
                _context.SaveChanges();
                return RedirectToAction("Index", "Login");
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                ModelState.AddModelError(string.Empty, "An error occurred while processing your request.");
                return View();
            }
        }
    }
}