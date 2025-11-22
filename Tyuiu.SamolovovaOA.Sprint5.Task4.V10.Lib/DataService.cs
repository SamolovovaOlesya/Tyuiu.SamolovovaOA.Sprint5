using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SamolovovaOA.Sprint5.Task4.V10.Lib
{
    public class DataService : ISprint5Task4V10
    {
        public double LoadFromDataFile(string path)
        {
            string text;
            using (StreamReader reader = new StreamReader(path))
            {
                text = reader.ReadLine();
            }

            double x;

            if (!double.TryParse(text, NumberStyles.Any,
                                 CultureInfo.InvariantCulture, out x))
            {
                x = double.Parse(text, CultureInfo.CurrentCulture);
            }

            double y = Math.Pow(x, 3) * 1.2 * x + 2;

            y = Math.Round(y, 3);

            return y;
        }
    }
}
