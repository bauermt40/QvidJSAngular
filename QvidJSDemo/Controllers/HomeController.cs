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
            Session["Customers"] = Helper.GetExistingCustomers();

            HomeIndexViewModel model = new HomeIndexViewModel()
            {
                Customers = Session["Customers"] as List<Customer>
            };

            return View(model);
        }

        public JsonResult GetCustomerDetails(int id)
        {
            List<Customer> Customers = Session["Customers"] as List<Customer>;

            var _customer = (from c in Customers
                            where c.Id == id
                            select c).SingleOrDefault();

            return Json(_customer, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpdateCustomerData(Customer customer)
        {
            List<Customer> Customers = Session["Customers"] as List<Customer>;

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

            Session["Customers"] = Customers;

            return Json(model);
        }

        [HttpPost]
        public JsonResult AddNewCustomer(Customer customer)
        {
            List<Customer> Customers = Session["Customers"] as List<Customer>;
            
            var _customer = (from c in Customers
                            orderby c.Id ascending
                            select c).Last();

            int _nextId = _customer.Id + 1;
            customer.Id = _nextId;
            customer.Orders = new List<Order>();

            Customers.Add(customer);

            HomeIndexViewModel model = new HomeIndexViewModel();
            model.Customers = Customers;
            model.ResultMessage = "Customer was added successfully.";

            Session["Customers"] = Customers;

            return Json(model);
        }

        [HttpPost]
        public JsonResult DeleteCustomer(Customer customer)
        {
            List<Customer> Customers = Session["Customers"] as List<Customer>;

            Customers.Remove(customer);

            HomeIndexViewModel model = new HomeIndexViewModel();
            model.Customers = Customers;

            Session["Customers"] = Customers;

            return Json(model);
        }

    }
}
