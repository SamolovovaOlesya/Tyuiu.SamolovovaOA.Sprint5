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
            string path = @"C:\Users\SamOl\AppData\Local\Temp\OutPutDataFileTask7V27.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
