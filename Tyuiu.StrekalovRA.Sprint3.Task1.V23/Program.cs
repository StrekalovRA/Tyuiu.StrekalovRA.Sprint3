using Tyuiu.StrekalovRA.Sprint3.Task1.V23.Lib;

namespace Tyuiu.StrekalovRA.Sprint3.Task1.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #3 
                Тема: Оператор цикла while
                Задание #1
                Вариант #23
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Написать программу используя цикл while,
                которая вычисляет произведение ряда по формуле, при х=5
                Y=mult(1; 5)(300/(sinx+x^k))^k
             */

            int X, ST, END;
            Console.WriteLine("X = "); X = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Start = "); ST = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("End = "); END = Convert.ToInt16(Console.ReadLine());

            DataService DS = new DataService();
            var Res = DS.GetMultiplySeries(X, ST, END);
            Console.WriteLine("РЕЗУЛЬТАТ: " + Res);
        }
    }
}