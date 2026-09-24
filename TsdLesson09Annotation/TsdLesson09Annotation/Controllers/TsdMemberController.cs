using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TsdLesson09Annotation.Models.DataModel;
using TsdLesson09Annotation.Models.DataViewModels;

namespace TsdLesson09Annotation.Controllers
{
    public class TsdMemberController : Controller
    {
        private static List<TsdMember> TsdMembers = new List<TsdMember>();
        // GET: TsdMemberController
        public ActionResult Index()
        {
            return View(TsdMembers);
        }

        // GET: TsdMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TsdMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TsdMemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TsdMemberRegister TsdMember)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(TsdMember);
                }

                TsdMember newMember = new TsdMember
                {
                    TsdMemberId = TsdMembers.Count + 1,
                    TsdUserName = TsdMember.TsdUserName,
                    TsdPassword = TsdMember.TsdPassword,
                    TsdEmail = TsdMember.TsdEmail,
                    TsdPhoneNumber = TsdMember.TsdPhoneNumber,
                    TsdFullName = TsdMember.TsdFullName,
                    TsdBirthday = TsdMember.TsdBirthday
                };

                TsdMembers.Add(newMember);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(TsdMember);
            }
        }

        // GET: TsdMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TsdMemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TsdMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TsdMemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
