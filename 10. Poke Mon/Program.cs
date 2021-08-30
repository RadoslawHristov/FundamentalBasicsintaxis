using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int result = N / 2;
            int pokcount = 0;
            while (N >= M)
            {
                N -= M;
                if (result==N && Y > 0)
                {
                    N /= Y;
                }
                pokcount++;
            }

            Console.WriteLine(N);
            Console.WriteLine(pokcount);
        }
    }
}
