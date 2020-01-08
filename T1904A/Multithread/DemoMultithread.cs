using System;
using System.Threading;

namespace T1904A.Multithread
{
    public class DemoMultithread
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(RunInThread);
            //t1.Start("object demo");
            
            Thread t2 = new Thread(new DemoMultithread().RunInThread2);
            //t2.Start();
            // Main Thread
            // for (int i = 0; i < 100; i++)
            // {
            //     try
            //     {
            //         Console.WriteLine("Main Run.. "+i);
            //         Thread.Sleep(100);
            //     }catch (Exception e){}
            // }
            
            Thread t3 = new Thread(Clock);
            t3.Start(1);
        }

        public static void Clock(Object min)
        {
            for (int i = (int)min-1; i >= 0; i--)
            {
                for (int j = 59; j >= 0; j--)
                {
                    Console.WriteLine(i.ToString("d2")+":"+j.ToString("d2"));
                    try {
                        Thread.Sleep(1000);
                    }catch(Exception e){}
                }
            }
        }
        public static void RunInThread(Object o)
        {
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    Console.WriteLine(o+" Run.. "+i);
                    Thread.Sleep(100);
                }catch (Exception e){}
            }
        }

        public void RunInThread2()
        {
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    Console.WriteLine("Run 2.. "+i);
                    Thread.Sleep(100);
                }catch (Exception e){}
            }
        }
    }
}