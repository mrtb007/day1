using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    public class bt5
    {

        public static void b5()
        {
            string matkhau = "thinh123";
            Console.Write("nhap mat khau: ");
            string mk1 = Console.ReadLine();
            for (int i = 3; i > 0; i--)
            {
                if (mk1 == matkhau)
                {
                    Console.WriteLine("login");
                    break;
                }
                else if ((mk1 != matkhau) & (i > 1))
                {
                    Console.Write($"Ban da nhap sai mat khau, vui long thu lai (Con {i - 1} lan thu): ");
                    mk1 = Console.ReadLine();
                }
                else Console.WriteLine("Reject");
            }

        }
    }
}
