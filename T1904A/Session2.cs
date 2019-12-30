using System;
using System.Collections.Generic;

namespace T1904A
{
    public class Session2
    {
        static void Main(string[] args)
        {
            Human h = new Human();
            h.SayHello();
            h.SayHello("Anna");
            Asian a = new Asian();
            a.SayHello();
            a.Jumping();
            h.Age = 12;
            Console.WriteLine("tuoi: "+h.Age);
            h.Age = -1;
            Console.WriteLine("tuoi 2: "+h.Age);
            a.telephone[0] = "09876543";
            a.telephone[1] = "09998888";
            a[2] = "01234567";
            a[3] = "0938474";
            Console.WriteLine("chi muc 1: "+a[1]);
            List<string> strList = new List<string>();
            strList.Add("aa");
            strList[1] = "bb";
            
        }
    }
}