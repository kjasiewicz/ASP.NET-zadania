using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zaj04.Models
{
    public class Conference
    {
        public int Id { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorMail { get; set; }

        public string ArticleTitle { get; set; }
        public string ArticleAbstract { get; set; }
    }
}