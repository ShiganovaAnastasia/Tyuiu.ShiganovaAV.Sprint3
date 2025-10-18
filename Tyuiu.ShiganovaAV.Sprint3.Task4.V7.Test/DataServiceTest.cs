using Newtonsoft.Json.Linq;
using Tyuiu.ShiganovaAV.Sprint3.Task4.V7.Lib;
namespace Tyuiu.ShiganovaAV.Sprint3.Task4.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 20;
            double res = ds.Calculate(startValue, stopValue);
            Assert.AreNotEqual(1.0, res);
        }
    }
}
