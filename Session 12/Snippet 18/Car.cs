using System;
using System.Collections;
using System.Collections.Generic;

namespace Snippet_18
{
    class Car
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> objDictionary = new Dictionary<int, string>();
            objDictionary.Add(201, "Gear Box");
            objDictionary.Add(220, "Oil Filter");
            objDictionary.Add(330, "Engine");
            objDictionary.Add(305, "Radiator");
            objDictionary.Add(303, "Steering");
            Console.WriteLine("Dictionary class contains values of type");
            Console.WriteLine(objDictionary.GetType());
            Console.WriteLine("Key \t\t Values");
            Console.WriteLine("______________________");
            IDictionaryEnumerator objDictionaryEnumerrator = objDictionary.GetEnumerator();
            while (objDictionaryEnumerrator.MoveNext())
            {
                Console.WriteLine(objDictionaryEnumerrator.Key.ToString() + "\t\t" + objDictionaryEnumerrator.Value);
            }
        }
    }
}
