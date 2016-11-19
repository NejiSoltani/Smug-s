using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class reclamation
    {
        public int idReclamation { get; set; }
        public string content { get; set; }
        public Nullable<System.DateTime> dateReclamation { get; set; }
        public string subject { get; set; }
        public Nullable<int> customer_idUser { get; set; }
        public Nullable<int> manager_idUser { get; set; }
        public string type { get; set; }
    }
}
