using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200. Go to the editor

//Sample Input:
//103
//90
//89
//Expected Output:
//True
//True
//False
namespace day1
{
    public class bt3
    {
        public static bool testb3(int a)
            {
            if ((a > 189 & a < 211) || (a > 89 & a < 111))
                return true;
            else return false;
            }
    }
}
