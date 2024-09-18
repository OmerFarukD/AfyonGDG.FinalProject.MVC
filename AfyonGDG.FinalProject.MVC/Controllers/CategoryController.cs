using AfyonGDG.FinalProject.MVC.Contexts;
using AfyonGDG.FinalProject.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AfyonGDG.FinalProject.MVC.Controllers
{
    public class CategoryController : Controller
    {
        BaseDbContext baseDbContext = new BaseDbContext();

        public IActionResult Index()
        {

            List<Category> categories = baseDbContext.Categories.ToList();
            return View(categories);
        }
    }
}
