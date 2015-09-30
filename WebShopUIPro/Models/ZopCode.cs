using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopDbPro.Models
{
    class ZopCode
    {
        public String ZipCode { get; set; }
        public int CityID { get; set; }//fk
        public String CountryCode { get; set; }//fk
        public String StateOrProvince { get; set; }//fk

    }
}
