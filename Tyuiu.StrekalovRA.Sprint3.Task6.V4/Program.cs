using Tyuiu.StrekalovRA.Sprint3.Task6.V4.Lib;

namespace Tyuiu.StrekalovRA.Sprint3.Task6.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #3 
                Тема: Обработка целочисленной информации
                Задание #6
                Вариант #4
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Напишите программу, которая ищет среди целых чисел,
                принадлежащих числовому отрезку [14, 20] количество всех делителей больше 9
             */

            int ST, END;
            Console.WriteLine("Start = ");
            ST = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("End = ");
            END = Convert.ToInt16(Console.ReadLine());

            DataService DS = new DataService();
            Console.WriteLine("РЕЗУЛЬТАТ: " + DS.GetSumTheDivisors(ST, END));
            Console.ReadKey();
        }
    }
}