using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDbPro.Models
{
    class Address
    {
        public int AddressID { get; set; }
        public DateTime AddressFromDate { get; set; }
        public DateTime AdressToDate { get; set; }
        public String AdressStreet { get; set; }
        public String ZipCode { get; set; } //fk
        public int CustomerID { get; set; }//fk
        public String AddressType { get; set; }
    }
}
