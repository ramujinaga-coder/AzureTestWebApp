using AzureTestWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzureTestWebApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            // Sample in-memory product list
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Widget A", Description = "A basic widget", Price = 9.99m },
                new Product { Id = 2, Name = "Widget B", Description = "An advanced widget", Price = 19.99m },
                new Product { Id = 3, Name = "Gadget", Description = "A useful gadget", Price = 14.99m },
            };

            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = new Product { Id = id, Name = $"Product {id}", Description = "Details about product.", Price = 12.34m };
            return View(product);
        }
    }
}
