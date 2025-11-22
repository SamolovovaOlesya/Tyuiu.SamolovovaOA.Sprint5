using System.Globalization;
using System.IO;
using Tyuiu.SamolovovaOA.Sprint5.Task4.V10.Lib;
namespace Tyuiu.SamolovovaOA.Sprint5.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_CalculatesCorrectResult()
        {
            string tempDir = Path.GetTempPath();
            string path = Path.Combine(tempDir, "InPutDataFileTask4V0.txt");

            double x = 2.5;

            File.WriteAllText(path, x.ToString(CultureInfo.InvariantCulture));

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            double expected = Math.Pow(x, 3) * 1.2 * x + 2;
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result);
        }
    }
}
