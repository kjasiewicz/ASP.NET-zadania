using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace zadanie1.Models
{
    public class RssItem
    {
        [Display(Name="tytuł")]
        
        public string Title { get; set; }
        [UIHint("html")]
        [Display(Name="opis")]
        public string Description { get; set; }
    }

    public class RssItemMVC
    {
        [Display(Name = "tytuł")]
        public string Title { get; set; }
        [Display(Name = "opis")]
        public MvcHtmlString Description { get; set; }
            
    }
}