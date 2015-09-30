using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDbPro.Models
{
    class OrderedProduct
    {
        public int OrderedProductID { get; set; }
        public int ProductID { get; set; } //fk
        public String ProductName { get; set; }
        public String ProductDescription { get; set; }
        public String ProductPrice { get; set; }
        public int Quantity { get; set; }
        public int OrderID { get; set; }//fk


    }
}
