using System;

namespace RefAndOutParams {
    class Program {
        // TODO: Ordinary value arguments cannot be modified by the function
        // because they are a copy of the original value
        static void TestFunc1(int arg1) {

            Console.WriteLine($"{arg1 * 2}");
        }

        // TODO: Arguments that are passed by reference can be modified
        // by the function and reflected back to the caller
        static void TestFunc2(ref int arg1) {
            arg1 *= 2;
        }


        // TODO: The "out" keyword means that the parameter returns a value and is not
        // used to supply data to the function
        static void AddAndMultiply(int a, int b, out int sum, out int product) {
            sum = a + b;
            product = a * b;
        }


        static void Main(string[] args) {
            int val1 = 10;
            int val2 = 20;

            // Functions don't normally modify value arguments
            TestFunc1(val1);
            TestFunc2(ref val1);
            Console.WriteLine($"{val1}");

            // TODO: Using the "ref" keyword, arguments can be passed by reference
            // which allows the function to modify them


            // TODO: The "out" keyword can be used to indicate that an argument
            // is intended to return a value and is not an input
            int result1, result2;
            AddAndMultiply(val1, val2, out result1, out result2);
            Console.WriteLine($"Sum is {result1}. Product is {result2}.");
        }

       
    }
}
