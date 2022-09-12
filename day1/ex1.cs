using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    /// <summary>
    /// Write a C# Sharp program to print the result of dividing two numbers. 
    /// </summary>
    public class ex1
    {
        int num1, num2;
        public void nhapdulieu()
        {
            Console.WriteLine("Nhap so thu nhat");
            var a = Console.ReadLine();
            num1 = Convert.ToInt32(a);

            Console.WriteLine("Nhap so thu hai");
            var b = Console.ReadLine();
            num2 = Convert.ToInt32(b);
        }
        public int cong2so()
        {
            return num1 + num2;
        }
        public string tru2so()
        {
            return (num1 - num2).ToString();
        }
        public int nhan2so()
        {
            return num1 * num2;
        }
        public int chia2so()
        {
            return num1 / num2;
        }
    }
}
