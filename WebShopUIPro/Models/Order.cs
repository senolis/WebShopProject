using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerID { get; set; }//fk
        public String Referece { get; set; }
        public String BilingName { get; set; }
        public String  DeliveryName { get; set; }
        public String EmailAddress { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int OrderStatusCode { get; set; } //fk
        public int BilingAddressID { get; set; } //fk
        public int DeliveryAddressID  { get; set; } //fk
       
    }
}