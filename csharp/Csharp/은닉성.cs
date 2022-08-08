using System;

namespace Csharp
{
    class Player // 부모, 기반
    {
        // 필드
        private int a;
        protected int b;

        static public int counter = 1;
        public int id;
        public int hp;
        public int attack;
        

       public void setA()
       {
            a = 13;
       }

       public Player()
       {
            Console.WriteLine("Player 생성자 호출!");
       }
       
        public Player(int hp)
        {
            Console.WriteLine("Plyaer hp 생성자 호출!");
        }

        public void Move()
        {
            Console.WriteLine("Player Move");
        }
    }

    class Mage
    {

    }

    class Archer
    {

    }

    class Knight : Player // 자식, 파생
    {
        int c;
        
        public void setB()
        {
            b = 13;
        }

        public Knight() : base(100)
        {
            this.c = 10;
            base.hp = 100;

            Console.WriteLine("Knight 생성자 호출!");
        }
        
        static public Knight CreateKinght()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;

            return knight;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = Knight.CreateKinght();
            knight.Move();

        }
    }
}
