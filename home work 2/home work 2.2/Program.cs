using System;

namespace Домашнее_задание_2._2
{
    class Program
    {
        static void Main(string[] args)
        //Запросить у пользователя порядковый номер текущего месяца и вывести его название.
        {
            bool isRun = true;
            while (isRun)
            {

                Console.WriteLine("Введите число от 1 до 12, что-бы узнать месяц!");
                int month = Convert.ToInt32(Console.ReadLine());

                switch (month)
                {
                    case 1:
                        Console.WriteLine("Это месяц Январь");
                        break;
                    case 2:
                        Console.WriteLine("Это месяц Февраль");
                        break;
                    case 3:
                        Console.WriteLine("Это месяц Март");
                        break;
                    case 4:
                        Console.WriteLine("Это месяц Апрель");
                        break;
                    case 5:
                        Console.WriteLine("Это месяц Май");
                        break;
                    case 6:
                        Console.WriteLine("Это месяц Июнь");
                        break;
                    case 7:
                        Console.WriteLine("Это месяц Июль");
                        break;
                    case 8:
                        Console.WriteLine("Это месяц Август");
                        break;
                    case 9:
                        Console.WriteLine("Это месяц Сентябрь");
                        break;
                    case 10:
                        Console.WriteLine("Это месяц Октябрь");
                        break;
                    case 11:
                        Console.WriteLine("Это месяц Ноябрь");
                        break;
                    case 12:
                        Console.WriteLine("Это месяц Декабрь");
                        break;
                    default:
                        Console.WriteLine("Укажите значение от 1 до 12");
                        break;

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

