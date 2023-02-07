using Microsoft.AspNetCore.Mvc;
using YardStompers.Data;
using YardStompers.Models;

namespace YardStompers.Controllers
{
    public class ProductsController : Controller
    {
        private readonly YardStompersDbContext _DbContext;

        public ProductsController(YardStompersDbContext DbContext)
        {
            _DbContext = DbContext;
        }
    
        public IActionResult Index()
        {
            IEnumerable<Product> product = _DbContext.Products;
            foreach(var product in product)
            {
                product.Categories = _DbContext.Categories.FirstOrDefault(u => u.Id == product.CategoryId);
            }
            return View(product);
        }

        public IActionResult Create()
        {
            return View();
        }
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if(ModelState.IsValid)
            {
                _DbContext.Categories.Add(product);
                product.CreatedAt = DateTime.Now;
                _DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        } 

        public IActionResult Edit(Guid Id)
        {
            IEnumerable<Product> product = _DbContext.Categories;
            return View(product );
        }
        [HttpPut]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product)
        {
            if(ModelState.IsValid)
            {
                _DbContext.Categories.Update(product);
                product.ModifiedAt = DateTime.Now;
                _DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        } 

        public IActionResult Delete(Guid Id)
        {
           
            var product = _DbContext.Categories.Find(Id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}