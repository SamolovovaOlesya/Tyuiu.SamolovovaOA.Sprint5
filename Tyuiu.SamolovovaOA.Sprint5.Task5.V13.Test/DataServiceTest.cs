using System.Globalization;
using Tyuiu.SamolovovaOA.Sprint5.Task5.V13.Lib;
namespace Tyuiu.SamolovovaOA.Sprint5.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_CorrectAverageInRange()
        {
            string tempDir = Path.GetTempPath();
            string path = Path.Combine(tempDir, "InPutDataFileTask5V13.txt");

            double[] numbers = { -2.0, -1.5, -1.0, 0.0, 1.4, 1.5, 2.0 };

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    string s = numbers[i].ToString(CultureInfo.InvariantCulture);
                    if (i < numbers.Length - 1)
                        writer.Write(s + " ");
                    else
                        writer.Write(s);
                }
            }
            double sum = -1.5 + (-1.0) + 0.0 + 1.4 + 1.5;
            int count = 5;
            double expected = sum / count;
            expected = Math.Round(expected, 3);

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected, result);
        }
    }
}
