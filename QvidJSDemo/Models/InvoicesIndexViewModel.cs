using QvidJSDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QvidJSDemo.Models
{
    public class InvoicesIndexViewModel
    {
        public List<Invoice> Invoices { get; set; }

        public InvoicesIndexViewModel()
        {
            Invoices = new List<Invoice>();
        }
    }
}