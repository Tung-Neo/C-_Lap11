using System;

namespace AP_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Divide(2, 0);
        }
        static int Divide(int first, int second)
        {
            int result = 0;
            try
            {
                int result = first / second;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero, please provide a non-zero value for your second value");
            }
            return result;
        }
    }
}
