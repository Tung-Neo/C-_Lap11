using System;
using System.Collections;
using System.Collections.Generic;

namespace Snippet_17
{
    class DictionaryCollection
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> objDictionary = new Dictionary<int, string>();
            objDictionary.Add(25, "Hard Disk");
            objDictionary.Add(30, "Processor");
            objDictionary.Add(15, "MotherBoard");
            objDictionary.Add(65, "Memory");
            ICollection objCollect = objDictionary.Keys;
            Console.WriteLine("Original values stored in the collection");
            Console.WriteLine("Keys \t Values");
            Console.WriteLine("-----------------");
            foreach(int i in objCollect)
            {
                Console.WriteLine(i + "\t" + objDictionary[i]);
            }
            objDictionary.Remove(65);
            Console.WriteLine();
            if (objDictionary.ContainsValue("Memory"))
            {
                Console.WriteLine("Value Memory could not be delated");
            }
            else
            {
                Console.WriteLine("Value Memory deleted successfully");
            }
            Console.WriteLine();
            Console.WriteLine("Values stored after removing element");
            Console.WriteLine("Key \t Values");
            Console.WriteLine("------------------");
            foreach(int i in objCollect)
            {
                Console.WriteLine(i + "\t" + objDictionary[i]);
            }
        }
    }
}
