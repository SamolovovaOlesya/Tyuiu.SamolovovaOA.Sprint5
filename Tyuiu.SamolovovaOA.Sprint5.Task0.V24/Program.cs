using Tyuiu.SamolovovaOA.Sprint5.Task0.V24.Lib;

namespace Tyuiu.SamolovovaOA.Sprint5.Task0.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            DataService ds = new DataService();

            Console.WriteLine("*************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                    *");
            Console.WriteLine("*************************************");
            Console.WriteLine("x = " + x);
            Console.WriteLine();

            Console.WriteLine("*************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                          *");
            Console.WriteLine("*************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("создан!");
            Console.ReadKey();
        }
    }
}