using System;
using System.Collections;

namespace Snippet_11
{
    class ArrayCollection
    {
        static void Main(string[] args)
        {
            ArrayList objArray = new ArrayList();
            objArray.Add("Neo");
            objArray.Add("James");
            objArray.Add("Peter");
            objArray.RemoveAt(2);
            objArray.Insert(2, "Williams");
            Console.WriteLine("Capacity: " + objArray.Capacity);
            Console.WriteLine("Count: " + objArray.Count);
            Console.WriteLine();
            Console.WriteLine("Elements of the ArrayList");
            foreach(string str in objArray)
            {
                Console.WriteLine(str);
            }
        }
    }
}
