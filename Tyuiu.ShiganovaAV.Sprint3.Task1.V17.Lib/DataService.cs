using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShiganovaAV.Sprint3.Task1.V17.Lib
{
    public class DataService : ISprint3Task1V17
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double result = 1;
            int k = startValue;
            double baseValue = 2 / Math.Cos(value);
            while (k <= stopValue)
            {
                result *= Math.Pow(baseValue, k);
                k++;
            }
            return Math.Round(result, 3);
        }
    }
}
