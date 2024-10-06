using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.StrekalovRA.Sprint3.Task2.V29.Lib
{
    public class DataService : ISprint3Task2V29
    {
        public double GetSumSeries(double A, int ST, int END)
        {
            double Res = 0;
            int K = ST;
            do {
                Res += (Math.Cos(K) * (0.25 + Math.Pow(A, K)));
                K += 1;
            } while (K <= END); // неудобно капец, одна ошибка и я в гробу... 😭

            return Math.Round(Res, 3);
        }
    }
}