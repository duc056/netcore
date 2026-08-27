using Microsoft.AspNetCore.Mvc;
using TsdLession02Demo.Models;

namespace TsdLession02Demo.Controllers
{
    public class TsdProductController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name ="Tống Sỹ Đức";
            ViewData["Adress"] = "Fit NTU";
            TempData["UNI"] = "Trường Đại học Nguyễn Trãi";

            return View();
        }
        public IActionResult GetProduct()
        {
            TsdProduct tsdproduct = new TsdProduct()
            {
                ProductId = "P001",
                ProductName = "Laptop Dell Vostro  ",
                Price = 22000000,
                YearRelease = 2024
            };

            ViewData["ProductVD"] = tsdproduct;
            ViewBag.ProductVB = tsdproduct;

            return View();
        }
    }
}
