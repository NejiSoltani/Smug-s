using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class prize
    {
        public int idPrize { get; set; }
        public string description { get; set; }
        public Nullable<int> customer_idUser { get; set; }
        public Nullable<int> reviewer_idUser { get; set; }
    }
}
