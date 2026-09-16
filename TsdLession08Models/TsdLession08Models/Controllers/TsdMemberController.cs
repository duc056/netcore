using Microsoft.AspNetCore.Mvc;
using TsdLession08Models.Models;

namespace TsdLession08Models.Controllers
{
    public class TsdMemberController : Controller
    {
        private static List<TsdMember> _members = new List<TsdMember>()
        {
            new TsdMember
            {
                TsdMemberId = Guid.NewGuid().ToString(),
                TsdUserName = "DungTong",
                TsdPassword = "Password123!",
                TsdFullName = "Tống Sỹ Đức",
                TsdEmail = "tongsyduc@gmail.com"
            },
            new TsdMember
            {
                TsdMemberId = Guid.NewGuid().ToString(),
                TsdUserName = "tranthib",
                TsdPassword = "SecurePass456#",
                TsdFullName = "Trần Thị B",
                TsdEmail = "tranthib@outlook.com"
            },
            new TsdMember
            {
                TsdMemberId = Guid.NewGuid().ToString(),
                TsdUserName = "levanc",
                TsdPassword = "MyPassword789$",
                TsdFullName = "Lê Văn C",
                TsdEmail = "levanc@company.com"
            }
        };

        // GET: Danh sách thành viên
        public IActionResult Index()
        {
            return View(_members);
        }

        [HttpGet]
        public IActionResult TsdCreate()
        {
            var member = new TsdMember();
            return View(member);
        }
        [HttpPost]
        public IActionResult TsdCreate(TsdMember tsdMember)
        {
            tsdMember.TsdMemberId = Guid.NewGuid().ToString();
            _members.Add(tsdMember);

            return RedirectToAction("Index");
            //return View(tsdMember);
        }

        [HttpGet]
        public IActionResult TsdEdit(string id)
        {
            var member = _members.Where(x => x.TsdMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpPost]
        public IActionResult TsdEdit(string id, TsdMember tsdMember)
        {
            // var member = _members.Where(x => x.TsdMemberId.Equals(id)).FirstOrDefault();
            for (int i = 0; i < _members.Count; i++)
            {
                if (_members[i].TsdMemberId == id)
                {
                    _members[i].TsdUserName = tsdMember.TsdUserName;
                    _members[i].TsdPassword = tsdMember.TsdPassword;
                    _members[i].TsdFullName = tsdMember.TsdFullName;
                    _members[i].TsdEmail = tsdMember.TsdEmail;

                    return RedirectToAction("Index");
                }

            }
            return View();
        }

        [HttpGet]
        public IActionResult TsdDetails(string id)
        {
            var member = _members.Where(x => x.TsdMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpGet]
        public IActionResult TsdDelete(string id)
        {
            var member = _members.Where(x => x.TsdMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpPost]
        public IActionResult TsdDeleted(string id)
        {
            foreach (var item in _members)
            {
                if (item.TsdMemberId.Equals(id))
                {
                    _members.Remove(item);
                    return RedirectToAction("Index");
                }
            }
            return View("TsdDelete");
        }
    }
}
