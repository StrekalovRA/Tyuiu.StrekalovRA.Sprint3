using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.StrekalovRA.Sprint3.Task3.V6.Lib
{
    public class DataService : ISprint3Task3V6
    {
        public string ReplaceNumOnChar(string STR, char ITEM)
        {
           foreach(char I in STR)
            {
                if (Char.IsDigit(I)) { STR = STR.Replace(I, ITEM); }
            }
            return STR;
        }
    }
}
