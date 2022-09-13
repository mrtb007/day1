using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number. Go to the editor
//Test Data
//Enter a number: 6
//Enter the desired width: 6
//Expected Output :

//666666
//66666
//6666
//666
//66
//6
namespace day1
{
    public class bt4
    {
        public static void b4()
        {
            Console.Write("Nhap so: ");
            int so = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap do dai: ");
            int dai = Convert.ToInt32(Console.ReadLine());
            for (int i = dai; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(so);
                Console.WriteLine();

            }
        }
    }
}
