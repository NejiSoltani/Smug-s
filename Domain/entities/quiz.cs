using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class quiz
    {
        public int idQuiz { get; set; }
        public string title { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public int score { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<int> customer_idUser { get; set; }
        public Nullable<int> reviewer_idUser { get; set; }
        //public ICollection<question> Questions { get; set; }


    }
}
