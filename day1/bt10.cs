using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.Write a C# Sharp program to find the sum of first 10 natural numbers. Go to the editor
//Expected Output :
//The first 10 natural number is :
//1 2 3 4 5 6 7 8 9 10
//The Sum is : 55
namespace day1
{
    public class bt10
    {
        public static void b10()
        {
            int num, tong;
            Console.WriteLine("nhap so bat ky: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num} so tu nhien dau tien la: ");
            tong = 0;
            for (int i = 1; i < num + 1; i++)
            {
                Console.Write(i + " ");
                tong += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Tong cua chung la {tong}");
        }
    }
}
