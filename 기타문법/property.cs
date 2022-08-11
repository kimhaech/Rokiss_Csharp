using System;

namespace ConsoleApp1
{
    class Program
    {
        class Knight
        {
            protected int hp;

            public int Hp
            {
                get { return hp; }
                set { hp = value; }
            }
        }

        class Mage
        {
            public int HP
            {
                get; set;
            }
        }
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            knight.Hp = 100;

            int hp = knight.Hp;
        }
    }
}
