using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLifeCycle.Models
{
    public static class StringHelperClass
    {      
        public static string ConverttoUpperLetterCase(this string String)
       {
          return  String.ToUpper();
       }
    }
}