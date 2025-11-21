using Tyuiu.SamolovovaOA.Sprint5.Task2.V15.Lib;
namespace Tyuiu.SamoLovovaOA.Sprints.Task2.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила Самолёгова О.А. | Вариант 15";

            int[,] matrix = new int[3, 3];

            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("РЕЗУЛЬТАТ:");

            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(matrix);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Файл успешно сохранён по пути:");
            Console.WriteLine(path);

            Console.ReadKey();
        }
    }
}