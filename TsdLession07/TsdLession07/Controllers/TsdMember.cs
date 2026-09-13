
using Microsoft.AspNetCore.Mvc;
using TsdLession07.Models.DataModels;

namespace TsdLession07.Controllers
{
    public class TsdMemberController : Controller
    {
        protected static List<TsdMember> _members = new List<TsdMember>
        {
            new TsdMember
            {
                TsdMemberId = Guid.NewGuid().ToString(),
                TsdUserName = "TongDuc",
                TsdPassword = "123456",
                TsdFullName = "Tống Sỹ Đức",
                TsdEmail = "tongduc@example.com"
            },
            new TsdMember
            {
                TsdMemberId = Guid.NewGuid().ToString(),
                TsdUserName = "tranthibinh",
                TsdPassword = "123456",
                TsdFullName = "Trần Thị Bình",
                TsdEmail = "tranthibinh@example.com"
            },
            new TsdMember
            {
                TsdMemberId = Guid.NewGuid().ToString(),
                TsdUserName = "levancuong",
                TsdPassword = "123456",
                TsdFullName = "Lê Văn Cường",
                TsdEmail = "levancuong@example.com"
            },
            new TsdMember
            {
                TsdMemberId = Guid.NewGuid().ToString(),
                TsdUserName = "phamthiduyen",
                TsdPassword = "123456",
                TsdFullName = "Phạm Thị Duyên",
                TsdEmail = "phamthiduyen@example.com"
            },
            new TsdMember
            {
                TsdMemberId = Guid.NewGuid().ToString(),
                TsdUserName = "hoangminhduc",
                TsdPassword = "123456",
                TsdFullName = "Hoàng Minh Đức",
                TsdEmail = "hoangminhduc@example.com"
            }
        };

        public IActionResult Index()
        {
            return View(_members);
        }

        public IActionResult GetMember()
        {
            var member = new TsdMember
            {
                TsdMemberId = Guid.NewGuid().ToString(),
                TsdUserName = "TongDuc",
                TsdPassword = "123456",
                TsdFullName = "Tống Sỹ Đức",
                TsdEmail = "tongduc@example.com"
            };

            //ViewBag.Member = member;
            return View(member);
        }

        // Đưa dữ liệu dạng List ra View
        public IActionResult GetMembers()
        {
            // Lấy từ mock data
            ViewBag.Members = _members;
            return View();
        }

        // GET: Create member
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Create member
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TsdMember member)
        {
            if (ModelState.IsValid)
            {
                member.TsdMemberId = Guid.NewGuid().ToString();
                _members.Add(member);
                return RedirectToAction(nameof(Index));
            }

            return View(member);
        }

    }
}
