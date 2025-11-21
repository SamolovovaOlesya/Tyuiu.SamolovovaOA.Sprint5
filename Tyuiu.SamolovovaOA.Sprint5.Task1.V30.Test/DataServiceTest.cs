using System.IO;
using Tyuiu.SamolovovaOA.Sprint5.Task1.V30.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
namespace Tyuiu.SamolovovaOA.Sprint5.Task1.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\SamOl\source\repos\Tyuiu.SamolovovaOA.Sprint5\Tyuiu.SamolovovaOA.Sprint5.Task1.V30\bin\Debug\net8.0\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
