using Data.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Helpers;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class QuestionController : Controller
    {
        // GET: Question
        public ActionResult Index()
        {
            QuestionService questionserv = new QuestionService();
            IEnumerable<question> listequestion = questionserv.GetMany();

            return View(listequestion);
        }

        // GET: Question/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // GET: Question/Create
        public ActionResult Create()
        {
            QuizService quizserv = new QuizService();
           Question mv = new Question();

            mv.Quizs= quizserv.GetMany().ToSelectListItems() ;
            ////drodownlist
        
          
            return View(mv);
        }

        // POST: Question/Create
        [HttpPost]
        public ActionResult Create(Question question)
        {
            try
            {
               // Question q = new Question();
                question qd = new question();
               // qd.idQuestion = 1;
                qd.answer = question.answer;
                qd.description = question.description;
                qd.quiz_idQuiz = question.QuizId;
                QuestionService questionserv = new QuestionService();
              questionserv.Add(qd);
                questionserv.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Question/Edit/5
        public ActionResult Edit(int id)
        {
            QuestionService questionserv = new QuestionService();

            question c = new question();
            c = questionserv.GetById(id);
           // c.answer = "lolo";
            questionserv.Update(c);
            questionserv.Commit();

            return View();
        }

        // POST: Question/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                QuestionService questionserv = new QuestionService();

                question c = new question();
                c = questionserv.GetById(id);
                c.answer = "LoLo";
                questionserv.Update(c);
                questionserv.Commit();

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Question/Delete/5
        public ActionResult Delete(int id)
        {
            QuestionService questionserv = new QuestionService();

            question c = new question();
            c = questionserv.GetById(id);
            questionserv.Delete(c);
            questionserv.Commit();

            return RedirectToAction("Index");

            
        }

        // POST: Question/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                QuestionService questionserv = new QuestionService();

                question c = new question();
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
