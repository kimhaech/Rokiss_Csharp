using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        class TestException : Exception
        {

        }

        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int result = a / b;

                throw new TestException();
            }   
            catch(DivideByZeroException e)
            {

            }
            catch(Exception e)
            {

            }
            finally
            {
                // 무조건 실행해야하는 코드
            }
        }
    }
}
