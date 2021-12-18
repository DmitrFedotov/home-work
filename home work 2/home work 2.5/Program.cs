using System;

namespace ConsoleApp2
{
    class Program
    {
        enum Season
        {
            Winter = 1,
            Spring,
            Summer,
            Autumn

        }
        enum Winter
        {
            December,
            January,
            February

        }
        enum Spring
        {
            March,
            April,
            May
        }
        enum Summer
        {
            June,
            July,
            August

        }
        enum Autumn
        {
            September,
            October,
            November

        }
        static void Main(string[] args)
        {
            bool isRun = true;
            while (isRun)
            {
                System.Console.WriteLine("Введите сезон (Winter, Spring, Summer, Autumn)");
                string seasons = System.Console.ReadLine();
                Season season = (Season)Enum.Parse(typeof(Season), seasons, ignoreCase: true);
                System.Console.WriteLine(season);
                switch (season)
                {
                    case Season.Winter:
                        System.Console.WriteLine("Вы запросили зимний сезон");
                        System.Console.WriteLine("Введите месяц December, January, February");
                        string q = System.Console.ReadLine();
                        Winter winter = (Winter)Enum.Parse(typeof(Winter), q, ignoreCase: true);
                        System.Console.WriteLine(winter);
                        float a;
                        float b;
                        float c;
                        System.Console.WriteLine("Введите минимальную t°C");
                        a = float.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("Введите максимальную t°C");
                        b = float.Parse(System.Console.ReadLine());
                        System.Console.WriteLine($"Средне суточная t°C в сутки {c = ((a + b) / 2)}");
                        if (c > 0)
                        {
                            System.Console.WriteLine("Дождливая погода");
                        }
                        break;

                    case Season.Spring:
                        System.Console.WriteLine("Вы запросили весенний сезон (March, April, May)");
                        System.Console.WriteLine("Введите месяц");
                        string w = System.Console.ReadLine();
                        Spring spring = (Spring)Enum.Parse(typeof(Spring), w, ignoreCase: true);
                        System.Console.WriteLine(spring);
                        break;

                    case Season.Summer:
                        System.Console.WriteLine("Вы запросили летний сезон (June, July, August)");
                        System.Console.WriteLine("Введите месяц");
                        string e = System.Console.ReadLine();
                        Summer summer = (Summer)Enum.Parse(typeof(Summer), e, ignoreCase: true);
                        System.Console.WriteLine(summer);
                        break;

                    case Season.Autumn:
                        System.Console.WriteLine("Вы запросили осенний сезон (September, October, November)");
                        System.Console.WriteLine("Введите месяц");
                        string t = System.Console.ReadLine();
                        Autumn autumn = (Autumn)Enum.Parse(typeof(Autumn), t, ignoreCase: true);
                        System.Console.WriteLine(autumn);
                        break;

                    default:
                        Console.WriteLine("Неверно запрошен сезон");
                        break;


                }
                System.Console.WriteLine("Хотите продолжить? Y/N");
                string userAnswer = Console.ReadLine();

                if (userAnswer.ToUpper() == "N")
                {
                    isRun = false;
                }

























            }
        }
    }
}
