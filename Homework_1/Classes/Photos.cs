using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_1.Classes
{
    public class Photos
    {
        public string page { get; set; }
        public string pages { get; set; }
        public string perpage { get; set; }
        public string total { get; set; }
        public string stat { get; set; }
        public Photo[] photo { get; set; }
    }
}