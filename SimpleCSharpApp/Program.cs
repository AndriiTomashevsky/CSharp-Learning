using System;

namespace SimpleCSharpApp
{
    class Program
    {
        // Note we are now returning an int, rather than void.
        static int Main(string[] args)
        {
            // Display a message and wait for Enter key to be pressed.
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            // Process any incoming args.
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine("Arg: {0}", args[i]);

            Console.ReadLine();
            return -1;
        }
    }
}
