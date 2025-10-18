using Tyuiu.ShiganovaAV.Sprint3.Task7.V13.Lib;
namespace Tyuiu.ShiganovaAV.Sprint3.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -9.11;
            valueWaitArray[1] = -6.84;
            valueWaitArray[2] = -4.61;
            valueWaitArray[3] = -2.42;
            valueWaitArray[4] = -0.27;
            valueWaitArray[5] = 0.00;
            valueWaitArray[6] = 2.27;
            valueWaitArray[7] = 4.50;
            valueWaitArray[8] = 6.73; 
            valueWaitArray[9] = 8.96;
            valueWaitArray[10] = 11.19;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
