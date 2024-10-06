using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.StrekalovRA.Sprint3.Task7.V30.Lib
{
    public class DataService : ISprint3Task7V30
    {
        public double[] GetMassFunction(int ST, int END)
        {
            double[] Values = new double[END - ST + 1];

            for (int X = ST; X <= END; X += 1) {
                // случай, если sinx + 2 = 0, хотя такого быть не может. Матан покинула чат ☠
                if ((Math.Sin(X) + 2) == 0) { Values.Append(0); continue; }

                double F_X = ((5*X + 2.5)/(Math.Sin(X)+2)) + 2 * X + 2;
                Values[X - ST] = Math.Round(F_X, 2);
            }

            return Values;
        }
    }
}
