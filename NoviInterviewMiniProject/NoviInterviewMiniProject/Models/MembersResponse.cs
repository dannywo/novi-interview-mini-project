using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoviInterviewMiniProject.Models
{
        public class MembersResponse
        {
            public int TotalCount { get; set; }
            public MemberResult[] Results { get; set; }
        }
}