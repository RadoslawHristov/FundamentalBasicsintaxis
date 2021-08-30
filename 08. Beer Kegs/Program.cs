using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int nummodel = int.Parse(Console.ReadLine());
            string bigkeg=String.Empty;
            double curentkeg = 0;

            for (int i = 0; i < nummodel; i++)
            {
                string modelkeg = Console.ReadLine();
                double radiuskeg = double.Parse(Console.ReadLine());
                double heightkeg = double.Parse(Console.ReadLine());

                double maxkeg = Math.PI*radiuskeg* radiuskeg* heightkeg;
                
                if (maxkeg > curentkeg)
                {
                    curentkeg = maxkeg;
                    bigkeg = modelkeg;
                }
            }
            Console.WriteLine(bigkeg);
        }
    }
}
