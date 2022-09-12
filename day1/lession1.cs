using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    public class lession1
    {

        private string intro()
        {
            string userName = "Nguyen Ngoc Thinh";
            string tuoi = "32";
            int tuoi1 = Convert.ToInt32(tuoi);

            string profile = "Ten : " + userName + ", Tuoi : " + tuoi1;

            return profile;
        }

        public string intro2()
        {
            return intro();
        }
    }
}
