using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using TvcDay05Model.Models;

namespace TvcDay05Model.Controllers
{
    public class TvcMemberController : Controller
    {
        static List<TvcMember> members = new List<TvcMember>()
        {
            new TvcMember { MemberId = Guid.NewGuid().ToString(), UserName = "tvchung", FullName = "Trịnh Văn Chung", Password = "A123@12", Email = "chungtrinhj@gmail.com" },
            new TvcMember { MemberId = Guid.NewGuid().ToString(), UserName = "tvanh",   FullName = "Trần Văn Anh",   Password = "B123@34", Email = "anhtran@gmail.com" },
            new TvcMember { MemberId = Guid.NewGuid().ToString(), UserName = "nthao",   FullName = "Nguyễn Thị Thảo", Password = "C123@56", Email = "thaonguyen@gmail.com" },
            new TvcMember { MemberId = Guid.NewGuid().ToString(), UserName = "pvnam",   FullName = "Phạm Văn Nam",   Password = "D123@78", Email = "nampham@gmail.com" },
            new TvcMember { MemberId = Guid.NewGuid().ToString(), UserName = "ltmai",   FullName = "Lê Thị Mai",     Password = "E123@90", Email = "maile@gmail.com" }
        };
        public IActionResult Index()
        {
            // scaffolding

            return View(members);
        }
        // Get TvcCreate
        public IActionResult TvcCreate()
        {
            return View();
        }

        // POST TvcCreate
        [HttpPost]
        public IActionResult TvcCreate(TvcMember model)
        {
            var member = new TvcMember();
            member.MemberId = Guid.NewGuid().ToString();
            member.FullName = model.FullName;
            member.UserName = model.UserName;
            member.Password = model.Password;
            member.Email = model.Email;

            members.Add(member);

            return RedirectToAction("Index");
        }

        // Get TvcEdit
        [HttpGet]
        public IActionResult TvcEdit(string id)
        {
            var model = members.Where(x => x.MemberId == id).FirstOrDefault();
            return View(model);
        }
        [HttpPost]
        public IActionResult TvcEdit(string id, TvcMember model)
        {
            members.Where(x => x.MemberId == id).FirstOrDefault().FullName = model.FullName;
            members.Where(x => x.MemberId == id).FirstOrDefault().UserName = model.UserName;
            members.Where(x => x.MemberId == id).FirstOrDefault().Password = model.Password;
            members.Where(x => x.MemberId == id).FirstOrDefault().Email = model.Email;

            return RedirectToAction("Index");
        }

        // Details
        [HttpGet]
        public IActionResult TvcDetails(string id)
        {
            var model = members.Where(x => x.MemberId == id).FirstOrDefault();
            return View(model);
        }

        // TvcDelete
        [HttpGet]
        public IActionResult TvcDelete(string id)
        {
            var model = members.Where(x => x.MemberId == id).FirstOrDefault();
            return View(model);
        }
        [HttpPost]
        public IActionResult TvcDelete(string id, TvcMember model)
        {
            // Tìm thành viên theo MemberId
            var member = members.FirstOrDefault(m => m.MemberId == id);
            if (member != null)
            {
                members.Remove(member); // Xóa khỏi danh sách
            }
            return RedirectToAction("Index");
        }
        public IActionResult TvcGetMember()
        {
            var tvcMember = new TvcMember();
            tvcMember.MemberId = Guid.NewGuid().ToString();
            tvcMember.UserName = "tvchung";
            tvcMember.FullName = "Trịnh Văn Chung";
            tvcMember.Password = "A123@12";
            tvcMember.Email = "chungtrinhj@gmail.com";

            ViewBag.tvcMember = tvcMember;

            return View();
        }

        public IActionResult TvcGetMembers()
        {
            return View(members);
        }
    }
}
