using Tyuiu.ShiganovaAV.Sprint3.Task5.V9.Lib;
namespace Tyuiu.ShiganovaAV.Sprint3.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 |Выполнила: Шиганова А.В.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнила: Шиганова Анастасия Владимировна |ПИНб-25-1|                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите х: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите начало1: ");
            int startValue1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конец1: ");
            int stopValue1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите началo2: ");
            int startValue2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конец2: ");
            int stopValue2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.GetSumSumSeries(x,startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

