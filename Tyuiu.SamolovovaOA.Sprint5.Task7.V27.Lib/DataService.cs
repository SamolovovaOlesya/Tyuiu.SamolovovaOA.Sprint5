using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.SamolovovaOA.Sprint5.Task7.V27.Lib
{
    public class DataService : ISprint5Task7V27
    {
        public string LoadDataAndSave(string path)
        {
            // 1. Папка, где лежит входной файл
            string dir = Path.GetDirectoryName(path);

            // 2. Полный путь к выходному файлу в той же папке
            string pathSaveFile = Path.Combine(dir, "OutPutDataFileTask7V27.txt");

            // 3. Если такой файл уже есть – удаляем
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            if (fileInfo.Exists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                // читаем файл построчно
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

            // 4. По шаблону: возвращаем путь к выходному файлу
            return pathSaveFile;
        }
    }
}
