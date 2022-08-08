using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Harry Potter";

            // 1. 찾기
            bool found = name.Contains("Harry"); // 참 거짓 반환
            int index = name.IndexOf('P'); // 없다면 -1 반환

            // 2. 변형
            name = name + " Junior";

            string lowerCaseName = name.ToLower(); // 전부 소문자로 변환
            string upperCaseName = name.ToUpper(); // 전부 대문자로 변환
            string newName = name.Replace('r', 'l'); // r->l로 변환

            // 3. 분할
            string[] names = name.Split(new char[] {' '}); // 공백을 기준으로 자르기
            string substringName = name.Substring(5); // 해당 범위까지의 스트링 반환
        }
    }
}
