using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public partial class notification
    {
        [Key]
        public int idNotification { get; set; }
        public string content { get; set; }
        public Nullable<System.DateTime> date { get; set; }

        [ForeignKey("customer_idUser")]
        public virtual customer customer { get; set; }
        public Nullable<int> customer_idUser { get; set; }
        public Nullable<int> reviewer_idUser { get; set; }
    }
}
