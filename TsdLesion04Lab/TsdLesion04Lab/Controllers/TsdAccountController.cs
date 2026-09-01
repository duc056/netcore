using Microsoft.AspNetCore.Mvc;
using TsdLesion04Lab.Models;

namespace TsdLesion04Lab.Controllers
{
    public class TsdAccountController : Controller
    {
        public readonly List<TsdAccount> tsdAccounts = new() {
             new TsdAccount
            {
                Id = 1,
                Name = "Nguyễn Văn An",
                Email = "nguyenvanan@gmail.com",
                Phone = "0901234567",
                Avatar = "/images/1.png",
                Address = "Hà Nội",
                Bio = "Sinh viên ngành Công nghệ thông tin",
                Gender = 1,
                Birthday = new DateTime(2003, 5, 12)
            },

            new TsdAccount
            {
                Id = 2,
                Name = "Trần Thị Bình",
                Email = "tranthibinh@gmail.com",
                Phone = "0912345678",
                Avatar = "/images/2.webp",
                Address = "Hải Phòng",
                Bio = "Lập trình viên Frontend",
                Gender = 0,
                Birthday = new DateTime(2002, 8, 20)
            },

            new TsdAccount
            {
                Id = 3,
                Name = "Lê Minh Cường",
                Email = "leminhcuong@gmail.com",
                Phone = "0923456789",
                Avatar = "/images/3.png",
                Address = "Đà Nẵng",
                Bio = "Kỹ sư phần mềm",
                Gender = 1,
                Birthday = new DateTime(1999, 3, 15)
            },

            new TsdAccount
            {
                Id = 4,
                Name = "Phạm Ngọc Dung",
                Email = "phamngocdung@gmail.com",
                Phone = "0934567890",
                Avatar = "/images/4.jfif",
                Address = "Hồ Chí Minh",
                Bio = "Thiết kế UI/UX",
                Gender = 0,
                Birthday = new DateTime(2001, 11, 8)
            },

            new TsdAccount
            {
                Id = 5,
                Name = "Hoàng Đức Long",
                Email = "hoangduclong@gmail.com",
                Phone = "0945678901",
                Avatar = "/images/3.png",
                Address = "Bắc Ninh",
                Bio = "Lập trình viên Backend .NET",
                Gender = 1,
                Birthday = new DateTime(2000, 7, 25)
            }


        };
        public IActionResult TsdIndex()
        {
            ViewBag.TsdAccounts = tsdAccounts;
            return View();
        }

        [Route("ho-so-cua-toi", Name = "TsdProfile")]
        public IActionResult TsdProfile(int? id)
        {
            TsdAccount tsdAccount = new TsdAccount
            {
                Id = 5,
                Name = "Hoàng Quốc Dũng",
                Email = "dung.hoang@example.com",
                Phone = "0945678901",
                Avatar = "/images/3.png",
                Address = "56 Đường Quang Trung, TP. Nha Trang, Khánh Hòa",
                Bio = "Chuyên viên phân tích dữ liệu, thích chơi bóng rổ.",
                Gender = 1,
                Birthday = new DateTime(1997, 12, 5)
            };

            if (id != null)
            {
                tsdAccount = tsdAccounts.FirstOrDefault(x => x.Id == id);
            }

            ViewBag.TsdAccount = tsdAccount;
            return View();
        }
    }
    }
