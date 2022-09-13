using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.Write a C# Sharp program to check whether a given number is even or odd. Go to the editor
//Test Data : 15
//Expected Output :
//15 is an odd integer
namespace day1
{
    public class bt7
    {
        public static void b7()
        {
            int a;
            Console.WriteLine("Nhap so bat ky: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} la so chan");
            }
            else Console.WriteLine($"{a} la so le");
        }
    }
}
