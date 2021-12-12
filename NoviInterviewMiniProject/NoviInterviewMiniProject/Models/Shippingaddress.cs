using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoviInterviewMiniProject.Models
{
    public class Shippingaddress
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string StateProvince { get; set; }
        public object Country { get; set; }
    }
}