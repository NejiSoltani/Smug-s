using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class ideareviewer
    {
        public int idUser { get; set; }
        public bool ban { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public string gender { get; set; }
        public Nullable<System.DateTime> inscriptionDate { get; set; }
        public string lastName { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int tel { get; set; }
        public int idReviewer { get; set; }
        public Nullable<int> manager_idUser { get; set; }
    }
}
