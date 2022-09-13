using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average. Go to the editor
//Test Data :
//Input the 10 numbers :
//Number - 1 :2...
//Number - 10 :2
//Expected Output :
//The sum of 10 no is : 51
//The Average is : 5.100000

namespace day1
{
    public class bt11
    {

        public static void b11()
        {
            int tong = 0;
            for (int i = 0; i < 10; i++)
            {
                int num;
                Console.WriteLine($"so thu {i + 1}: ");
                num = Convert.ToInt32(Console.ReadLine());
                tong += num;
            }
            Console.WriteLine($"tong cua chung bang {tong}");
            Console.WriteLine($"trung binh cong cua chung bang {tong / 10.0}");

        }
    }
}
