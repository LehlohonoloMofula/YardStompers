using Microsoft.AspNetCore.Mvc;

namespace YardStompers.Controllers
{
    public class ApplicationTypesController : Controller
    {
       private readonly YardStompersDbContext _DbContext;

        public ApplicationTypesController(YardStompersDbContext DbContext)
        {
            _DbContext = DbContext;
        }
    
        public IActionResult Index()
        {
            IEnumerable<ApplicationType> applicationType = _DbContext.ApplicationTypes;
            return View(applicationType);
        }
        public IActionResult Create()
        {
            return View();
        }
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ApplicationType applicationType)
        {
            if(ModelState.IsValid)
            {
                _DbContext.ApplicationTypes.Add(applicationType);
                applicationType.CreatedAt = DateTime.Now;
                _DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(applicationType);
        } 

        public IActionResult Edit(Guid Id)
        {
            IEnumerable<ApplicationType> applicationType = _DbContext.ApplicationTypes;
            return View(applicationType );
        }
        [HttpPut]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ApplicationType applicationType)
        {
            if(ModelState.IsValid)
            {
                _DbContext.ApplicationTypes.Update(applicationType);
                applicationType.ModifiedAt = DateTime.Now;
                _DbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(applicationType);
        } 

        public IActionResult Delete(Guid Id)
        {
           
            var applicationType = _DbContext.ApplicationTypes.Find(Id);
            if(applicationType == null)
            {
                return NotFound();
            }
            return View(applicationType);
        }
    }
}
