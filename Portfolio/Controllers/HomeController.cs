using System.Web.Mvc;
using Portfolio.Models;
using Portfolio.Library;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        public ActionResult Contact()
        {
            return View(new ContactViewModel());
        }
 
        [HttpPost]
        public ActionResult Contact(ContactViewModel contactVM)
        {
            if (!ModelState.IsValid)
            {
                return View(contactVM);
            }
 
            var contact = new Contact
            {
                From = contactVM.From,
                Subject = contactVM.Subject,
                Message = contactVM.Message
            };
 
            new Email().Send(contact);
 
            return RedirectToAction("Index");
        }
 
        public ActionResult ContactConfirm()
        {
            return View();
        }
 
        public ActionResult LinkToMe()
        {
            return View();
        }
 
        public ActionResult Contribute()
        {
            return View();
        }
 
        public ActionResult Terms()
        {
            return View();
        }

    }
}