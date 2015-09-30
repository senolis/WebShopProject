using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Models;

namespace WebShopDbPro.Models
{
    class CategoryProduct
    {
        public int ProductID { get; set; } //fk
        public int CategoryID { get; set; } //fk

        //public ICollection<Product> Products { get; set; }
    }
}
