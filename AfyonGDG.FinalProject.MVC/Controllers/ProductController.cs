using AfyonGDG.FinalProject.MVC.Contexts;
using AfyonGDG.FinalProject.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AfyonGDG.FinalProject.MVC.Controllers;

public class ProductController : Controller
{
    BaseDbContext baseDbContext = new BaseDbContext();

    public IActionResult Index()
    {
        List<Product> products = baseDbContext.Products.ToList();
        return View(products);
    }


    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Product product)
    {
        baseDbContext.Products.Add(product);
        baseDbContext.SaveChanges();
        return RedirectToAction("Index","Product");
    }

    [HttpGet]
    public IActionResult Detail(int id)
    {
        Product product = baseDbContext.Products
            .Include(x=> x.Category).SingleOrDefault(x=>x.Id==id);

        ProductViewModel viewModel = new ProductViewModel()
        {
            Name = product.Name,
            Description = product.Description,
            CategoryName = product.Category.Name,
            Price = product.Price,
            Stock = product.Stock
        };
        return View(viewModel);
    }

    [HttpGet]
    public IActionResult Delete(int id) 
    {
        Product product = baseDbContext.Products.Find(id);

        baseDbContext.Products.Remove(product);
        baseDbContext.SaveChanges();

        return RedirectToAction("Index","Product");

    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        Product product = baseDbContext.Products.Find(id);

        return View(product);
    }

    [HttpPost]
    public IActionResult Edit(Product product)
    {
        baseDbContext.Products.Update(product);
        baseDbContext.SaveChanges();

        return RedirectToAction("Index","Product");
    }
}

