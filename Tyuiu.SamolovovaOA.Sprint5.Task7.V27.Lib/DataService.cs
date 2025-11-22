using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.SamolovovaOA.Sprint5.Task7.V27.Lib
{
    public class DataService : ISprint5Task7V27
    {
        public string LoadDataAndSave(string path)
        {
            string fileName = "OutPutDataFileTask7V27.txt";

            // создаём файл в Temp – там тесты ИМЕЮТ ПРАВО писать
            string savePath = Path.Combine(Path.GetTempPath(), fileName);

            if (File.Exists(savePath))
            {
                File.Delete(savePath);
            }

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    // УДАЛЯЕМ ВСЕ ПРОБЕЛЫ
                    string cleaned = RemoveAllSpaces(line);

                    File.AppendAllText(savePath, cleaned + Environment.NewLine);
                }
            }

            return savePath;
        }
         
        // Функция, которая УДАЛЯЕТ ВСЕ ПРОБЕЛЫ ПОЛНОСТЬЮ
        private string RemoveAllSpaces(string line)
        {
            string result = "";

            foreach (char ch in line)
            {
                if (ch != ' ')
                {
                    result += ch;
                }
            }

            return result;
        }
    }
}
