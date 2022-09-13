using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.Write a C# Sharp program to check whether a given number is positive or negative. Go to the editor
//Test Data : 14
//Expected Output :
//14 is a positive number
namespace day1
{
    public class bt8
    {
        public static void b8()
        {
            int a;
            Console.WriteLine("Nhap so bat ky:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 0)
            {
                Console.WriteLine($"{a} la so duong");
            }
            else Console.WriteLine($"{a} la so am");
        }
    }
}
