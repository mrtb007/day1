using System;
using System.Security.Cryptography.X509Certificates;

namespace day1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string userName = "Nguyen Ngoc Thinh";
            //string tuoi = "32";
            //int tuoi1 = Convert.ToInt32(tuoi);

            //string profile = "Ten : " + userName+ ", Tuoi : " + tuoi1;
            // Ten : Nguyen Ngoc Thinh, Tuoi : 32.

            // call 1 class 
            var lession = new lession1();
            Console.WriteLine(lession.intro2());

        }
    }
}