using Tyuiu.ShiganovaAV.Sprint3.Task7.V13.Lib;
namespace Tyuiu.ShiganovaAV.Sprint3.Task7.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 |Выполнила: Шиганова А.В.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Шиганова Анастасия Владимировна |ПИНб-25-1|                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            Console.Write("Начало: "+startValue);
            int stopValue = 5;
            Console.Write("Конец: "+stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double[] res = ds.GetMassFunction(startValue, stopValue);
            int len = res.Length;

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("X = {0,3} | F(x) = {1,7:F2}", startValue + i, res[i]);
            }

            Console.ReadKey();
        }
    }
}

