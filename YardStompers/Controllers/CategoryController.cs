using Microsoft.AspNetCore.Mvc;

namespace YardStompers.Controllers
{
    public class CategoryController : Controller
    {
        private readonly YardStompersDbContext _DbContext;

        public CategoryController(YardStompersDbContext DbContext)
        {
            _DbContext = DbContext;
        }
    
        public IActionResult Index()
        {
            IEnumerable<Category> category = _DbContext.Category;
            return View(category );
        }
    }
}
