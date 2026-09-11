using Microsoft.AspNetCore.Mvc;
using TsdLab06.Models;

namespace TsdLab06.ViewComponents
{
    public class HotProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
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
                }
            };

            return View(products);
        }
    }
}