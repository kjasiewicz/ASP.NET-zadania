using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace zaj04.ViewModel
{
    public class ConferenceViewModel
    {
        [Required]
        public string AuthorFirstName { get; set; }
        [Required]
        public string AuthorLastName { get; set; }
        [Required, EmailAddress]
        public string AuthorMail { get; set; }
        [Required]
        public string ArticleTitle { get; set; }
        [Required]
        public string ArticleAbstract { get; set; }
    }
}