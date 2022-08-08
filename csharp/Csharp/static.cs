using System;

namespace Csharp
{
    class Knight
    {
        static public int a; // 오로지 1개만 존재

        public int hp;
        public int attack;

        public Knight()
        {
            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출!");
        }

        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;

            return knight;
        }

        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;

            return knight;
        }
        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = Knight.CreateKnight();
        }
    }
}
