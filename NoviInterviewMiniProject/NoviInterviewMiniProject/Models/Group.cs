using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoviInterviewMiniProject.Models
{
    public class Group
    {
        public string GroupUniqueID { get; set; }
        public string GroupName { get; set; }
        public bool InheritingMember { get; set; }
    }
}