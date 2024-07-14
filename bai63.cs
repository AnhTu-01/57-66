using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        Dictionary<string, object> dictionary = new Dictionary<string, object>
        {
            { "dien_tich", 78.5 },
            { "chu_vi", 31.4 },
            { "duong_kinh", 10.0 }
        };

        string fileName = "output1.json";
        WriteDictionaryToJsonFile1(fileName, dictionary);
        Console.WriteLine($"Đã ghi dictionary vào file {fileName} bằng System.Text.Json.");
    }

    static void WriteDictionaryToJsonFile1(string fileName, Dictionary<string, object> dictionary)
    {
        string jsonString = JsonSerializer.Serialize(dictionary, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(fileName, jsonString);
    }
}