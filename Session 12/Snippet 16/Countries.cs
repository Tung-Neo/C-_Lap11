﻿using System;
using System.Collections;

namespace Snippet_16
{
    class Countries
    {
        static void Main(string[] args)
        {
            SortedList objCountries = new SortedList();
            objCountries.Add("UK", "United Kingdom");
            objCountries.Add("GER", "Germany");
            objCountries.Add("USA", "United States of America");
            objCountries.Add("AUS", "Australia");
            Console.WriteLine("Read-only: " + objCountries.IsReadOnly);
            Console.WriteLine("Count: " + objCountries.Count);
            Console.WriteLine("List of countriews: \n");
            Console.WriteLine("Country Code \t Name");
            for(int i = 0; i < objCountries.Count; i++)
            {
                Console.WriteLine(objCountries.GetKey(i) + "\t\t" + objCountries.GetByIndex(i));
            }
            objCountries.RemoveAt(1);
            Console.WriteLine("\nList of countries after removing element at index 1: \n");
            Console.WriteLine("CountryCode \t Name");
            for(int i = 0; i < objCountries.Count; i++)
            {
                Console.WriteLine(objCountries.GetKey(i) + "\t\t" + objCountries.GetByIndex(i));
            }
        }
    }
}
