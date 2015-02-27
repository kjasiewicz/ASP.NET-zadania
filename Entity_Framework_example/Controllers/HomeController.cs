using Entity_Framework_example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Entity_Framework_example.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (var context = new BazaDanychDbContext())
            {
                var k = context.Student.FirstOrDefault(n =>
                    n.Imie == "Katarzyna").Imie;
                ViewBag.Imie = k;
            }
            return View();
        }
    }
}