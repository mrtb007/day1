using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference. Go to the editor
//Sample Input:
//53
//30
//51
//Expected Output:
//6
//21
//0
//Click me to see the solution
namespace day1
{
    public class bt1
    {
        int n = 45;
        public int testb1()
        {
            if (n > 51)
            {
                return (n - 51) * 3;
            }
            else
            {
                return 51 - n;
            }
        }
    }
}
