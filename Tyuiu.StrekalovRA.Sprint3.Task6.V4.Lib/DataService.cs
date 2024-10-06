using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.StrekalovRA.Sprint3.Task6.V4.Lib
{
    public class DataService : ISprint3Task6V4
    {
        public int GetSumTheDivisors(int ST, int END)
        {
            int Amount = 0;
            for (int Num = ST; Num <= END; Num += 1) {
                for (int Deller = 1; Deller <= Num; Deller += 1) {
                    if (Deller > 9 && (Num % Deller == 0)) { Amount += 1; }
                }
            }
            return Amount;
        }
    }
}
