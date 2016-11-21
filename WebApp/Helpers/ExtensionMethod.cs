using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Helpers
{
    public static class ExtensionMethod
    {
        public static IEnumerable<SelectListItem>
            ToSelectListItems(this IEnumerable<quiz> numReal)
        {
            return numReal.OrderBy(c => c.idQuiz).Select(r =>
                   new SelectListItem
                   {
                    
                       Text = r.title,
                         Value = r.idQuiz.ToString()
                   }

            );
        }
    }
}