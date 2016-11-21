using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class notification
    {
        public int idNotification { get; set; }
        public string content { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> customer_idUser { get; set; }
        public Nullable<int> reviewer_idUser { get; set; }
    }
}
