using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yeld = int.Parse(Console.ReadLine());
            int total = 0;
            int day = 0;
            while (yeld >= 100)
            {
                total += yeld-26;
                day++;
                yeld -= 10;
            }

            if (day > 0)
            {
                total -= 26;
            }
            
            Console.WriteLine(day);
            Console.WriteLine(total);
        }
    }
}
