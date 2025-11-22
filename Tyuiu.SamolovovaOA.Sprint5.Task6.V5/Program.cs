using Tyuiu.SamolovovaOA.Sprint5.Task6.V5.Lib;

namespace Tyuiu.SamolovovaOA.Sprint5.Task6.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Задание 6 | Вариант 5 | Самолёгова О.А.";

            // путь к входному файлу в TEMP, как требуют условия
            string tempDir = Path.GetTempPath();
            string path = Path.Combine(tempDir, "InPutDataFileTask6V5.txt");

            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("Файл с набором символьных данных:");
            Console.WriteLine(path);
            Console.WriteLine();

            DataService ds = new DataService();
            int count = ds.LoadFromDataFile(path);

            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine($"Количество заглавных латинских букв = {count}");

            Console.ReadKey();
        }
    }
}
