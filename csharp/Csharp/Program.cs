using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // while 반복문
            //int count = 5;

            //while (count > 0)
            //{
            //    Console.WriteLine("Hello world");
            //    count--;
            //}

            // do while
            //string answer;
            //do
            //{
            //    Console.WriteLine("you happy?");
            //    answer = Console.ReadLine();
            //} while (answer != "y");

            // for 반복문
            
            for(int i = 1; i <= 100; i++)
            {
                if ((i % 3) != 0)
                    continue;
                Console.WriteLine($"3으로 나뉘는 숫자 발견 : {i}");
            }

            
        }
    }
}
