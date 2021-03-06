﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QvidJSDemo.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public List<Order> Orders { get; set; }
    }
}