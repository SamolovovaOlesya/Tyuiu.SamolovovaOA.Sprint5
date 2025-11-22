using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.SamolovovaOA.Sprint5.Task7.V27.Lib
{
    public class DataService : ISprint5Task7V27
    {
        public string LoadDataAndSave(string path)
        {

            string pathSaveFile = $"{Directory.GetCurrentDirectory()}\\OutPutDataFileTask7V27.txt";

            if (File.Exists(pathSaveFile))
            {
                File.Delete(pathSaveFile);
            }

            string result = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    bool prevSpace = false;

                    foreach (char ch in line)
                    {
                        if (ch == ' ')
                        {
                            if (!prevSpace)
                            {
                                result += ch;
                                prevSpace = true;
                            }
                        }
                        else
                        {
                            result += ch;
                            prevSpace = false;
                        }
                    }
                }
            }
            File.WriteAllText(pathSaveFile, result);

            return result;
        }
    }
}
