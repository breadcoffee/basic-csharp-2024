using System.Diagnostics;

namespace ex09_exceptionhandlings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3] { 1, 2, 3 };

            try
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"{array[i]}");
                }
            }
            catch (Exception ex)  // Exception은 모든 예외 클래스의 조상이다
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("프로그램 종료!");
            }
        }

    }
}
