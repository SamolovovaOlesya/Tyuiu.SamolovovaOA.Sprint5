using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SamolovovaOA.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            string[] parts = text.Split(
                new char[] { ' ', '\r', '\n', '\t', ';', ',' },
                StringSplitOptions.RemoveEmptyEntries);

            double sum = 0.0;
            int count = 0;

            foreach (string part in parts)
            {
                double value;

                if (double.TryParse(part, NumberStyles.Any, CultureInfo.InvariantCulture, out value) ||
                    double.TryParse(part, NumberStyles.Any, CultureInfo.CurrentCulture, out value))
                {
                    if (value >= -1.5 && value <= 1.5)
                    {
                        sum += value;
                        count++;
                    }
                }
            }

            if (count == 0)
            {
                return 0.0;
            }

            double avg = sum / count;
            avg = Math.Round(avg, 3);

            return avg;
        
        }
    }
}
