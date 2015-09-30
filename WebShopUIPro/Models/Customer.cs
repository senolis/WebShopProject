using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class Customer
    {

        public int CustomerID { get; set; }
        public String CustomerGender { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String BirthDate { get; set; }
        public String CustomerEmail { get; set; }
        public String CustomerPhone { get; set; }
       // public String Password { get; set; }
    }
}