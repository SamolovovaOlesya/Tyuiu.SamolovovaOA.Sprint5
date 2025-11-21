using Tyuiu.SamolovovaOA.Sprint5.Task1.V30.Lib;

namespace Tyuiu.SamolovovaOA.Sprint5.Task1.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                   *");
            Console.WriteLine("****************************************************");
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue  = " + stopValue);
            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ (таблица значений функции F(x))         *");
            Console.WriteLine("****************************************************");
            Console.WriteLine("   x\tF(x)");
            Console.WriteLine("------------------------");

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;
                double denominator = 2 - 2 * x;

                if (denominator == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Cos(x) + Math.Sin(x) / denominator - 4 * x;
                }

                y = Math.Round(y, 2);

                Console.WriteLine($"{x,3}\t{y,6:F2}");
            }

            Console.WriteLine();

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
