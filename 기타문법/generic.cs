using System;

namespace ConsoleApp1
{
    class Program
    {
        class MyList<T> // 일반화(generic) class
        {
            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }
        }
        
        static void Test<T>(T input)
        {

        }
        
        static void Main(string[] args)
        {
            MyList<int> myIntList = new MyList<int>();
            int item = myIntList.GetItem(0);

        }
    }
}
