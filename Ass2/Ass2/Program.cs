using System;

namespace Ass2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.Write("Input a number to check if its prime or NOT: ");
            num = int.Parse(Console.ReadLine());


                int i;
                for (i = 2; i <= num - 1; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine("NOT PRIME");
                        break;
                    }
                }
                if (i == num)
                {
                    Console.WriteLine("ITS PRIME");
                }
            
            Console.ReadKey();
        }
    }
}
