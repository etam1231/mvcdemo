﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLifeCycle.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public string DepartmentName { get; set; }
    }
}