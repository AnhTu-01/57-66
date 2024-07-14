using System;
using System.IO;

class Program
{
    static void Main()
    {
        float[,] array2D = {
            { 1.1f, 2.2f, 3.3f },
            { 4.4f, 5.5f, 6.6f },
            { 7.7f, 8.8f, 9.9f }
        };

        string fileName = "output.csv";
        Write2DArrayToCsvFile(fileName, array2D);
        Console.WriteLine($"Đã ghi mảng 2 chiều ra file {fileName}.");
    }

    static void Write2DArrayToCsvFile(string fileName, float[,] array2D)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            int rows = array2D.GetLength(0);
            int cols = array2D.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                string[] row = new string[cols];
                for (int j = 0; j < cols; j++)
                {
                    row[j] = array2D[i, j].ToString();
                }
                writer.WriteLine(string.Join(",", row));
            }
        }
    }
}