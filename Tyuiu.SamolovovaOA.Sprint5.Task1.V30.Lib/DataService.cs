using tyuiu.cources.programming.interfaces;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SamolovovaOA.Sprint5.Task1.V30.Lib
{
    public class DataService : ISprint5Task1V30
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;
                double denominator = 2 - 2 * x;

                if (denominator == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Cos(x) + Math.Sin(x) / denominator - 4 * x;
                }

                y = Math.Round(y, 2);
                string strY = y.ToString();

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
