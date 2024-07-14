using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string fileName = "data.csv"; // Thay thế bằng tên tệp CSV của bạn
        bool hasHeader = true; // Đặt thành false nếu tệp không có header

        double[,] resultArray = ReadCsvFileTo2DArray(fileName, hasHeader);

        // Hiển thị nội dung của mảng 2 chiều
        for (int i = 0; i < resultArray.GetLength(0); i++)
        {
            for (int j = 0; j < resultArray.GetLength(1); j++)
            {
                Console.Write(resultArray[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static double[,] ReadCsvFileTo2DArray(string fileName, bool hasHeader)
    {
        List<double[]> rows = new List<double[]>();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            if (hasHeader)
            {
                // Bỏ qua dòng header
                reader.ReadLine();
            }

            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                double[] row = Array.ConvertAll(parts, part => double.Parse(part, CultureInfo.InvariantCulture));
                rows.Add(row);
            }
        }

        if (rows.Count == 0)
        {
            return new double[0, 0];
        }

        int numRows = rows.Count;
        int numCols = rows[0].Length;
        double[,] resultArray = new double[numRows, numCols];

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                resultArray[i, j] = rows[i][j];
            }
        }

        return resultArray;
    }
}