using BusinessLayer.Concrete;
using BusinessLayer.ValidationsRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();

        [HttpGet]
        public ActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact(Contact p)
        {
            cm.AddContact(p);
            return RedirectToAction("Index");
        }

        public PartialViewResult AboutPartial()
        {
            return PartialView();
        }
        // GET: Contact
        public ActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetByID(id);
            return View(contactvalues);
        }

        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}