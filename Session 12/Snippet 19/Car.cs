using System;
using System.Collections;

namespace Snippet_19
{
    class Car
    {
        static void Main(string[] args)
        {
            ArrayList nums = new ArrayList { 1, 2, 3 * 6, 4, 5 };
            foreach(int num in nums)
            {
                Console.WriteLine("{0}", num);
            }
        }
    }
}
