using Tyuiu.SamolovovaOA.Sprint5.Task3.V27.Lib;

namespace Tyuiu.SamolovovaOA.Sprint5.Task3.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Задание 3 | Вариант 27 | Самолёгова О.А.";

            int x = 3;

            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine($"x = {x}");
            Console.WriteLine();

            DataService ds = new DataService();

            string path = ds.SaveToFileBinaryData(x);

            double y;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                byte[] buff = reader.ReadBytes(sizeof(double));
                y = BitConverter.ToDouble(buff, 0);
            }

            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine($"y = {y:F3}");
            Console.WriteLine();
            Console.WriteLine("Файл:");
            Console.WriteLine(path);
            Console.WriteLine("создан!");

            Console.ReadKey();
        }
    }
}