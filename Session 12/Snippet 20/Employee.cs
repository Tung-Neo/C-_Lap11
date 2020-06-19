using System;
using System.Collections.Generic;

namespace Snippet_20
{
    class Employee
    {
        public String Name { get; set; }
        public String Designation { get; set; }
    }
    class CollectionInitializerDemo
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> dict = new Dictionary<int, Employee>()
            {
                {1, new Employee {Name = "Andy Parkere", Designation = "Sales Person"} },
                {2, new Employee {Name = "Patrick Elvis", Designation = "Marketing Manager"} }
            };
        }
    }
}
