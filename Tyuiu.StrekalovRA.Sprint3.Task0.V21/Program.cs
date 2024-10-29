using Tyuiu.StrekalovRA.Sprint3.Task0.V21.Lib;

namespace Tyuiu.StrekalovRA.Sprint3.Task0.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Title = "Спринт #3 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #3 
                Тема: Оператор цикла for
                Задание #0
                Вариант #21
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Написать программу используя цикл for, которая вычисляет сумму ряда по формуле, при a=1,5
                R = Sum(k=1; k=13): (a^k+1/4)sink
             */

            double A;
            int ST, END;
            Console.WriteLine("A = ");
            //A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Start = ");
            //ST = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("End = ");
            //END = Convert.ToInt16(Console.ReadLine());

            A = 1.5;
            ST = 1;
            END = 13;

            DataService DS = new DataService();
            Console.WriteLine("РЕЗУЛЬТАТ: " + DS.GetSumSeries(A, ST, END));
            Console.ReadKey();
        }
    }
}