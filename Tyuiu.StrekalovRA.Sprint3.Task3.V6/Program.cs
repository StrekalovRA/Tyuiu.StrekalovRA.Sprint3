using Tyuiu.StrekalovRA.Sprint3.Task3.V6.Lib;

namespace Tyuiu.StrekalovRA.Sprint3.Task3.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #3 
                Тема: Использование операторов continue и break в циклах
                Задание #3
                Вариант #6
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Используя цикл foreach заменить цифры на букву
                t в строке: 12able 1o s4gh
             */

            string Text;
            char Item;

            Console.Write("Text = ");
            Text = Console.ReadLine();
            Console.WriteLine("Symbol = ");
            Item = Convert.ToChar(Console.ReadLine());

            DataService DS = new DataService();
            Console.WriteLine("РЕЗУЛЬТАТ: " + DS.ReplaceNumOnChar(Text, Item));
            Console.ReadKey();
        }
    }
}