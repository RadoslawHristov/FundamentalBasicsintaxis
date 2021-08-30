using System;

namespace FundamentalBasicsintaxis
{
    class Program
    {
        static void Main(string[] args)
        {
            int meter = int.Parse(Console.ReadLine());
            float convkm = meter / 1000.0f;
            Console.WriteLine($"{convkm:f2}");
        }
    }
}
