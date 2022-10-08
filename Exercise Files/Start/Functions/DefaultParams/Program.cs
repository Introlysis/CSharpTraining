using System;

class Program
{
    // TODO: Functions can provide default values for their parameters
    static void PrintWithPrefix(string thestr, string prefix="")
    {
        Console.WriteLine($"{prefix} {thestr}");
    }
    static void Main(string[] args)
    {

        // TODO: Test the default parameters
        PrintWithPrefix(thestr: "Test str", prefix:">");


        // TODO: Call with named params
    }
}
