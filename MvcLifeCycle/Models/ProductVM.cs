using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcLifeCycle.Entity;

namespace MvcLifeCycle
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public  decimal Price { get; set; }

        public static explicit operator ProductVM(Product v)
        {
            throw new NotImplementedException();
        }
    }
}