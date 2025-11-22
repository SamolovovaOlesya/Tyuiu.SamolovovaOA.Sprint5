using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.SamolovovaOA.Sprint5.Task7.V27.Lib
{
    public class DataService : ISprint5Task7V27
    {
        public string LoadDataAndSave(string path)
        {

            string pathSaveFile = Path.Combine(
               Path.GetTempPath(),
               "OutPutDataFileTask7V27.txt"
           );

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    strLine = "";
                    bool prevSpace = false;

                    for (int i = 0; i < line.Length; i++)
                    {
                        char ch = line[i];

                        if (ch == ' ')
                        {
                            if (!prevSpace)
                            {
                                strLine += ch;
                                prevSpace = true;
                            }
                        }
                        else
                        {
                            strLine += ch;
                            prevSpace = false;
                        }
                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                }
            }

            return pathSaveFile;
        }
    }
}
