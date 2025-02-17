﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.StrekalovRA.Sprint3.Task0.V21.Lib
{
    public class DataService : ISprint3Task0V21
    {
        public double GetSumSeries(double A, int Start, int End)
        {
            double Res = 0;
            for (int J = Start; J <= End; J += 1)
            {
                Res += ((Math.Pow(A, J) + 0.25) * Math.Sin(J));
            }
            Res = Math.Round(Res, 3);
            return Res;
        }
    }
}