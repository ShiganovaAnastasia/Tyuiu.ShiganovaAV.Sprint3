using Tyuiu.ShiganovaAV.Sprint3.Task2.V5.Lib;
namespace Tyuiu.ShiganovaAV.Sprint3.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.75;
            int startValue = 1;
            int stopValue = 20;
            double res = ds.GetSumSeries(value,startValue,stopValue);
            double wait = 0.333;
            Assert.AreEqual(wait, res);
        }
    }
}
