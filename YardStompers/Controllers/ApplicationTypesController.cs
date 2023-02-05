using Microsoft.AspNetCore.Mvc;

namespace YardStompers.Controllers
{
    public class ApplicationTypesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
