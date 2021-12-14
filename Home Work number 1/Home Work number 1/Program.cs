using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Home_Work_number_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Привет введи свое имя!"); // Приветствие           
            string name = Console.ReadLine(); //вводим имя
            DateTime date = DateTime.Now;// дата
            System.Console.WriteLine($"Привет {name}, сегодня {date}."); // выводим приветствие имя и дату на консоль 
        }
    }
}
