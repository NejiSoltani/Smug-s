using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class idea
    {
        public int idIdea { get; set; }
        public string content { get; set; }
        public Nullable<System.DateTime> dateDepot { get; set; }
        public string statut { get; set; }
        public string subject { get; set; }
        public Nullable<int> customer_idUser { get; set; }
        public Nullable<int> manager_idUser { get; set; }
        public Nullable<int> reviewer_idUser { get; set; }
        public Nullable<int> manager1_idUser { get; set; }
    }
}
