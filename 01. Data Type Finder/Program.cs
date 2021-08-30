using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var number =0;
            double n = 0;
            char ch ='\0';
            bool isbool = false;

            while (input !="END")
            {
               
                bool isint=int.TryParse(input, out number);
                if (isint==true)
                {
                    Console.WriteLine($"{input} is integer type");
                    input = Console.ReadLine();
                    continue;
                }

                bool isChar = char.TryParse(input,out ch);
                if (isChar==true)
                {
                    Console.WriteLine($"{input} is character type");
                    input = Console.ReadLine();
                    continue;
                }

                bool isDouble = double.TryParse(input, out n);
                if (isDouble==true)
                {
                    Console.WriteLine($"{input} is floating point type");
                    input = Console.ReadLine();
                    continue;
                }

                bool isBoolean = bool.TryParse(input, out isbool);
                if (isBoolean==true)
                {
                    Console.WriteLine($"{input} is boolean type");
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                    input = Console.ReadLine();
                    continue;
                }
            }

            
        }
    }
}
