using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Models
{
    public class Question
    {


      
        public int idQuestion { get; set; }
        public string answer { get; set; }
        public string description { get; set; }
        public string photo { get; set; }
        [ForeignKey("QuizId")]
        public Nullable<int> QuizId { get; set; }
        public virtual quiz MyQuiz { get; set; }
        public IEnumerable<SelectListItem> Quizs { get; set; }
    }
}