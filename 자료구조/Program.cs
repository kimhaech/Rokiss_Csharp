using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Monster
    {
        public int id;

        public Monster(int id) { this.id = id; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 배열
            int[] scores = new int[5];
            // int[] scores = new int[5] {10, 20, 30, 40, 50}; 크기 정의와 원소를 함께 입력
            // int[] scores = {10, 20, 30 ,40 ,50}; 크기정의 없이 원소 입력
            // scores[1] = 20; 직접 하나씩 접근하여 할당
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = i * 10 + 10;
                Console.WriteLine(scores[i]);
            }

            Console.WriteLine();

            int[] scores2 = scores;
            scores2[3] = 333333;

            // socres 출력
            foreach (int score in scores2)
            {
                Console.WriteLine(score);
            }
            // scores2 출력
            foreach (int score in scores2)
            {
                Console.WriteLine(score);
            }
            // 다차원 배열
            int[,] arr = new int[2, 3];

            // 가변 배열
            int[][] a = new int[3][];

            a[0] = new int[3];
            a[1] = new int[6];
            a[2] = new int[2];

            a[0][0] = 1;

            // List
            List<int> list = new List<int>();
            
            for (int i = 0; i < 5; i++)
                list.Add(i);

            for (int i = 0; i < 5; i++)
                Console.WriteLine(list[i]);

            foreach (int i in list)
                Console.WriteLine(i);

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);

            // Dictionary
            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();
            for (int i = 0; i < 10000; i++)
            {
                dic.Add(i, new Monster(i));
            }
            // 해당하는 값이 없으면 crash
            //Monster mon = dic[5000];
            
            // 별도 함수 - 성공유무 boolean 타입 값 반환
            Monster mon;
            dic.TryGetValue(20000, out mon);

            dic.Remove(7777); // 해당하는 인덱스의 값 삭제
        }
    }
}
