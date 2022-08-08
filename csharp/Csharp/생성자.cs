using System;

namespace Csharp
{
    class Knight
    {
        public int hp;
        public int attack;

        public Knight()
        {
            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출!");
        }
        // 다른 생성자
        public Knight(int hp) : this() // this()는 빈 생성자를 먼저 호출 한 다음 현재 생성자를 호출
        {
            this.hp = hp; // 현재 class의 hp를 의미하는 this

            Console.WriteLine("int 생성자 호출!");
        }

        public Knight(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;

            Console.WriteLine("int int 생성자 호출!");
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
            Knight knight = new Knight();
        }
    }
}
