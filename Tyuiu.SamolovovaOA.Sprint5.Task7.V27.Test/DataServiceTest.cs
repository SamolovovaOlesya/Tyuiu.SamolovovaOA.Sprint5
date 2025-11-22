using Tyuiu.SamolovovaOA.Sprint5.Task7.V27.Lib;
using System.IO;
namespace Tyuiu.SamolovovaOA.Sprint5.Task7.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\SamOl\source\repos\Tyuiu.SamolovovaOA.Sprint5\Tyuiu.SamolovovaOA.Sprint5.Task7.V27\bin\Debug\net8.0\OutPutDataFileTask7V27.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
