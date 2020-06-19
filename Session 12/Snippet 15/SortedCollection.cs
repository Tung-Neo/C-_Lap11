using System;
using System.Collections;

namespace Snippet_15
{
    class SortedCollection
    {
        static void Main(string[] args)
        {
            SortedList objSortList = new SortedList();
            objSortList.Add("John", "Administration");
            objSortList.Add("Jack", "Human Resources");
            objSortList.Add("Peter", "Finance");
            objSortList.Add("Joel", "Marketing");
            Console.WriteLine("Original values stored in the sorted list");
            Console.WriteLine("Key \t\t Values");
            for(int i = 0; i < objSortList.Count; i++)
            {
                Console.WriteLine(objSortList.GetKey(i) + "\t\t" + objSortList.GetByIndex(i));
            }
            if (!objSortList.ContainsKey("Jerry"))
            {
                objSortList.Add("Jerry", "Construction");
            }
            objSortList["Peter"] = "Engineering";
            objSortList["Jerry"] = "Information Technology";
            Console.WriteLine();
            Console.WriteLine("Updated values stored in hashtable");
            Console.WriteLine("Key \t\t Values");
            for (int i = 0; i < objSortList.Count; i++)
            {
                Console.WriteLine(objSortList.GetKey(i) + "\t\t" + objSortList.GetByIndex(i));
            }
        }
    }
}
