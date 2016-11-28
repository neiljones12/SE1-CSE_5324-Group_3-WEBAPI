using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace diy_helper.Models
{
    public class project
    {
        public string id { get; set; }
        public string createdById { get; set; }
        public string title { get; set; }
        public bool isDelete { get; set; }
        public string classValue { get; set; }
        public string difficulty { get; set; }
        public string time { get; set; }
        public string cost { get; set; }
        public string youtube { get; set; }
        public string description { get; set; }
        public bool isActive { get; set; }
        public string progress { get; set; }
        public requirements requirements { get; set; }
        public Instructions Instructions { get; set; }

    }

    public class requirements
    {
        public string name { get; set; }
        public bool ischecked { get; set; }
        public bool add { get; set; }
    }
    public class Instructions
    {
        public string step { get; set; }
        public bool ischecked { get; set; }
        public bool add { get; set; } 

    }
}
