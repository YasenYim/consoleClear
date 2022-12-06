using System;

namespace consoleClear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            Console.WriteLine("Press any key to clear the screen.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("The screen has been cleared.");
        }
    }
}
