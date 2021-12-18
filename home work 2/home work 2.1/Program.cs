using System;

namespace home_work_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            float one, two;

            Console.WriteLine("Введите минимальную t°C");
            one = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальную t°C");
            two = float.Parse(Console.ReadLine());
            Console.WriteLine($"Средне суточная t°C в сутки {(one + two) / 2}");
        }
    }
}
