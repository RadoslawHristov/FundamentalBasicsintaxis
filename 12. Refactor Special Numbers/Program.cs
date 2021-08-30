using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int secondch = 0;
            bool isspecial = false;
            for (int ch = 1; ch <= num; ch++)
            {
                secondch = ch;
                while (ch > 0)
                {
                    sum += ch % 10;
                    ch = ch / 10;
                }
                isspecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{secondch} -> {isspecial}");
            }
        }
    }
}
