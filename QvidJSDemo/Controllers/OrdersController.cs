using QvidJSDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QvidJSDemo.Controllers
{
    public class OrdersController : Controller
    {
        //
        // GET: /Orders/

        public ActionResult Index(int id)
        {
            List<Customer> Customers = Helper.GetExistingCustomers();
            OrdersIndexViewModel model = new OrdersIndexViewModel();
            if (id != null)
            {
                var customer = (from c in Customers
                                where c.Id == id
                                select c).SingleOrDefault();


                if (customer != null)
                {
                    model.CustomerName = customer.FirstName + " " + customer.LastName;
                    model.Orders = customer.Orders;
                }
            }
            
            return View(model);
        }

    }
}
