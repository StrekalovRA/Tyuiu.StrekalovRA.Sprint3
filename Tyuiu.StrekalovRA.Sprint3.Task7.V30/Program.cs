using Tyuiu.StrekalovRA.Sprint3.Task7.V30.Lib;

namespace Tyuiu.StrekalovRA.Sprint3.Task7.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #3 
                Тема: Добавление к решению итоговых проектов по спринту
                Задание #7
                Вариант #30
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                F(X) = (5x+2.5)/(sinx+2)+2x+2
                выписать таблицу значений функции при x = [-5; 5], jump = 1,
                исключить деление на 0, значения округлить до 2 знаков
            */

            int ST, END;
            Console.WriteLine("Start = "); ST = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("End = "); END = Convert.ToInt16(Console.ReadLine());

            DataService DS = new DataService();
            var F_X = DS.GetMassFunction(ST, END);
            Console.WriteLine("РЕЗУЛЬТАТ:");

            /*
                 |    X   |   F(X)    |
                 |    ...  |   ...        |
            */
            Console.WriteLine($"|\tX\t|\tF(X)\t|");
            for (int X = ST; X <= END; X += 1)
            {
                var Y = F_X[X - ST];
                Console.WriteLine($"|\t{X}\t|\t{Y}\t|");
            }
            Console.ReadKey();

        }
    }
}