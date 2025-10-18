using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShiganovaAV.Sprint3.Task7.V13.Lib
{
    public class DataService : ISprint3Task7V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + 1;

                if (Math.Abs(denominator) < 0.0001)
                {
                    y = 0;
                }
                else
                {
                    y = 3 * x + 2 - (x / denominator);
                }

                valueArray[count] = Math.Round(y, 2);

                count++;
            }

            return valueArray;
        }
    }
}
