using Tyuiu.ShiganovaAV.Sprint3.Task3.V18.Lib;
namespace Tyuiu.ShiganovaAV.Sprint3.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string input = "4n5nvf 56 bgy";
            char c = 'n';
            string res = ds.ReplaceNumOnChar(input, c);
            string wait = "nnnnvf nn bgy";
            Assert.AreEqual(wait, res);
        }
    }
}
