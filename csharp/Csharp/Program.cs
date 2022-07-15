using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 정수
            //int hp;

            //hp = 0xFFFF;
            //short bb = (short)hp;

            //Console.WriteLine("Hello Number ! {0}", bb);

            //// boolean
            //bool check;
            //check = true;
            //check = false;

            //// 소수
            //float t = 3.14f;
            //double d;
            //d = 3.14;
            //d = (double)t;

            //// 문자 (2byte)
            //char c;

            //// 문자열
            //string s;
            //s = "I'm hungry...";

            //Console.WriteLine(s);

            //// 형변환
            //int a = 1000;
            //short b = (short)a;

            //byte bt = 255;
            //sbyte sb = (sbyte)bt;
            //// 0xFF = 0b11111111 = -1

            int hp = 100;
            int level = 50;
            hp = 100 + 2 * 3 - (15/3)%2;

            Console.WriteLine(hp);

            bool b = (hp > 0);

            Console.WriteLine(b);

            bool isAlive = (hp > 0);
            bool isHighLevel = (level >= 40);

            // a = 살아있는 고렙 유저인가요?
            bool a = isAlive && isHighLevel;

            // b = 살아있거나, 고렙 유저이거나, 둘 중 하나인가?
            b = isAlive || isHighLevel;

            // c = 죽은 유저인가?
            bool c = !isAlive;


        }
    }
}
