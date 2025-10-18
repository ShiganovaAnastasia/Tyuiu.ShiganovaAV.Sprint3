using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShiganovaAV.Sprint3.Task4.V7.Lib
{
    public class DataService : ISprint3Task4V7
    {
        public double Calculate(int startValue, int stopValue)
        {
            double product = 1.0;

            for (int x = startValue; x <= stopValue; x++)
            {
                // Проверка на x = 0
                if (x == 0)
                {
                    break;
                }

                try
                {
                    // Проверка деления на ноль (cos(x) = 0)
                    double cosX = Math.Cos(x);
                    if (Math.Abs(cosX) < 0.0001)
                    {
                        continue; // Пропускаем итерацию
                    }

                    double y = (x / cosX) + 1.5;
                    product *= y;
                }
                catch (Exception)
                {
                    // Продолжаем выполнение при ошибках
                    continue;
                }
            }

            return Math.Round(product, 3); // Округляем до 3 знаков
        }
    }
}
