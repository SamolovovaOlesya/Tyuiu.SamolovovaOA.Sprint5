using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.SamolovovaOA.Sprint5.Task7.V27.Lib
{
    public class DataService : ISprint5Task7V27
    {
        public string LoadDataAndSave(string path)
        {
            string tempDir = Path.GetTempPath();
            string pathSaveFile = Path.Combine(tempDir, "OutPutDataFileTask7V27.txt");

            // 2. Если такой файл уже есть в temp – удаляем
            if (File.Exists(pathSaveFile))
            {
                File.Delete(pathSaveFile);
            }

            // 3. Читаем входной файл и убираем лишние пробелы (оставляем только по одному)
            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string strLine = "";
                    bool prevSpace = false;

                    for (int i = 0; i < line.Length; i++)
                    {
                        char ch = line[i];

                        if (ch == ' ')
                        {
                            if (!prevSpace)
                            {
                                // первый пробел оставляем
                                strLine += ch;
                                prevSpace = true;
                            }
                            // второй, третий и т.д. просто пропускаем
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

            // 4. По шаблону: метод возвращает путь к выходному файлу
            return pathSaveFile;
        }
    }
}
