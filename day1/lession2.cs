using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    public class lession2
    {
        // tao 1 object 
        int num1;
        int num2;
        public int TinhTong()
        {
            Console.WriteLine("Nhap so thu nhat");
            var a = Console.ReadLine();
            num1 = Convert.ToInt32(a);

            Console.WriteLine("Nhap so thu hai");
            var b = Console.ReadLine();
            num2 = Convert.ToInt32(b);

            int sum = num1 + num2;
            return sum;
        }

        public int TinhTong(int a, int b)
        {
            return a + b;
        }
    }
}
