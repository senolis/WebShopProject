using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDbPro.Models
{
    class BasketProduct
    {
        public int BasketID { get; set; }//fk
        public int ProductID { get; set; }//fk
        public int Quantity { get; set; }
    }
}
