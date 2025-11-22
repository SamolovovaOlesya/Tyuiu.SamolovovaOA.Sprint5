using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.SamolovovaOA.Sprint5.Task6.V5.Lib
{
    public class DataService : ISprint5Task6V5
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            int count = 0;

            foreach (char ch in text)
            {
                if (ch >= 'A' && ch <= 'Z')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
