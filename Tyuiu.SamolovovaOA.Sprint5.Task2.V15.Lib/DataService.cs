using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SamolovovaOA.Sprint5.Task2.V15.Lib
{
    public class DataService : ISprint5Task2V15
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                string str = "";

                for (int j = 0; j < columns; j++)
                {
                    int value = matrix[i, j];

                    if (value % 2 != 0)
                    {
                        value = 0;
                    }

                    if (j != columns - 1)
                    {
                        str += value.ToString() + ";";
                    }
                    else
                    {
                        str += value.ToString();
                    }
                }
            
                if (i == 0)
                {
                    File.AppendAllText(path, str);
                }
                else
                {
                    File.AppendAllText(path, Environment.NewLine + str);
                }
            }

            return path;
        }
    }
}
