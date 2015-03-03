using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace zadanie1.Controllers
{
    [RoutePrefix("default")]
    [Route("{action=index}")]
    public class DefaultController : Controller
    {
        [Route("")]
        [Route("~/")]
        [Route("~/nieobchodzimnierouting")]
        // GET: Default
        [Route("Index")]
        public ActionResult Index()
        {
            
            return View();
        }
    }
}