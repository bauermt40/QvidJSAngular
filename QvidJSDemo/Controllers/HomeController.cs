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

        public JsonResult GetCustomerDetails(int id)
        {
            List<Customer> Customers = Helper.GetExistingCustomers();
            var _customer = (from c in Customers
                            where c.Id == id
                            select c).SingleOrDefault();

            return Json(_customer, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpdateCustomerData(Customer customer)
        {
            List<Customer> Customers = Helper.GetExistingCustomers();
            var _customer = (from c in Customers
                            where c.Id == customer.Id
                            select c).SingleOrDefault();

            _customer.FirstName = customer.FirstName;
            _customer.LastName = customer.LastName;
            _customer.Address = customer.Address;
            _customer.City = customer.City;

            HomeIndexViewModel model = new HomeIndexViewModel();
            model.Customers = Customers;
            model.ResultMessage = "Customer was updated successfully.";

            return Json(model);
        }

    }
}
