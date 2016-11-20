using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class comment
    {
        public int idComment { get; set; }
        public string content { get; set; }
        public bool reported { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> customer_idUser { get; set; }
        public Nullable<int> idea_idIdea { get; set; }
        public Nullable<int> manager_idUser { get; set; }
        public Nullable<int> photo_idPhoto { get; set; }

    }
}
