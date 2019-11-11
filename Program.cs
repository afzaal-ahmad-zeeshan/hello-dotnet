using System;
using Sentry;

namespace hello_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Sum of 2 and 2 is {Arithmetic.Add(2, 2)}.");
        }
    }
}
