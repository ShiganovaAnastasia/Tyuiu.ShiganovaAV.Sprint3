using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShiganovaAV.Sprint3.Task0.V20.Lib
{
    public class DataService : ISprint3Task0V20
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double result = 1;
            for (int k = startValue; k <= stopValue; k++)
                result *= Math.Cos(value) + Math.Pow(k / 8.0, 3);
            return Math.Round(result,3);
        }
    }
}
