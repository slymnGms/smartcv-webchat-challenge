using smartcv_webchat_challenge_bll;
using smartcv_webchat_challenge_common.Models;
using System.Linq;
using System.Web.Mvc;

namespace smartcv_webchat_challenge.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        public ActionResult Chat()
        {
            if (Session["uid"] is null) return RedirectToAction("Login");
            var messages = unitOfWork.Messages.Get();
            return View(messages);
        }

        public ActionResult Login(string username, string password)
        {
            var u = unitOfWork.Users.Get(x => x.Username == username && x.Password == password).FirstOrDefault();
            if (u is null) return View();
            Session["uid"] = u.UserID;
            return RedirectToAction("Chat");
        }

        public ActionResult Register(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) return View();
            unitOfWork.Users.Insert(new User { Username = username, Password = password });
            return RedirectToAction("Login");
        }

        [HttpPost]
        public ActionResult SendMessage(Message m)
        {
            m.TimeStamp = System.DateTime.Now;
            unitOfWork.Messages.Insert(m);
            return new EmptyResult();
        }
    }
}