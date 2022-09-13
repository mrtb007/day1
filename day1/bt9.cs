using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.Write a C# Sharp program to find whether a given year is a leap year or not. Go to the editor
//Test Data : 2016
//Expected Output :
//2016 is a leap year.
namespace day1
{
    public class bt9
    {
        public static void b9()
        {
            int nam;
            Console.WriteLine("Nhap nam can kiem tra:");
            nam = Convert.ToInt32(Console.ReadLine());
            if (nam % 4 == 0)
            {
                Console.WriteLine($"Nam {nam} la nam nhuan");
            }
            else Console.WriteLine($"Nam {nam} la nam binh thuong");
        }
    }
}
