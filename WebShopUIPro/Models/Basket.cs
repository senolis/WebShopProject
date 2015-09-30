using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDbPro.Models
{
    class Basket
    {
        public int BasketID { get; set; }
        public int CustomerID { get; set; }//fk
        public DateTime BasketDateAdded { get; set; }
        public String BasketStatusCode { get; set; }//fk

    }
}
