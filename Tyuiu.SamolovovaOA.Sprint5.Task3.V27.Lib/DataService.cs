using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SamolovovaOA.Sprint5.Task3.V27.Lib
{
    public class DataService : ISprint5Task3V27
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            double y = Math.Pow(x - 1, 3 * x + 1);
            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create, FileAccess.Write), Encoding.UTF8))
            {
                writer.Write(y);   
            }

            return path;
        }
    }
}
