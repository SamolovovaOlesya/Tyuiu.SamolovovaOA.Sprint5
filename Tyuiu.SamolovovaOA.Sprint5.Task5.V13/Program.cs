using Tyuiu.SamolovovaOA.Sprint5.Task5.V13.Lib;

namespace Tyuiu.SamolovovaOA.Sprint5.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Задание 5.5 | Вариант 13 | Самолёгова О.А.";

            string tempDir = Path.GetTempPath();
            string path = Path.Combine(tempDir, "InPutDataFileTask5V13.txt");

            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("Файл с набором чисел:");
            Console.WriteLine(path);
            Console.WriteLine();

            DataService ds = new DataService();
            double avg = ds.LoadFromDataFile(path);

            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine($"Среднее значение чисел из диапазона [-1.5; 1.5] = {avg:F3}");

            Console.ReadKey();
        }
    }
}