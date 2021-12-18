using System;

namespace Димашнее_задание_2._3
{
    class Program
    {
        static void Main(string[] args)
        //Определить, является ли введённое пользователем число чётным.
        {
            bool isRun = true;
            while (isRun)
            {

                System.Console.WriteLine("Введите число , что бы узнать его четность");
                int a;

                a = int.Parse(Console.ReadLine());

                if (a % 2 == 0)
                {
                    System.Console.WriteLine("число четное");
                }
                else
                {
                    System.Console.WriteLine("число нечетное");
                }

                Console.WriteLine("Хотите продолжить? Y/N");
                string userAnswer = Console.ReadLine();

                if (userAnswer.ToUpper() == "N")
                {
                    isRun = false;
                }


                Console.ReadKey();
            }
        }
    }
}
