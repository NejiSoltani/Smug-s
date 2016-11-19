using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class shop
    {
        public int idShop { get; set; }
        public string address { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public string name { get; set; }
        public int phone { get; set; }
        public string photo { get; set; }
        public float score { get; set; }
        public Nullable<int> category_idCategory { get; set; }
    }
}
