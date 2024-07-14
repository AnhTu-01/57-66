using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string fileName = "data.json"; // Thay thế bằng tên tệp JSON của bạn
        var dictionary = ReadJsonFileToDictionary1(fileName);
        
        // Hiển thị nội dung của dictionary
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }

    static Dictionary<string, object> ReadJsonFileToDictionary1(string fileName)
    {
        string jsonString = File.ReadAllText(fileName);
        var dictionary = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonString);
        return dictionary;
    }
}