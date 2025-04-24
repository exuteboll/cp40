using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        delegate void Message(); // шаг 1. объявляем делегат 
        delegate void Time();
        static void Main(string[] args)
        {
            GoodMorning good = new GoodMorning();
            Message message; // шаг 2. создаем объект делегата 
            message = Hello; // шаг 3. связываем с методом 
            message(); // шаг 4. Вызываем метод
            Message poka = Poka;
            poka();
            Time time;
            if (DateTime.Now.Hour < 12)
            {
                time = Morning;
            }
            else
            {
                time = Evening;
            }
            time();
            Console.ReadKey();
        }
        static public void Hello() => Console.WriteLine("Привет");
        static public void Poka() => Console.WriteLine("Пока");

        static public void Morning() => Console.WriteLine("Доброе утро");
        static public void Evening() => Console.WriteLine("Добрый вечер");
    }
}
