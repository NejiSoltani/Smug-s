using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class category_user
    {
        public int categories_idCategory { get; set; }
        public int customers_idUser { get; set; }
    }
}
