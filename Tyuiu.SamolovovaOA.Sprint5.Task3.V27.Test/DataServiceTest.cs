using Tyuiu.SamolovovaOA.Sprint5.Task3.V27.Lib;
namespace Tyuiu.SamolovovaOA.Sprint5.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            int x = 3;

            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(x);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
