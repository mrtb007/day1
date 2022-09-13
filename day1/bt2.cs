using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30. Go to the editor

//Sample Input:
//30, 0
//25, 5
//20, 30
//20, 25
//Expected Output:
//True
//True
//True
//False
namespace day1
{
    public class bt2
    {
        public static bool testb2(int a, int b)
        {
            if ((a == 30) || (b == 30) || (a + b == 30))
            {
                return true;
            }
            else return false;



        }
    }
}
