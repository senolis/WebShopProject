using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDbPro.Models
{
    class ProductSpecification
    {
        public int PromotionCode { get; set; }
        public int ProductID { get; set; } //fk
        public String NewProductPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
