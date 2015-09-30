using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public String CategoryName { get; set; }
        public String CategoryImage { get; set; }
        public String CategorySortOrder { get; set; }
        public int ParentCategory { get; set; } //fk

    }
}