using Tyuiu.SamolovovaOA.Sprint5.Task7.V27.Lib;
using System.IO;
namespace Tyuiu.SamolovovaOA.Sprint5.Task7.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Задание 7 | Вариант 27 | Самолёгова О.А.";

            DataService ds = new DataService();

            Console.WriteLine("*************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine("*************************************");
            Console.WriteLine();

            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask7V27.txt";
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V27.txt";

            Console.WriteLine("Данные находятся в файле:");
            Console.WriteLine(path);
            Console.WriteLine();

            Console.WriteLine("*************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("*************************************");
            Console.WriteLine();

            pathSaveFile = ds.LoadDataAndSave(path);

            Console.WriteLine("Обработанные данные находятся в файле:");
            Console.WriteLine(pathSaveFile);

            Console.ReadKey();
        }
    }
}