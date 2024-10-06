using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.StrekalovRA.Sprint3.Task1.V23.Lib
{
    public class DataService : ISprint3Task1V23
    {
        public double GetMultiplySeries(int X, int ST, int END)
        {
            double Res = 1;
            int K = ST;
            while (K <= END)
            {
                Res *= (Math.Pow((300 / (Math.Sin(X) + Math.Pow(X, K))), K));
                K += 1;
            }

            return Math.Round(Res, 3);
        }
    }
}
