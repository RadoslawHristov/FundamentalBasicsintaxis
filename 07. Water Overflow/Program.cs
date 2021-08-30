using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numliter = int.Parse(Console.ReadLine());
            int sumLiter = 0;
            int tank = 255;

            while (numliter > 0)
            {
                int curentLiter = int.Parse(Console.ReadLine());

                if (sumLiter + curentLiter > tank)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sumLiter += curentLiter;
                }
                numliter--;
            }

            Console.WriteLine(sumLiter);
        }
    }
}
