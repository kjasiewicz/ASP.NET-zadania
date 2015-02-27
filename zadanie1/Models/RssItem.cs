using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
}