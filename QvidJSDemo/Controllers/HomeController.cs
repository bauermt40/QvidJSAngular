using QvidJSDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QvidJSDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            HomeIndexViewModel model = new HomeIndexViewModel()
            {
                Customers = Helper.GetExistingCustomers()
            };

            return View(model);
        }

    }
}
