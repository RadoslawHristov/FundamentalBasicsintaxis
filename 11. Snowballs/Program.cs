using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger bigestball = 0;
            int largeball = 0;
            int largeTime = 0;
            int largeQuality = 0;
            for (int i = 0; i < input; i++)
            {
                int snowball = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());

                BigInteger volue =BigInteger.Pow(snowball / snowballTime,snowBallQuality);


                if (volue > bigestball)
                {
                    bigestball = volue;
                    largeball = snowball;
                    largeTime = snowballTime;
                    largeQuality = snowBallQuality;
                }
            }

            Console.WriteLine($"{largeball} : {largeTime} = {bigestball} ({largeQuality})");
        }
    }
}
