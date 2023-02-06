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
        public IActionResult Create()
        {
            return View();
        }
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if(ModelState.IsValid)
            {
                _DbContext.Categories.Add(category);
                category.CreatedAt = DateTime.Now;
                _DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        } 

        public IActionResult Edit(Guid Id)
        {
            IEnumerable<Category> category = _DbContext.Categories;
            return View(category );
        }

        public IActionResult Delete(Guid Id)
        {
            if(Id == null || Id == 0)
            {
                return NotFound();
            }
            var category = _DbContext.Categories.Find(Id);
            if(category == null)
            {
                return NotFound();
            }
            return View(category);
        }
    }
}