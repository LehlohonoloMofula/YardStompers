using Microsoft.AspNetCore.Mvc;
using YardStompers.Data;
using YardStompers.Models;

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
            IEnumerable<Category> category = _DbContext.Categories;
            return View(category );
        }
    }
}
