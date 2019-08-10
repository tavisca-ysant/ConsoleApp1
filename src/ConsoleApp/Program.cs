using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var A = 10;
            var B = 20;
            var C = Add(A, B);
            Console.WriteLine($"{A} + {B}  is {C}");
        }

        public static object Add(int a, int b)
        {
            return a + b;
        }
    }
}
