using Tyuiu.StrekalovRA.Sprint3.Task5.V6.Lib;

namespace Tyuiu.StrekalovRA.Sprint3.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #3 
                Тема: Вложенные циклы
                Задание #5
                Вариант #6
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Y = sum(1; 3)sum(1; 10)(1/cosx + 2)
             */

            int ST_1, END_1, ST_2, END_2;
            Console.WriteLine("Start first sum = "); ST_1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Start second sum = "); ST_2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("End first sum = "); END_1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("End second sum = "); END_2 = Convert.ToInt16(Console.ReadLine());

            DataService DS = new DataService();
            Console.WriteLine("РЕЗУЛЬТАТ: " + DS.GetSumSumSeries(ST_1, ST_2, END_1, END_2));
            Console.ReadKey();
        }
    }
}