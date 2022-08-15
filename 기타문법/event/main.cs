using System;

// delegate 대리자
namespace ConsoleApp1
{
    class Program
    {
        static void OnInputTest()
        {
            Console.WriteLine("Input Received!");
        }

        static void Main(string[] args)
        {
            InputManager inputManager = new InputManager();
            inputManager.InputKey += OnInputTest;

            while (true)
            {
                inputManager.Update();
            }
        }
    }
}
