using QvidJSDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QvidJSDemo.Models
{
    public class OrdersIndexViewModel
    {
        public string CustomerName { get; set; }
        public List<Order> Orders { get; set; }

        public OrdersIndexViewModel()
        {
            Orders = new List<Order>();
        }
    }
}