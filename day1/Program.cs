﻿using System;
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
            //var lession = new lession1();
            //Console.WriteLine(lession.intro2());
            //var lession = new lession2();
            //Console.WriteLine(lession.TinhTong());
            //var ex = new ex1();
            //ex.nhapdulieu();
            //Console.WriteLine("Tong 2 so: " + ex.cong2so());
            //Console.WriteLine("Hieu 2 so: " + ex.tru2so());
            //Console.WriteLine("Tich 2 so: " + ex.nhan2so());
            //Console.WriteLine("Chia 2 so: " + ex.chia2so());
            var bt = new bt1();
            Console.WriteLine(bt.bt2());

            
        }
    }
}