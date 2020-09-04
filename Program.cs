using System;

namespace examplerepo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am Danish");
            AddNumbers(10, 2);
        }

        static void AddNumbers(int x, int y)
        {
            Console.WriteLine("The sum is " + (x + y));
        }
    }
}
