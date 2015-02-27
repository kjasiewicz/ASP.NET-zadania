using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using zadanie1.Models;

namespace zadanie1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var root = XElement.Load("http://news.google.pl/news?pz=1&cf=all&ned=pl_pl&hl=pl&output=rss");
            return View(root.Descendants("item").Select(x=>
                new RssItem
                {
                    Description=x.Element("description").Value,
                    Title=x.Element("title").Value
                }).ToList());
        }
        public ActionResult vb()
        {
            var root = XElement.Load("http://news.google.pl/news?pz=1&cf=all&ned=pl_pl&hl=pl&output=rss");
            ViewBag.vb = root.Descendants("item").Select(x =>
                new RssItem
                {
                    Description = x.Element("description").Value,
                    Title = x.Element("title").Value
                }).ToList();
            return View();

        }
    }
}