using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.StrekalovRA.Sprint3.Task4.V23.Lib
{
    public class DataService : ISprint3Task4V23
    {
        public double Calculate(int ST, int END)
        {
            double Res = 0;

            for (int X = ST; X <= END; X += 1) {
                if (X == 0) { continue; }
                Res += ((Math.Cos(X) / X) + 3);
            }
            return Math.Round(Res, 3);
        }
    }
}
