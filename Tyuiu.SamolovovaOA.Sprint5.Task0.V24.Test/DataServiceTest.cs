using Tyuiu.SamolovovaOA.Sprint5.Task0.V24.Lib;
using System.IO;
namespace Tyuiu.SamolovovaOA.Sprint5.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(3);

            FileInfo fi = new FileInfo(path);
            bool fileExists = fi.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
