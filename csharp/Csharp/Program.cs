using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 정수
            int hp;
            
            hp = 100;

            Console.WriteLine("Hello Number ! {0}", hp);

            // boolean
            bool check;
            check = true;
            check = false;

            // 소수
            float t = 3.14f;
            double d;
            d = 3.14;

            // 문자 (2byte)
            char c;

            // 문자열
            string s;
            s = "I'm hungry...";

            Console.WriteLine(s);

            // 형변환
            int a = 1000;
            short b = (short)a;

            byte bt = 255;
            sbyte sb = (sbyte)bt;
            // 0xFF = 0b11111111 = -1


        }
    }
}
