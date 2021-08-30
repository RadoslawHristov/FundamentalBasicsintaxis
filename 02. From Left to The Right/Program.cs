using System;
using System.Linq;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < input; i++)
            {
                string numbers = Console.ReadLine();
                string[] splitnumber = numbers.Split(' ');

                long leftnum = long.Parse(splitnumber[0]);
                long rightnum = long.Parse(splitnumber[1]);


                long biggernumber = rightnum;
                if (leftnum > rightnum)
                {
                    biggernumber = leftnum;
                }

                long sum = 0;
                while (biggernumber !=0)
                {
                    sum += biggernumber % 10;
                    biggernumber /= 10;
                }

                Console.WriteLine($"{Math.Abs(sum)}");
            }
        }
    }
}
