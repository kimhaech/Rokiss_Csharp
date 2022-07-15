using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0; // 0 가위 1 바위 2 보

            if (choice == 0)
            {
                Console.WriteLine("가위입니다.");
            }
            else if (choice == 1)
            {
                Console.WriteLine("바위입니다.");
            }
            else
            {
                Console.WriteLine("보입니다.");
            }
        }
    }
}
