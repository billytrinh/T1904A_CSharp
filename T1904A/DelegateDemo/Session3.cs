using System;

namespace T1904A.DelegateDemo
{
    // khai bao  1 delegate
    public delegate void DemoDelegate(string s);
    
    public class Session3
    {
        public event DemoDelegate demoEvent;
        
        static void Main(string[] args)
        {
            // tao 1 the hien cua delegate
            // DemoDelegate dd = new DemoDelegate(SayHello);
            // dd("abc xyz");
            // DemoDelegate dd2 = new DemoDelegate(new Session3().SayAnything);
            // dd2("hello world");
            // dd = dd + dd2;
            // dd("T1904A");
            // Session3 s3 = new Session3();
            // s3.RunEvent();
            Product p = new Product();
            p.Price = 20000;
            Console.WriteLine("Tien da co");
            p.Price = 30000;
        }

        public void RunEvent()
        {
            if (demoEvent == null)
            {
                demoEvent += SayHello;
            }

            demoEvent("Chay thu nghiem");
        }
        
        public static void SayHello(string str)
        {
            Console.WriteLine("Say Hello: "+str);
        }

        public void SayAnything(string ss)
        {
            Console.WriteLine("Say anything: "+ss);
        }
    }
}