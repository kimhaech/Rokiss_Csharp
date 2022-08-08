using System;

namespace Csharp
{
    class Knight
    {
        public int hp;
        public int attack;

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
            knight.hp = 100;
            knight.attack = 10;

            knight.Move();
            knight.Attack();

            Knight knight2 = knight; // 같은 객체를 참조하여 값을 변경하면 knight, knight2 모두 변경
            Knight knight3 = new Knight(); // 별도의 Knight 객체를 가진다.
            // 하나하나 복사
            knight3.hp = knight.hp;
            knight3.attack = knight.attack;

            // 깊은 복사
            Knight knight4 = knight.Clone();



        }
    }
}
