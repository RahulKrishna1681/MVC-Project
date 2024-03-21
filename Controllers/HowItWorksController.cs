using Microsoft.AspNetCore.Mvc;

namespace BookDash.Controllers
{
    public class HowItWorksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
