namespace Tyuiu.IvanovPG.Sprint6.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\ivano\source\repos\Tyuiu.IvanovPG.Sprint6\InPutDataFileTask7V29.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
//"C:\Users\ivano\source\repos\Tyuiu.IvanovPG.Sprint6\InPutDataFileTask7V29.csv"