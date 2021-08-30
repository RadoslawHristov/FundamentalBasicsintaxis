using System;

namespace _5._Decrypting_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            string sum = String.Empty;
            for (int i = 1; i <= number; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int value = input + key;
                char message = (char)value;
                if (i==0)
                {
                    message = char.ToUpper(message);
                }

                sum += message;
            }

            Console.WriteLine(sum);
        }
    }
}
