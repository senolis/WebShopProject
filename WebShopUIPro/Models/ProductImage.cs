using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDbPro.Models
{
    class ProductImage
    {
        public int ProductID { get; set; }
        public String Image { get; set; }
        public String HTMLContent { get; set; }
        public String ImageSortOrder { get; set; }
    }
}
