using System;
using System.Collections;

namespace Snippet_9
{
    class Employee : DictionaryBase
    {
        public void Add(int id, string name)
        {
            Dictionary.Add(id, name);
        }
        public void OnRemove(int id)
        {
            Console.WriteLine("You are going to delete record containing ID: " + id);
            Dictionary.Remove(id);
        }
        public void GetDetails()
        {
            IDictionaryEnumerator objEnumerate = Dictionary.GetEnumerator();
            while (objEnumerate.MoveNext())
            {
                Console.WriteLine(objEnumerate.Key.ToString() + "\t\t" + objEnumerate.Value);
            }
        }
        static void Main(string[] args)
        {
            Employee objEmp = new Employee();
            objEmp.Add(99, "Neo");
            objEmp.Add(105, "James");
            objEmp.Add(106, "Peter");
            Console.WriteLine("Original values stored in Dictionary");
            objEmp.GetDetails();
            objEmp.OnRemove(106);
            Console.WriteLine("Modified values stored in Dictionary");
            objEmp.GetDetails();
        }
    }
}
