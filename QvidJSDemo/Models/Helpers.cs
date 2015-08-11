using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QvidJSDemo.Models
{
    public class Helper
    {
        public static List<Customer> GetExistingCustomers()
        {
            string customersJSON = "[" +
                    "{" +
                        "'Id':'1', 'FirstName':'Mr', 'LastName': 'Orange', 'Address': '1234 Anywhere St.', 'City': 'Phoenix'," +
                        "'Orders': [" +
                            "{ 'Product': 'Webcam', 'Price': '85.99', 'Quantity': '1', 'OrderTotal': '85.99' }," +
                            "{ 'Product': 'HDMI Cable', 'Price': '39.99', 'Quantity': '2', 'OrderTotal': '79.98' }" +
                        "]" +
                    "}," +
                    "{" +
                        "'Id': '2', 'FirstName': 'Mr', 'LastName': 'White', 'Address': '89 W. Center St.', 'City': 'Atlanta'," +
                        "'Orders': [" +
                            "{ 'Product': 'Table', 'Price': '329.99', 'Quantity': '1', 'OrderTotal': '329.99' }," +
                            "{ 'Product': 'Chair', 'Price': '129.99', 'Quantity': '4', 'OrderTotal': '519.96' }," +
                            "{ 'Product': 'Lamp', 'Price': '89.99', 'Quantity': '5', 'OrderTotal': '449.95' }," +
                        "]" +
                    "}," +
                    "{" +
                        "'Id': '3', 'FirstName': 'Mr', 'LastName': 'Blonde', 'Address': '455 7th Ave.', 'City': 'Quebec'," +
                        "'Orders': [" +
                            "{ 'Product': 'Call of Duty', 'Price': '59.99', 'Quantity': '1', 'OrderTotal': '59.99' }," +
                            "{ 'Product': 'Controller', 'Price': '49.99', 'Quantity': '1', 'OrderTotal': '49.99' }" +
                        "]" +
                    "}," +
                    "{" +
                        "'Id': '4', 'FirstName': 'Mr', 'LastName': 'Pink', 'Address': '8966 N. Crescent Dr.', 'City': 'New York City'," +
                        "'Orders': [" +
                            "{ 'Product': 'Baseball', 'Price': '9.99', 'Quantity': '5', 'OrderTotal': '49.95' }," +
                            "{ 'Product': 'Bat', 'Price': '19.99', 'Quantity': '1', 'OrderTotal': '19.99' }" +
                        "]" +
                    "}," +
                    "{" +
                        "'Id': '4', 'FirstName': 'Mr', 'LastName': 'Blue', 'Address': '8966 N. Crescent Dr.', 'City': 'New York City'," +
                        "'Orders': [" +
                            "{ 'Product': 'Gears of War', 'Price': '49.99', 'Quantity': '1', 'OrderTotal': '49.99' }," +
                            "{ 'Product': 'Lego City', 'Price': '49.99', 'Quantity': '1', 'OrderTotal': '49.99' }" +
                        "]" +
                    "}" +
            "]";

            List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(customersJSON);

            return customers;
        }
    }
}