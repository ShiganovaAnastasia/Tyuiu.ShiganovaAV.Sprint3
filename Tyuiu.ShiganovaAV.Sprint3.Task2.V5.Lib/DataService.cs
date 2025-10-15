﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShiganovaAV.Sprint3.Task2.V5.Lib
{
    public class DataService : ISprint3Task2V5
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            int k = startValue;
            do
            {
                sum += (Math.Pow(value, k) + 1) * Math.Cos(k);
                k++;
            }
            while (k <= stopValue);
            return Math.Round(sum, 3);
        }
    }
}
