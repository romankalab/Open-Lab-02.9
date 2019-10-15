using System;

namespace Open_Lab_02._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your first name:");
            string first = Console.ReadLine();

            Console.WriteLine("Type your last name:");
            string last = Console.ReadLine();

            string fullname = ConcatName(first, last);

            Console.WriteLine($"This is your full name: {fullname}");
        }
        private static string ConcatName(string first, string last)
        {
            return last + ", " + first;
        }
    }
}
