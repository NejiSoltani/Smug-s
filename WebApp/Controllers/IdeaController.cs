using Data.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class IdeaController : Controller
    {
        // GET: Idea
        public ActionResult Index()
        {
            IdeaService questionserv = new IdeaService();
            IEnumerable<idea> listequestion = questionserv.GetMany();
            //int a = questionserv.getNbrofLikesById(13);
            return View(listequestion);
        }

        // GET: ReportedIdea
        public ActionResult ReportedIdea()
        {
            IdeaService questionserv = new IdeaService();
            IEnumerable<idea> listequestion = questionserv.getReportedIdea();
            //int a = questionserv.getNbrofLikesById(13);
            return View(listequestion);
        }

        // GET: Idea/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Idea/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Idea/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Idea/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Idea/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Idea/Delete/5
        public ActionResult Delete(int id)
        {
            IdeaService questionserv = new IdeaService();

            idea c = new idea();
            c = questionserv.GetById(id);
            questionserv.Delete(c);
            questionserv.Commit();

            return RedirectToAction("Index");
            
        }

        // POST: Idea/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                IdeaService questionserv = new IdeaService();

                idea c = new idea();
                c = questionserv.GetById(id);
                questionserv.Delete(c);
                questionserv.Commit();

                return RedirectToAction("Index");
               
            }
            catch
            {
                return View();
            }
        }
    }
}
