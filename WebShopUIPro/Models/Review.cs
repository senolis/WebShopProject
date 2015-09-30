using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDbPro.Models
{
    class Review
    {
        public int ReviewID { get; set; }
        public String ReviewRating { get; set; }
        public String ReviewText { get; set; }
        public int Reviewer { get; set; }//fk
        public int ProductID { get; set; }//fk
    }
}
