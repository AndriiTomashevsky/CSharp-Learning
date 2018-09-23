using System;

namespace SimpleCSharpApp
{
    class Program
    {
        // Notice you have no need to check the size of the array when using "foreach".
        static int Main(string[] args)
        {
            // Display a message and wait for Enter key to be pressed.
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            // Get arguments using System.Environment.
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
                Console.WriteLine("Arg: {0}", arg);

            Console.ReadLine();
            return -1;
        }
    }
}
