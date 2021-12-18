using System;

namespace Домашняя_работа_2._4
{
    class Program
    {
        static void Main(string[] args)
        // Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли,
        // только за место динамических, по вашему мнению, данных (это может быть дата, название магазина, сумма покупок) подставляйте переменные,
        // которые были заранее заготовлены до вывода на консоль.

        {
            String name = "ООО Татнефть-Азс центр";
            Console.WriteLine(name);
            name = "АЗС 232 г.Казань, ул.Мира,67а";
            Console.WriteLine(name);
            name = "Телефон бесплатной горячей линии";
            Console.WriteLine(name);
            string.Format("{0: (###) ###-####}", 8005555911);
            Console.WriteLine($"АЗС Татнефть, {0: +7(800) 555-5911}");
            DateTime date1 = new DateTime(2014, 1, 18, 8, 45, 26);
            Console.WriteLine($"ИНН:1644040194 {date1}");
            Console.WriteLine("Евсеева Н.П.");
            Console.WriteLine("КАССОВЫЙ ЧЕК/ПРИХОДА");
            Console.WriteLine("РН ККТ: 0000836812013878");
            Console.WriteLine("ФН: 8710000101060741");
            Console.WriteLine("ОФД:                          ООО Ярус");
            Console.WriteLine("Сайт ОФД:                     www.ofd-ya.ru");
            Console.WriteLine("Сайт ФНС:                     www.nalog.ru");
            Console.WriteLine("Смена:132Чек:322");
            Console.WriteLine("ТРК-3 ДТ-евро танэко");
            double a;
            double b;
            a = 60.0000;
            b = 40.90;
            Console.WriteLine($"                              {a} x {b}");
            Console.WriteLine($"                                   {a * b}");
            Console.WriteLine($"ИТОГ                               {a * b}");
            Console.WriteLine($"Наличными                          {a * b}");
            Console.WriteLine("СНО:                                ОСН");
            Console.WriteLine("ФД: 29416                 ФП:4020487046");




        }
    }
}
