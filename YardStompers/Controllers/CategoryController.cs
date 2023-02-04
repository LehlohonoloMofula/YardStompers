using Microsoft.AspNetCore.Mvc;

namespace YardStompers.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
