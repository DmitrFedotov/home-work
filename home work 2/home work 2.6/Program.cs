using System;

namespace домашнее_задание_2._6
{
    class Program
    {
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sanday
        }
        static void Main(string[] args)

        {
            while (true)
            {
                System.Console.WriteLine("Введите день недели");
                string str = System.Console.ReadLine();
                DayOfWeek DayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), str, ignoreCase: true);
                System.Console.WriteLine(DayOfWeek);
                switch (DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        System.Console.WriteLine("Не рабочий день № 1                        Рабочий день №2");
                        break;
                    case DayOfWeek.Tuesday:
                        System.Console.WriteLine("Рабочий день № 1                           Рабочий день №2");
                        break;
                    case DayOfWeek.Wednesday:
                        System.Console.WriteLine("Рабочий день № 1                           Рабочий день №2");
                        break;
                    case DayOfWeek.Thursday:
                        System.Console.WriteLine("Рабочий день № 1                           Рабочий день №2");
                        break;
                    case DayOfWeek.Friday:
                        System.Console.WriteLine("Рабочий день № 1                           Рабочий день №2");
                        break;
                    case DayOfWeek.Saturday:
                        System.Console.WriteLine("Не рабочий день № 1                        Рабочий день №2");
                        break;
                    case DayOfWeek.Sanday:
                        System.Console.WriteLine("Не рабочий день № 1                     Не рабочий день №2");
                        break;
                    default:
                        System.Console.WriteLine("Неверно задан день");
                        break;
                }
            }
        }
    }
}
