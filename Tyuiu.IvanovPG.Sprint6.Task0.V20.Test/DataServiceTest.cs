using Tyuiu.IvanovPG.Sprint6.Task0.V20.Lib;

namespace Tyuiu.IvanovPG.Sprint6.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 9.037;
            Assert.AreEqual(wait, res);
        }
    }
}
