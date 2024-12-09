using System.IO;
using Tyuiu.IvanovPG.Sprint6.Task5.V28.Lib;
namespace Tyuiu.IvanovPG.Sprint6.Task5.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\ivano\source\repos\Tyuiu.IvanovPG.Sprint6\InPutDataFileTask5V28.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
//"C:\Users\ivano\source\repos\Tyuiu.IvanovPG.Sprint6\InPutDataFileTask5V28.txt"