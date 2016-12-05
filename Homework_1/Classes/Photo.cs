using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_1.Classes
{
    public class Photo
    {
        public string id { get; set; }
        public string owner { get; set; }
        public string secret { get; set; }
        public string server { get; set; }
        public string farm { get; set; }
        public string title { get; set; }
        public string ispublic { get; set; }
        public string isfriend { get; set; }
        public string isfamily { get; set; }
    }
}