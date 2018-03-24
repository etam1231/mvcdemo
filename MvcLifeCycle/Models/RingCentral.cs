using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLifeCycle.Models
{   
    public class RingCentral
    {    
        public string username { get; set; }
        public string grant_type { get; set; }
        public string password { get; set; }
        public string extension { get; set; }

    }
}