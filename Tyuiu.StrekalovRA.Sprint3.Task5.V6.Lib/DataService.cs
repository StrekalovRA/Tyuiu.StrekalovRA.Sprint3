using System.Transactions;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.StrekalovRA.Sprint3.Task5.V6.Lib
{
    public class DataService : ISprint3Task5V6
    {
        public double GetSumSumSeries(int ST_1, int ST_2, int END_1, int END_2)
        {
            double Res = 0;

            for (int I = ST_1; I <= END_1; I += 1) {
                for ( int K = ST_2; K <= END_2; K += 1) {
                    Res += ((1 / Math.Cos(K)) + 2);
                }
            }
            return Math.Round(Res, 3);
        }
    }
}
