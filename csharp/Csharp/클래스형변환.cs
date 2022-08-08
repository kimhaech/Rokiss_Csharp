using System;

namespace Csharp
{
    class Player // 부모, 기반
    {
        // 필드        
        protected int hp;
        protected int attack;

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

    class Mage : Player
    {
        public int mp;
    }

    class Archer : Player
    {

    }

    class Knight : Player // 자식, 파생
    {

        public Knight() : base(100)
        {
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
        static void EnterGame(Player player)
        {
            // 1번째
            //bool isMage = (player is Mage);
            //if (isMage)
            //{
            //    Mage mage = (Mage)player;
            //    mage.mp = 10;
            //}
            // 2번째
            Mage mage = (player as Mage);
            if (mage != null)
            {
                mage.mp = 10;
            }
        }
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            EnterGame(knight);
            EnterGame(mage);
        }
    }
}
