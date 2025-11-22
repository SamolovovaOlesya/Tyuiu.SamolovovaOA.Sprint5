using Tyuiu.SamolovovaOA.Sprint5.Task4.V10.Lib;

namespace Tyuiu.SamolovovaOA.Sprint5.Task4.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Задание 4 | Вариант 10 | Самолёгова О.А.";

            string tempDir = Path.GetTempPath();
            string path = Path.Combine(tempDir, "InPutDataFileTask4V0.txt");

            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("Файл с входным значением x:");
            Console.WriteLine(path);
            Console.WriteLine();

            DataService ds = new DataService();

            double y = ds.LoadFromDataFile(path);

            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine($"y = {y:F3}");

            Console.ReadKey();
        }
    }
}