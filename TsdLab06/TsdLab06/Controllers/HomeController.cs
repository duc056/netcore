using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TsdLab06.Models;

namespace TsdLab06.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                    Price = 2850000,
                    Image = "/images/noicom.webp"
                },

                new Product
                {
                    Id = 2,
                    Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                    Price = 2850000,
                    Image = "/images/noicom.webp"
                },

                new Product
                {
                    Id = 3,
                    Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                    Price = 2850000,
                    Image = "/images/noicom.webp"
                },

                new Product
                {
                    Id = 4,
                    Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                    Price = 2850000,
                    Image = "/images/noicom.webp"
                },

                new Product
                {
                    Id = 5,
                    Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                    Price = 2850000,
                    Image = "/images/noicom.webp"
                },

                new Product
                {
                    Id = 6,
                    Name = "Nồi cơm điện cao tần Nagakawa NAG0102",
                    Price = 2850000,
                    Image = "/images/noicom.webp"
                }
            };

            return View(products);
        }
    }
}
