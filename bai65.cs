using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        Dictionary<string, double> dictionary = new Dictionary<string, double>
        {
            { "dien_tich", 78.5 },
            { "chu_vi", 31.4 },
            { "duong_kinh", 10.0 }
        };

        string fileName = "output.csv";
        WriteDictionaryToCsvFile(fileName, dictionary);
        Console.WriteLine($"Đã ghi dictionary ra file {fileName}.");
    }

    static void WriteDictionaryToCsvFile(string fileName, Dictionary<string, double> dictionary)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            // Ghi header
            writer.WriteLine("Key,Value");

            // Ghi từng phần tử trong Dictionary
            foreach (var kvp in dictionary)
            {
                writer.WriteLine($"{kvp.Key},{kvp.Value}");
            }
        }
    }
}