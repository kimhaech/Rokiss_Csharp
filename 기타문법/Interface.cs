using System;

namespace ConsoleApp1
{
    class Program
    {
        class MyList<T> where T : struct // 어떠한 T 같이든 상관이 없지만 T는 값 형식이어야 한다(struct) / 참조(class) / 기본 생성자가 있어야 한다. (new())
        {
            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }
        }

        interface IFlyable
        {
            void Fly();
        }

        abstract class Monster
        {
            public abstract void Shout();
        }

        class Orc : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("Orc!!");
            }
        }

        class FlyableOrc : Orc, IFlyable
        {
            public void Fly()
            {

            }
        }
        class Skeleton : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("Skeleton!!");
            }
        }
        
        static void Test<T>(T input)
        {

        }

        static void Main(string[] args)
        {

        }
    }
}
