using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public partial class question
    {
        [Key]
        public int idQuestion { get; set; }
        public string answer { get; set; }
        public string description { get; set; }
        public string photo { get; set; }
       // [ForeignKey("Quiz")]
       public Nullable<int> quiz_idQuiz { get; set; }
        //public quiz Quiz { get; set; }



    }
}
