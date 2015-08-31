using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QvidJSDemo.Models
{
    public class Invoice
    {
        public string CustomerName { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalOrdered { get; set; }
    }
}