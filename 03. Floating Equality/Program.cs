using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;
            double numberA = 0.0;
            double numberB = 0.0;

            while (true)
            {
                 numberA = double.Parse(Console.ReadLine());
                 numberB = double.Parse(Console.ReadLine());
                bool isequal = Math.Abs(numberA - numberB) < eps;
                if (isequal)
                {
                    Console.WriteLine("True");
                    return;
                }
                else
                {
                    Console.WriteLine("False");
                    return;
                }
            }

        }
    }
}
