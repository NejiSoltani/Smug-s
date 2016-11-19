using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class product
    {
        public int idProduct { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public string photo { get; set; }
        public Nullable<float> price { get; set; }
        public int score { get; set; }
        public Nullable<int> category_idCategory { get; set; }
    }
}
