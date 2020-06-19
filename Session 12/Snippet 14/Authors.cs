using System;
using System.Collections;

namespace Snippet_14
{
    class Authors
    {
        static void Main(string[] args)
        {
            Hashtable objAuthors = new Hashtable();
            objAuthors.Add("AU01", "John");
            objAuthors.Add("AU04", "Mary");
            objAuthors.Add("AU09", "William");
            objAuthors.Add("AU11", "Rodrick");
            Console.WriteLine("Read - only: " + objAuthors.IsReadOnly);
            Console.WriteLine("Count: " + objAuthors.Count);
            IDictionaryEnumerator objCollection = objAuthors.GetEnumerator();
            Console.WriteLine("List of authors: \n");
            Console.WriteLine("Author ID \t Name");
            while (objCollection.MoveNext())
            {
                Console.WriteLine(objCollection.Key + "\t\t" + objCollection.Value);
            }
            if (objAuthors.Contains("AU01"))
            {
                Console.WriteLine("\nList contains author with id AU01");
            }
            else
            {
                Console.WriteLine("\nList does not contain author with id AU01");
            }
        }
    }
}
