using System;

namespace Csharp
{
    class Program
    {
        enum Choice
        {
            Rock = 1,
            Paper = 2,
            Scissors = 0
        }

        static void Main(string[] args)
        {
            // 0 : 가위 1 : 바위 2 : 보
            
            Random random = new Random();
            int aiChoice = random.Next(0, 3); // 0~2사이의 랜덤 값

            // 사용자에게 입력 받기
            int choice = Convert.ToInt32(Console.ReadLine());

            // 사용자의 값
            switch (choice)
            {
                case (int)Choice.Scissors:
                    Console.WriteLine("당신의 선택은 가위입니다.");
                    break;
                case (int)Choice.Rock:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    break;
                case (int)Choice.Paper:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    break;
            }
            // ai의 값
            switch (aiChoice)
            {
                case (int)Choice.Scissors:
                    Console.WriteLine("ai의 선택은 가위입니다.");
                    break;
                case (int)Choice.Rock:
                    Console.WriteLine("ai의 선택은 바위입니다.");
                    break;
                case (int)Choice.Paper:
                    Console.WriteLine("ai의 선택은 보입니다.");
                    break;
            }

            // 승부 결정

            if (choice == aiChoice)
            {
                Console.WriteLine("무승부 입니다.");
            }
            else
            {
                if ((choice == (int)Choice.Rock && aiChoice == (int)Choice.Scissors) || (choice == (int)Choice.Scissors && aiChoice == (int)Choice.Paper) || (choice == (int)Choice.Paper && aiChoice == (int)Choice.Rock))
                {
                    Console.WriteLine("승리입니다,");
                }
                else
                {
                    Console.WriteLine("패배입니다.");
                }
                
            }
        }
    }
}
