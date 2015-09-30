using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public String ProductDescription { get; set; }
        public String ProductPrice { get; set; }
        public String ProductURL { get; set; }
        public DateTime ProductDateAvailable { get; set; }
        public DateTime ProductChangeDate { get; set; }
        public int Manufacturer { get; set; }//fk

        
    }
}