using Entity_Framework_example.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Entity_Framework_example
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            Database.SetInitializer(new BazaDanychDbContext.BazaDanychInitializer());
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
