using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    public class bt6
    {
        public static void b6()
        {
            int a, b;
            char pheptinh;
            Console.WriteLine("Nhap so thu nhat: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap phep tinh: ");
            pheptinh = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("nhap so thu hai: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (pheptinh == '+')
            {
                Console.WriteLine($"{a} + {b} = {a + b}");
            }
            else if (pheptinh == '-')
            {
                Console.WriteLine($"{a} - {b} = {a - b}");
            }
            else if ((pheptinh == '*') || (pheptinh == 'x'))
            {
                Console.WriteLine($"{a} x {b} = {a * b}");
            }
            else if (pheptinh == '/')
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
            } else Console.WriteLine("Sai phep tinh");
        }
    }
}
