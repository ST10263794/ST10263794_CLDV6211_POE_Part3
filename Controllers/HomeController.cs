using Microsoft.AspNetCore.Mvc;
using ST10263794_CLDV6211_POE_PART2.Data;
using System.Linq;
using ST10263794_CLDV6211_POE_PART2.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace ST10263794_CLDV6211_POE_PART2.Controllers
{
    public class HomeController : Controller
    {
        private readonly KhumaloCraftDbContext _context;

        public HomeController(KhumaloCraftDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult MyWork(String searchString)
        {

            return View();
           
        }

        public IActionResult ShoppingCart() {

            var shoppingCart = new ShoppingCart();
            
            shoppingCart.AddItem(new Product { ProductId = 1, Name = "Product 1", Price = 10.00m }, 2);
            shoppingCart.AddItem(new Product { ProductId = 2, Name = "Product 2", Price = 15.50m }, 1);

            return View(shoppingCart);
        }


    }
}
