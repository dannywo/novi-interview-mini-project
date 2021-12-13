using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoviInterviewMiniProject.Models
{
    public class Membertype
    {
        public string UniqueID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool ForCompanies { get; set; }
    }
}