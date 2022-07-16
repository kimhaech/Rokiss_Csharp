using System;

namespace Csharp
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n == 1)
                return 1;
            return n*Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("구구단");
            for(int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine(i + " X " + j + " = " + i*j);
                }
            }

            Console.WriteLine("\n별출력");
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n팩토리얼");
            int ret = Factorial(5);
            Console.WriteLine(ret);
        }
    }
}
