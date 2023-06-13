using BusinessLayer.Concrete;
using BusinessLayer.ValidationsRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message

        MessageManager mm = new MessageManager(new EfMessageDal());
        MessageValidator messageValidator = new MessageValidator();

        [Authorize]
        public ActionResult Inbox(string p)
        {
            var messageList = mm.GetListInbox(p);
            return View(messageList);
        }

        public ActionResult SendBox(string p)
        {
            var messagelist = mm.GetListSendbox(p);
            return View(messagelist);
        }
        
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            ValidationResult results = messageValidator.Validate(p);
            if (results.IsValid)
            {
                p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                mm.MessageyAdd(p);
                return RedirectToAction("SendBox");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public ActionResult GetInBoxMessageDetails(int id)
        {
            var values = mm.GetByID(id);
            return View(values);
        }

        public ActionResult GetSendBoxMessageDetails(int id)
        {
            var values = mm.GetByID(id);
            return View(values);
        }
    }
}