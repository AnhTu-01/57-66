using System;
using System.Text.Json;

class Program
{
    static void Main()
    {
        double r;
        
        while (true)
        {
            Console.WriteLine("Nhập bán kính r của hình tròn:");
            string input = Console.ReadLine();
            
            if (double.TryParse(input, out r) && r > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại.");
            }
        }

        string result = CalculateCircleProperties(r);
        Console.WriteLine("Kết quả: " + result);
    }

    static string CalculateCircleProperties(double r)
    {
        double dienTich = Math.PI * Math.Pow(r, 2);
        double chuVi = 2 * Math.PI * r;
        double duongKinh = 2 * r;

        var result = new 
        {
            dien_tich = dienTich,
            chu_vi = chuVi,
            duong_kinh = duongKinh
        };

        return JsonSerializer.Serialize(result);
    }
}