using BookDash.Data;
using BookDash.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BookDash.Controllers
{
    public class FormDataController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FormDataController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Action method to display the form
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(FormDataa formData)
        {
            var user = new FormDataa()
            {
                Name = formData.Name,
                Email = formData.Email,
                PhoneNumber = formData.PhoneNumber,
                BookName = formData.BookName

            };
            _context.Add(user);
            _context.SaveChanges();

            return RedirectToAction("Index","Home");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var formData = await _context.FormDatas.FindAsync(id);
            if (formData == null)
            {
                return NotFound();
            }

            _context.FormDatas.Remove(formData);
            await _context.SaveChangesAsync();

            TempData["Message"] = "Form data successfully deleted.";

            return RedirectToAction("ViewUsers","Admin");
        }
    }
}
