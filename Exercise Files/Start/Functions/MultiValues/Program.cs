using System;

namespace MultiValues
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Tuples are grouped values added in C# 7
            (int a, int b) tup1 = (1,2);
            Console.WriteLine($"({tup1.a}, {tup1.b})");


            // TODO: Tuple values are mutable
            tup1.a = 5;
            Console.WriteLine($"({tup1.a}, {tup1.b})");


            // TODO: Functions can work with tuples
            var tup2 = PlusMultiply(tup1.a, tup1.b);
            Console.WriteLine($"({tup2.Item1}, {tup2.Item2})");

        }

        // TODO: Functions can return multiple values using tuples
        static (int, int) PlusMultiply(int a, int b) {
            return (a + b, a * b);
        }

    }
}
