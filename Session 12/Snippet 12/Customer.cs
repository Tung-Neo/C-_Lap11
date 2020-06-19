using System;
using System.Collections;

namespace Snippet_12
{
    class Customer
    {
        static void Main(string[] args)
        {
            ArrayList objCustomer = new ArrayList();
            objCustomer.Add("Nicole Anderson");
            objCustomer.Add("Ashley Thomas");
            objCustomer.Add("Garry White");
            Console.WriteLine("Fixed Size: " + objCustomer.IsFixedSize);
            Console.WriteLine("Count: " + objCustomer.Count);
            Console.WriteLine("List of customers: ");
            foreach(string names in objCustomer)
            {
                Console.WriteLine("{0}", names);
            }
            objCustomer.Sort();
            Console.WriteLine("\nList of customer after sorting: ");
            foreach(string names in objCustomer)
            {
                Console.WriteLine("{0}", names);
            }
            objCustomer.Clear();
            Console.WriteLine("Count after removing all elements: " + objCustomer.Count);
        }
    }
}
