using System;
using System.Collections;
using System.Collections.Generic;

namespace Snippet_10
{
    class Student : IEnumerable
    {
        LinkedList<string> objList = new LinkedList<string>();
        public void StudentDetails()
        {
            objList.AddFirst("James");
            objList.AddFirst("John");
            objList.AddFirst("Patrick");
            objList.AddFirst("James");
            objList.AddFirst("Neo");
            Console.WriteLine("Number of elements stored in the list: " + objList.Count);
        }
        public void Display(string name)
        {
            LinkedListNode<string> objNode;
            int count = 0;
            for(objNode = objList.First; objNode != null; objNode = objNode.Next)
            {
                if (objNode.Value.Equals(name))
                {
                    count++;
                }
            }
            Console.WriteLine("The value " + name + " appears " + count + " times in the list");
        }
        public IEnumerator GetEnumerator()
        {
            return objList.GetEnumerator();
        }
        static void Main(string[] args)
        {
            Student objStu = new Student();
            objStu.StudentDetails();
            foreach (string str in objStu)
            {
                Console.WriteLine(str);
            }
            objStu.Display("James");
        }
    }
}
