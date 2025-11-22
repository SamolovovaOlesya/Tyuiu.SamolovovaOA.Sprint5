using Tyuiu.SamolovovaOA.Sprint5.Task6.V5.Lib;
using System.IO;
namespace Tyuiu.SamolovovaOA.Sprint5.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_CountsUppercaseLatinCorrectly()
        {
            string tempDir = Path.GetTempPath();
            string path = Path.Combine(tempDir, "InPutDataFileTask6V5.txt");

            string testString = "AbCdeF123 g!ZхЙ zQ";

            testString = "ABCdefGzZq";

            File.WriteAllText(path, testString);

            int expected = 5;
            DataService ds = new DataService();
            int result = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected, result);
        }
    }
}
