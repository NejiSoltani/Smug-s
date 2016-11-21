using Data.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult list()
        {
            ContactService conserv = new ContactService();
            IEnumerable<contact> listecon = conserv.GetMany();
            return View(listecon);
        }
       
    }
}