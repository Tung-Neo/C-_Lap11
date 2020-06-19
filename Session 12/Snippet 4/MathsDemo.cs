using System;

namespace Snippet_4
{
    public delegate void Maths(int valOne, int valTwo);
    class MathsDemo
    {
        static void Addition(int valOne, int valTwo)
        {
            int result = valOne + valTwo;
            Console.WriteLine("Addition: " + valOne + " + " + valTwo + " = " + result);
        }
        static void Subtraction(int valOne, int valTwo)
        {
            int result = valOne - valTwo;
            Console.WriteLine("Subtraction: " + valOne + " - " + valTwo + " = " + result);
        }
        static void Multiplication(int valOne, int valTwo)
        {
            int result = valOne * valTwo;
            Console.WriteLine("Multiplication: " + valOne + " * " + valTwo + " = " + result);
        }
        static void Division(int valOne, int valTwo)
        {
            int result = valOne / valTwo;
            Console.WriteLine("Division: " + valOne + " / " + valTwo + " = " + result);
        }
        static void Main(string[] args)
        {
            Maths objMath = new Maths(Addition);
            objMath += new Maths(Subtraction);
            objMath += new Maths(Multiplication);
            objMath += new Maths(Division);
            if(objMath != null)
            {
                objMath(20, 10);
            }
        }
    }
}
