using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class reservation
    {
        public int idReservation { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string description { get; set; }
        public int number { get; set; }
        public Nullable<int> customer_idUser { get; set; }
        public Nullable<int> shop_idShop { get; set; }
    }
}
