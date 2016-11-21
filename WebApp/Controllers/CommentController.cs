
using Data.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult Index()
        {
            CommentService commserv = new CommentService();
            IEnumerable<comment> listecomment = commserv.GetMany();
            return View(listecomment);
        }

        public ActionResult liste()
        {
            CommentService commserv = new CommentService();
            IEnumerable<comment> listecomment = commserv.GetMany();
            listecomment.Count();
            return View(listecomment);

        }

        public ActionResult photo()
        {
            PhotoService photserv = new PhotoService();
            IEnumerable<photo> listephoto = photserv.GetMany();
            return View(listephoto);

        }

        public ActionResult photocomment(int id)
        {
            CommentService commserv = new CommentService();
            IEnumerable<comment> listecomment = commserv.GetMany(x => x.photo_idPhoto == id);
            return View(listecomment);

        }

        public ActionResult idea()
        {
            IdeaService ideaserv = new IdeaService();
            IEnumerable<idea> listeidea = ideaserv.GetMany();
            return View(listeidea);

        }

        public ActionResult ideacomment(int id)
        {
            CommentService commserv = new CommentService();
            IEnumerable<comment> listecomment = commserv.GetMany(x => x.idea_idIdea == id);
            return View(listecomment);

        }

        public ActionResult report()
        {
            CommentService commserv = new CommentService();
            IEnumerable<comment> listecomment = commserv.GetMany(x => x.reported == true);
            return View(listecomment);

        }

        public ActionResult addkey()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addkey(dictionary dic)
        {
            try
            {
                dictionary  d = new dictionary();

            d.key = dic.key;
            d.val = dic.val;
            DictionaryService divserv = new DictionaryService();
            divserv.Add(d);
            divserv.Commit();
            return RedirectToAction("addkey");
            }
            catch
            {
                return View();
            }

        }

        public ActionResult listkey()
        {
            DictionaryService divserv = new DictionaryService();
            IEnumerable<dictionary> listedic= divserv.GetMany();
            return View(listedic);
     
        }

        // GET: Comment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Comment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Comment/Create
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

        // GET: Comment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Comment/Edit/5
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

        // GET: Comment/Delete/5
        public ActionResult Delete(int id)
        {

            CommentService commserv = new CommentService();
            comment c = new comment();
            c = commserv.GetById(id);
            commserv.Delete(c);
            commserv.Commit();
           
            return RedirectToAction("report");
        }

        // POST: Comment/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                CommentService commserv = new CommentService();
                comment c = new comment();
                c = commserv.GetById(id);
                commserv.Delete(c);
                commserv.Commit();
                

                return RedirectToAction("report");
            }
            catch
            {
                return View();
            }
        }
    }
}
