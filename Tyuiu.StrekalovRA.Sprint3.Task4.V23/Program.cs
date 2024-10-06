using Tyuiu.StrekalovRA.Sprint3.Task4.V23.Lib;

namespace Tyuiu.StrekalovRA.Sprint3.Task4.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #3 
                Тема: Использование операторов continue и break в циклах
                Задание #4
                Вариант #23
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                На отрезке, где x принимает значения от -5 до 5, вычислить значение функции y=(cos(x)/x)+3
                При х = 0 прервать цикл. Полученные значения перемножать.
             */

            int ST, END;
            Console.WriteLine("Start first sum = "); ST = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("End first sum = "); END = Convert.ToInt16(Console.ReadLine());

            DataService DS = new DataService();
            Console.WriteLine("РЕЗУЛЬТАТ: " + DS.Calculate(ST, END));
            Console.ReadKey();
        }
    }
}