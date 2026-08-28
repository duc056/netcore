using Microsoft.AspNetCore.Mvc;
using TsdLession03.Models;

namespace TsdLession03.Controllers
{
    public class TsdProductController : Controller
    {
        //Tạo mốc data
        private readonly List<TsdProduct> _products = new()
        {
            new TsdProduct
            {
                TsdProductId = "SP001",
                TsdProductName = "Laptop Dell Inspiron 15",
                TsdProductRelease = "2025",
                TsdPrice = "18500000"
            },
            new TsdProduct
            {
                TsdProductId = "SP002",
                TsdProductName = "Laptop ASUS Vivobook 15",
                TsdProductRelease = "2025",
                TsdPrice = "16990000"
            },
            new TsdProduct
    {
        TsdProductId = "SP003",
        TsdProductName = "Laptop Lenovo IdeaPad Slim 5",
        TsdProductRelease = "2025",
        TsdPrice = "15990000"
    },
            new TsdProduct
            {
                TsdProductId = "SP004",
                TsdProductName = "Màn hình Samsung 24 inch Full HD",
                TsdProductRelease = "2024",
                TsdPrice = "4290000"
            },
            new TsdProduct
            {
                TsdProductId = "SP005",
                TsdProductName = "Màn hình LG UltraGear 27 inch",
                TsdProductRelease = "2025",
                TsdPrice = "6990000"
            },
            new TsdProduct
            {
                TsdProductId = "SP006",
                TsdProductName = "Bàn phím cơ Logitech G Pro",
                TsdProductRelease = "2024",
                TsdPrice = "2490000"
            },
            new TsdProduct
            {
                TsdProductId = "SP007",
                TsdProductName = "Chuột Logitech G502 HERO",
                TsdProductRelease = "2024",
                TsdPrice = "1590000"
            },
            new TsdProduct
            {
                TsdProductId = "SP008",
                TsdProductName = "Tai nghe Gaming HyperX Cloud II",
                TsdProductRelease = "2024",
                TsdPrice = "1890000"
            },
            new TsdProduct
            {
                TsdProductId = "SP009",
                TsdProductName = "Card đồ họa NVIDIA GeForce RTX 4060",
                TsdProductRelease = "2024",
                TsdPrice = "8990000"
            },
            new TsdProduct
            {
                TsdProductId = "SP010",
                TsdProductName = "Ổ cứng SSD Samsung 990 EVO 1TB",
                TsdProductRelease = "2025",
                TsdPrice = "2390000"
            }
        };
        public IActionResult Index()
        {
            return Json(_products);
        }
        public IActionResult TsdGetAllProduct()
        {
            ViewData["Products"] = _products;
            return View();
        }
        public IActionResult TsdGetListProduct()
        {
            return View(_products);
        }
    }
}
