using QvidJSDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QvidJSDemo.Controllers
{
    public class InvoicesController : Controller
    {
        //
        // GET: /Orders/

        public ActionResult Index()
        {
            InvoicesIndexViewModel model = new InvoicesIndexViewModel();

            List<Customer> Customers = Helper.GetExistingCustomers();
            List<Invoice> Invoices = new List<Invoice>();
            foreach (Customer c in Customers)
            {
                Invoice newInvoice = new Invoice();
                newInvoice.CustomerName = c.FirstName + " " + c.LastName;
                foreach (Order o in c.Orders)
                {
                    newInvoice.TotalQuantity += o.Quantity;
                    newInvoice.TotalOrdered += o.OrderTotal;
                }

                Invoices.Add(newInvoice);
            }
            model.Invoices = Invoices;

            return View(model);
        }

    }
}
