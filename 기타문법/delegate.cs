using System;

// delegate 대리자
namespace ConsoleApp1
{
    class Program
    {

        delegate int OnClicked();
        // delegate -> 형식은 형식인데, 함수 자체를 인자로 넘겨주는 형식
        // 반환 : int 입력 : void 
        // OnClicked가 delegate 형식의 이름

        static void ButtonPressed(OnClicked clickedFunction) // 하나의 함수로 다양한 기능을 할 수 있도록
        {
            clickedFunction();
        }
       
        static int TestDelegate()
        {
            Console.WriteLine("Hello Delegate");
            return 0;
        }

        static int TestDelegate2()
        {
            Console.WriteLine("Hello Delegate2");
            return 0;
        }

        static void Main(string[] args)
        {
            OnClicked clicked = new OnClicked(TestDelegate);
            clicked += TestDelegate2; // 두개를 이어붙여서 사용 가능하다.

            ButtonPressed(clicked);
        }
    }
}
