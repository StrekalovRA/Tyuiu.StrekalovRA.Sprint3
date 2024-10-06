using Tyuiu.StrekalovRA.Sprint3.Task2.V29.Lib;

namespace Tyuiu.StrekalovRA.Sprint3.Task2.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Title = "Спринт #3 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #3 
                Тема: Оператор цикла do-while
                Задание #2
                Вариант #29
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Написать программу используя цикл do...while, которая вычисляет сумму ряда по формуле, при a=0,5
                Y = sum(1;18)(a^k+1/4)cosk
             */

            double A;
            int ST, END;
            Console.WriteLine("A = ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Start = ");
            ST = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("End = ");
            END = Convert.ToInt16(Console.ReadLine());

            DataService DS = new DataService();
            Console.WriteLine("РЕЗУЛЬТАТ: " + DS.GetSumSeries(A, ST, END));
            Console.ReadKey();
        }
    }
}