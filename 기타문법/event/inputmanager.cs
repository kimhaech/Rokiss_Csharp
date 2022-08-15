using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class InputManager
    {
        public delegate void OnInputKey();
        public event OnInputKey InputKey;


        public void Update()
        {
            if (Console.KeyAvailable == false) // 아무것도 입력 X
            {
                return;
            }

            ConsoleKeyInfo info = Console.ReadKey(); // 키 입력 받아서 정보 저장
            if (info.Key == ConsoleKey.A) // 입력한 키가 A인 경우
            {
                // 모두에게 알려주기
                InputKey();
            }
        }
    }
}
