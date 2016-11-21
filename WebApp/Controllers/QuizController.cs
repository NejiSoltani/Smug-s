using Data.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class QuizController : Controller
    {
        // GET: Quiz
        public ActionResult Index()
        {
            QuizService questionserv = new QuizService();
            IEnumerable<quiz> listequestion = questionserv.GetMany();
            DeuxClass d = new DeuxClass();
            d.quizs = listequestion;


            return View(d);
        }

        public ActionResult Index2()
        {
            QuizService questionserv = new QuizService();
            IEnumerable<quiz> listequestion = questionserv.GetMany();
            DeuxClass d = new DeuxClass();
            d.quizs = listequestion;


            return View(d);
        }

        // GET: Quiz/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Quiz/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Quiz/Create
        [HttpPost]
        public ActionResult Create(quiz quiz)
        {
            try
            {
                // Question q = new Question();
              
                quiz q = new quiz();
                // qd.idQuestion = 1;
                q.title = quiz.title;
                q.startDate = quiz.startDate;
                q.endDate = quiz.endDate;
                
              QuizService quizserv = new QuizService();
                quizserv.Add(q);
                quizserv.Commit();
                return RedirectToAction("Index");

                
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Create2(DeuxClass deux)
        {
            try
            {
                // Question q = new Question();
                quiz q = new quiz();
                // qd.idQuestion = 1;
                q.title = deux.quiz.title;
                q.startDate = deux.quiz.startDate;
                q.endDate = deux.quiz.endDate;

                QuizService quizserv = new QuizService();
                quizserv.Add(q);
                quizserv.Commit();
                return RedirectToAction("Index");


            }
            catch
            {
                return View();
            }
        }

        // GET: Quiz/Edit/5
        public ActionResult Edit(int id)
        {
            QuizService quizserv = new QuizService();


            return View();
        }

        // POST: Quiz/Edit/5
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

        // GET: Quiz/Delete/5
        public ActionResult Delete(int id)
        {
            QuizService questionserv = new QuizService();

            quiz c = new quiz();
            c = questionserv.GetById(id);
            questionserv.Delete(c);
            questionserv.Commit();

            return RedirectToAction("Index");

        }

        // POST: Quiz/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                QuizService questionserv = new QuizService();

                quiz c = new quiz();
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
