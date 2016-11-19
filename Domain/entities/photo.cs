using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class photo
    {
        public int idPhoto { get; set; }
        public string Picture { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string description { get; set; }
        public Nullable<int> customer_idUser { get; set; }
        public Nullable<int> manager_idUser { get; set; }
    }
}
