using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            Char.ToString(first);
            Char.ToString(second);
            Char.ToString(third);
            Console.WriteLine($"{first}{second}{third}");
        }
    }
}
